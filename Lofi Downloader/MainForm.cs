﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Lofi_Downloader
{
	public partial class MainForm : Form
	{
		// field
		LofiParser lofiParser;
		string saveFolder;
		bool IsDownloading;

		// constructor
		public MainForm()
		{
			InitializeComponent();

			lofiParser = new LofiParser();
			lofiParser.WebClient.DownloadFileCompleted += (sender, e) =>
			{
				allProgressBar.Value++;
				allProgressLabel.Text = ("( " + allProgressBar.Value + " / " + allProgressBar.Maximum + " )");
			};
			lofiParser.WebClient.DownloadProgressChanged += (sender, e) =>
			{
				thisProgressBar.Value = e.ProgressPercentage;
				thisProgressLabel.Text = ("( " + e.ProgressPercentage + " % )");
			};

			lofiParser.GettingImageProgressStart += (sender, e) =>
			{
				gettingImageProgressBar.Value = 0;
			};
			lofiParser.GettingImageProgressChanged += (sender, e) =>
			{
				gettingImageProgressBar.Value++;
				gettingImageLabel.Text = ("( " + gettingImageProgressBar.Value + " / " + gettingImageProgressBar.Maximum + " )");
			};
			lofiParser.DownloadImagesCompleted += (sender, e) =>
			{
				MessageBox.Show("Download Complete!");
				Process.Start(saveFolder);
			};

			folderBrowserDialog.Description = "Select folder!";
		}

		// enum
		enum ProgressStatus
		{
			GettingImages, DownloadingImges
		}

		// event handler methods
		private void findButton_Click(object sender, EventArgs e)
		{
			try
			{
				lofiParser.PageUrl = textBox1.Text;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			int max = lofiParser.PageCount;
			gettingImageProgressBar.Maximum = max;
			allProgressBar.Maximum = max;

			gettingImageProgressBar.Value = 0;
			allProgressBar.Value = 0;
			thisProgressBar.Value = 0;

			gettingImageLabel.Text = ("( 0 / " + gettingImageProgressBar.Maximum + " )");
			allProgressLabel.Text = ("( 0 / " + allProgressBar.Maximum + " )");

			gettingImageLabel.Visible = true;
			allProgressLabel.Visible = true;
			thisProgressLabel.Visible = true;

			pictureBox1.ImageLocation = lofiParser.ThumbNailImage;

			MessageBox.Show("Finding Success!");
		}
		private async void downloadButton_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			Task task;

			if (lofiParser.CanDownload)
			{
				if (!IsDownloading)
				{
					if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
					{
						button.Text = "Pause";
						IsDownloading = true;

						saveFolder = folderBrowserDialog.SelectedPath;
						task = lofiParser.DownloadImages(folderBrowserDialog.SelectedPath);
					}
				}
				else
				{
					

					button.Text = "Download";
					IsDownloading = false;
				}
			}
			else
			{
				MessageBox.Show("Please Find, First!");
			}
		}
	}

	static class HtmlParser
	{
		// private method
		private static string getBody(string html)
		{
			string temp;

			if (html.Contains("<body"))
			{
				int start = html.IndexOf("<body");
				int end = html.IndexOf("</body>");
				temp = html.Substring(start, end - start);

				return temp;
			}
			else
			{
				return html;
			}
		}

		// public methods
		public static bool IsHtmlCode(this string html)
		{
			return html.Contains("<!doctype html") || html.Contains("<!DOCTYPE html");
		}
		public static string GetHtml(string url)
		{
			string html;

			HttpWebResponse response = (HttpWebResponse)WebRequest.CreateHttp(url).GetResponse();

			// 응답이 OK면
			if (response.StatusCode == HttpStatusCode.OK)
			{
				if (response.ResponseUri.AbsoluteUri.Equals("http://www.warning.or.kr/")) throw new ArgumentException("You can't be accepted this page!");

				// 수신 스트림을 만들고
				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream;

				// 만약 캐릭터셋이 없으면 
				if (response.CharacterSet == null)
				{
					// 없는 채로 만들고
					readStream = new StreamReader(receiveStream);
				}
				else // 있으면
				{
					// 그 캐릭터 셋으로 인코딩을 정해
					readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
				}
				// 스트림리더를 만든다.

				// 그 스트림 리더로부터 html을 받는다
				html = readStream.ReadToEnd();

				response.Close();
				readStream.Close();

				return html;
			}
			else // 응답이 OK가 아니면
			{
				throw new ArgumentException("Http Status Code : " + response.StatusCode.ToString());
			}
		}
		public static string GetElementByTag(string html, string tag)
		{
			string temp;
			string body = getBody(html);

			if (body.Contains("<" + tag))
			{
				int start = body.IndexOf("<" + tag);
				int end = body.IndexOf("</" + tag + ">");
				temp = body.Substring(start, end - start);

				return temp;
			}
			else
			{
				return null;
			}
		}
		public static string GetAttribute(string element, string attribute)
		{
			string temp = element.Substring(element.IndexOf(attribute));

			return temp.Substring(temp.IndexOf('"') + 1, temp.IndexOf('"', temp.IndexOf('"') + 1) - attribute.Length - 2); ;
		}
		public static string GetImageLink(string element)
		{
			if (element.Contains("<img"))
			{
				int imgTag = element.IndexOf("src", element.IndexOf("<img"));

				int imgLinkStart = element.IndexOf('"', imgTag) + 1;
				int imgLinkEnd = element.IndexOf('"', imgLinkStart);

				return element.Substring(imgLinkStart, imgLinkEnd - imgLinkStart);
			}
			else
			{
				return null;
			}
		}
	}

	class LofiParser
	{
		// fields
		WebClient webClient;
		string pageUrl;
		string firstPage;
		string thumbNail;
		int pageCount;
		bool canDownload;

		// properties
		public WebClient WebClient { get { return webClient; } }
		public string PageUrl { set {
				pageUrl = value;
				if (IsLofi)
				{
					string html = HtmlParser.GetHtml(value);
					if(!html.IsHtmlCode()) throw new ArgumentException("This page wasn't written in html. : " + html);
					string element = HtmlParser.GetElementByTag(html, "a");
					thumbNail = HtmlParser.GetImageLink(element);
					firstPage = HtmlParser.GetAttribute(element, "href");

					canDownload = true;
				}
				else
				{
					throw new ArgumentException("This page is not Lofi.");
				}
			} }
		public string ThumbNailImage { get { return thumbNail; } }
		public int PageCount { get {
				if (firstPage != null)
				{
					string html = HtmlParser.GetHtml(firstPage);
					string trElement = HtmlParser.GetElementByTag(html, "tr");
					string temp = trElement.Substring(trElement.IndexOf("<td", trElement.IndexOf("<td") + 1));
					string tdElement = HtmlParser.GetElementByTag(temp, "td");

					return pageCount = Convert.ToInt32(tdElement.Substring(tdElement.LastIndexOf('/') + 1));
				}
				else
				{
					throw new NullReferenceException("FirstPage is null!");
				}
			} }
		public bool IsLofi { get { return pageUrl.Contains("http://lofi.e-hentai.org/"); } }
		public bool CanDownload { get { return canDownload; } }

		// events
		public event EventHandler GettingImageProgressStart;
		public event EventHandler GettingImageProgressChanged;
		public event EventHandler DownloadImagesCompleted; 

		// constructor
		public LofiParser()
		{
			webClient = new WebClient();
		}

		// private methods
		private string[] getImages()
		{
			List<string> list = new List<string>();
			string thisPage = firstPage;
			string prevPage = null;

			GettingImageProgressStart?.Invoke(this, EventArgs.Empty); 
			while (!thisPage.Equals(prevPage))
			{
				string html = HtmlParser.GetHtml(thisPage);
				string element = HtmlParser.GetElementByTag(html, "a");

				list.Add(HtmlParser.GetImageLink(element));

				prevPage = thisPage;
				thisPage = HtmlParser.GetAttribute(element, "href");
				
				GettingImageProgressChanged?.Invoke(this, EventArgs.Empty);
			}

			return list.ToArray();
		}
		private async Task downloadImage(string url, string path)
		{
			string fileName = Path.Combine(path, url.Substring(url.LastIndexOf('/') + 1));

			await webClient.DownloadFileTaskAsync(new Uri(url), fileName);

			webClient.Dispose();
		}

		// public method
		public async Task DownloadImages(string path)
		{
			string[] temp = getImages();

			foreach (string s in temp)
			{
				await downloadImage(s, path);
			}
			DownloadImagesCompleted?.Invoke(this, EventArgs.Empty);
		}
	}
}
