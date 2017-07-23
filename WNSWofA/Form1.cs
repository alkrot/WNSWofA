using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using INI_RW;
using Newtonsoft.Json.Linq;
using VkApi;
using ThreadState = System.Threading.ThreadState;

namespace WNSWofA
{
	public partial class Form1 : Form
	{
		private delegate void RenameAnime(PageAnime pa, int index);

		public ApiVk ApiVk = new ApiVk();

		private List<PageAnime> _pagesAnime = new List<PageAnime>();

		private Thread _thr;

		private int _ballonIndex;

		private INI _ini;

	    public string UserConfigPath { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
	                                            "\\WNSWofA\\";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ApiVk.Start(5608359, "pages,groups");
			ApiVk.Send("stats.trackVisitor", "");
			bool flag = !Directory.Exists(UserConfigPath);
		    if (flag)
		        Directory.CreateDirectory(UserConfigPath);
		    string path = UserConfigPath + ApiVk.ID + ".dat";
			LoadSettings();
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
			    using (Stream stream = File.OpenRead(path))
			    {
			        _pagesAnime = (List<PageAnime>) binaryFormatter.Deserialize(stream);

			        foreach (var pageAnime in _pagesAnime)
			        {
                        if(pageAnime != null)
                            _listAnime.Items.Add(pageAnime);
			        }
			        stream.Close();
			    }

			    _thr = new Thread(RefreshSeries);
				_thr.Start();
				_timer1.Enabled = true;
				bool tray = User.Default.Tray;
				if (tray)
				{
					ShowInTaskbar = false;
					_notifyIcon1.Visible = true;
					Hide();
				}
			}
			catch (FileNotFoundException)
			{
				ShowStatus("Список аниме не найден");
			}
		}

		private void LoadSettings()
		{
			LoadSound();
			_ini = new INI(string.Concat(UserConfigPath, "\\settings\\", ApiVk.ID, ".ini"));
			string tray = _ini.iniRead("App", "tray");
			string outVk = _ini.iniRead("App", "outVk");
			string soundPush = _ini.iniRead("App", "soundPush");
			string mute = _ini.iniRead("App", "mute");
			User.Default.Mute = mute != "-1" && bool.Parse(mute);
			User.Default.Tray = tray != "-1" && bool.Parse(tray);
			User.Default.OutVk = outVk != "-1" && bool.Parse(outVk);
			User.Default.SoundPush = soundPush == "-1" ? User.Default.SoundPush : soundPush;
			_cbSound.Text = User.Default.SoundPush;
			_lSettingsStatus.Text = @"Статус";
			_checkMute.Checked = User.Default.Mute;
			_checkTray.Checked = User.Default.Tray;
			_outVkcheck.Checked = User.Default.OutVk;
		}

		public bool Parse(string url)
	{
			char[] separator = {'-','_'};
			string[] array = url.Split(separator);
			int num = int.Parse("-" + array[1]);
			int num2 = int.Parse(array[2]);
		    if (_pagesAnime.Select(t => t.GroupId == num & t.PageId == num2).Any(flag => flag))
		        return false;
		    string text;
			JObject jObject;
			string input;
			bool ongoing;
			string description;
			int countSeries;
			int count;
			SeriesCountParse(num, num2, out text, out jObject, out input, out ongoing, out description, out countSeries, out count);
			string text2 = jObject["response"]["title"].ToString();
			Match match = Regex.Match(input, "<img class=\"wk_photo_no_padding\" wiki=\"-[0-9]+_[0-9]+\" alt=\"\" title=\"\" src=\"(https://[\\S|\\-|A-z|\\.|/|0-9|_]+)\" style=\"width:280px; height:360px;\"");
			string urlImage = match.Groups[1].ToString();
			_listAnime.Items.Add(text2);
			_listAnime.SelectedIndex = _listAnime.Items.Count - 1;
			PageAnime pageAnime = new PageAnime(text2, ongoing, urlImage, count, countSeries, description, num, num2);
			pageAnime.Show(_descriptionText, _posterBox);
			_pagesAnime.Add(pageAnime);
			return true;
		}

		private void SeriesCountParse(int groupId, int pageId, out string param, out JObject get, out string source, out bool ongoing, out string description, out int countSeries, out int count)
		{
			param = string.Concat("owner_id=", groupId, "&page_id=", pageId, "&need_source=1&need_html=1");
			get = ApiVk.Send("pages.get", param, "5.53");
			bool flag = get["error"] == null;
			if (flag)
			{
				source = get["response"]["html"].ToString();
				bool flag2 = source.Length == 0;
			    if (flag2)
			        throw new NullReferenceException("Неизвестная проблема");
			    ongoing = source.IndexOf("131px;", StringComparison.Ordinal) > 0;
				int startIndex = source.IndexOf("Выпуск", StringComparison.Ordinal);
				int endIndex = source.LastIndexOf("</span> </td></tr>", StringComparison.Ordinal);
				description = source.Substring(startIndex, endIndex - startIndex);
				description = Regex.Replace(description, "<[^>]+>", string.Empty).Replace("Жанр", "\r\n________________________\r\nЖанр").Replace("Категория", "\r\n________________________\r\nКатегория").Replace("Oзвучка", "\r\n________________________\r\nOзвучка").Replace("Описание", "\r\n________________________\r\nОписание");
				MatchCollection matchCollection = Regex.Matches(description, "[0-9]+");
				countSeries = int.Parse(matchCollection[1].ToString());
				matchCollection = Regex.Matches(source, "video-[0-9]*_[0-9]*");
				count = matchCollection.Count;
			}
			else
			{
			    get = null;
                description = source = param = null;
				ongoing = false;
				count = countSeries = 0;
			}
		}

	    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			ClosingApp();
		}

		private void ClosingApp()
		{
			ThreadAbort();
			SaveListAnime();
			SaveSettings();
			bool outVk = User.Default.OutVk;
		    if (outVk)
		        OutVk();
		}

		private void SaveListAnime()
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			string path = UserConfigPath + ApiVk.ID + ".dat";
		    using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
		        binaryFormatter.Serialize(stream, _pagesAnime);
		}

		private void SaveSettings()
		{
			_ini.iniWrite("App", "tray", User.Default.Tray.ToString());
			_ini.iniWrite("App", "outVk", User.Default.OutVk.ToString());
			_ini.iniWrite("App", "soundPush", User.Default.SoundPush);
			_ini.iniWrite("App", "mute", User.Default.Mute.ToString());
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = _thr != null && (_thr.ThreadState == ThreadState.Stopped || _thr.ThreadState == ThreadState.Aborted);
			if (flag)
			{
				_thr = new Thread(RefreshSeries);
				_thr.Start();
			}
		}

		private void RefreshSeries()
		{
			foreach (PageAnime current in _pagesAnime)
			{
				string text;
				JObject jObject;
				string text2;
				bool ongoing;
				string text3;
				int num;
				int num2;
				SeriesCountParse(current.GroupId, current.PageId, out text, out jObject, out text2, out ongoing, out text3, out num, out num2);
				current.Ongoing = ongoing;
				bool flag = num2 > current.Count;
				if (flag)
				{
					current.Count = num2;
					bool flag2 = !current.Refresh;
				    if (flag2)
				        current.Refresh = true;
				    int index = ShowBallon(current);
					RenameListAnime(current, index);
					bool flag3 = !User.Default.Mute;
				    if (flag3)
				        PlaySound(User.Default.SoundPush);
				}
				else
				{
					bool flag4 = num2 < current.Count && jObject != null;
					if (flag4)
					{
						ShowBallon(current, "Переазлив");
						current.Count = num2;
					}
				}
				Thread.Sleep(3000);
			}
		}

		private int ShowBallon(PageAnime pa, string text = "Новая серия")
		{
			int result = _pagesAnime.IndexOf(pa);
			_ballonIndex = result;
			bool flag = !_notifyIcon1.Visible;
			if (flag)
			{
				_notifyIcon1.Visible = true;
			}
			_notifyIcon1.ShowBalloonTip(100000, text, pa.Title, ToolTipIcon.Info);
			return result;
		}

		private void RenameListAnime(PageAnime pa, int index)
		{
			bool invokeRequired = InvokeRequired;
		    if (invokeRequired)
		        BeginInvoke(new RenameAnime(RenameListAnime), pa, index);
		    else
		    {
		        _listAnime.Items.RemoveAt(index);
		        _listAnime.Items.Insert(index, pa);
		    }
		}

		private void удалитьИзСпискаToolStripMenuItem_Click(object sender, EventArgs e)
		{
		    bool flag = _listAnime.Items.Count > 0;
		    if (flag)
		    {
		        ThreadAbort();
		        int num = _listAnime.SelectedIndex;
		        _listAnime.Items.RemoveAt(num);
		        _pagesAnime.RemoveAt(num);
		        bool flag2 = _listAnime.Items.Count > 0;
		        if (flag2)
		        {
		            num = num > 1 ? num - 1 : 0;
		            _listAnime.SelectedIndex = num;
		            _pagesAnime[num].Show(_descriptionText, _posterBox);
		            SaveListAnime();
		            _timer1.Enabled = true;
		        }
		    }
        }

		private void WalkingList()
		{
			bool visible = _notifyIcon1.Visible;
			if (visible)
			{
				_notifyIcon1.Visible = false;
			}
			int selectedIndex = _listAnime.SelectedIndex;
			bool flag = selectedIndex >= 0;
			if (flag)
			{
				_pagesAnime[selectedIndex].Show(_descriptionText, _posterBox);
				DelRefresh(selectedIndex);
			}
		}

		private void DelRefresh(int index)
		{
			bool refresh = _pagesAnime[index].Refresh;
			if (refresh)
			{
				ThreadAbort();
				_pagesAnime[index].Refresh = false;
				_listAnime.Items.RemoveAt(index);
				_listAnime.Items.Insert(index, _pagesAnime[index].Title);
				_listAnime.SelectedIndex = index;
				SaveListAnime();
				_timer1.Enabled = true;
			}
		}

		private void ThreadAbort()
		{
			try
			{
				_timer1.Enabled = false;
				bool flag = _thr.ThreadState == ThreadState.Running || _thr.ThreadState == ThreadState.WaitSleepJoin;
			    if (flag)
			        _thr.Abort();
			}
			catch (NullReferenceException ex)
			{
				StreamWriter streamWriter = new StreamWriter("log.txt", true);
				streamWriter.WriteLine(string.Concat(ex.Message, "[\n", ex.Data, "\n", ex.Source, "\n]"));
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		private void открытьВБраузереToolStripMenuItem_Click(object sender, EventArgs e)
		{
		    bool flag = _listAnime.Items.Count > 0;
		    if (flag)
		    {
		        int selectedIndex = _listAnime.SelectedIndex;
		        Process.Start(_pagesAnime[selectedIndex].PageUrl);
		    }
        }

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ShowForm();
		}

		private void ShowForm()
		{
			_notifyIcon1.Visible = false;
			ShowInTaskbar = true;
			WindowState = FormWindowState.Normal;
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			bool flag = WindowState == FormWindowState.Minimized;
			if (flag)
			{
				ShowInTaskbar = false;
				_notifyIcon1.Visible = true;
			}
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
		{
			Process.Start(_pagesAnime[_ballonIndex].PageUrl);
			DelRefresh(_ballonIndex);
			_pagesAnime[_ballonIndex].Show(_descriptionText, _posterBox);
		}

		private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listAnime_Click(object sender, EventArgs e)
		{
			WalkingList();
		}

		private void listAnime_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left;
			if (flag)
			{
				WalkingList();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = _pageUrl.Text.Length > 0;
			    if (flag)
			    {
			        AddAnime(_pageUrl.Text);
			        _pageUrl.Text = "";
			    }
			    else
			        MessageBox.Show(@"Вставьте ссылку");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddAnime(string url)
		{
			ThreadAbort();
			bool flag = Parse(url);
			if (flag)
			{
				SaveListAnime();
			}
			else
			{
				MessageBox.Show(@"Это аниме уже есть в списке!", @"Внимание");
			}
			_timer1.Enabled = true;
		}

		private void checkTray_CheckedChanged(object sender, EventArgs e)
		{
			User.Default.Tray = _checkTray.Checked;
			_lSettingsStatus.Text = @"Приложение будет запускаться " + (_checkTray.Checked ? "свернутым" : "в нормальном окне");
		}

		private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ShowForm();
			_tabControl1.SelectedIndex = 1;
		}

		private void OutVk()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
			string[] files = Directory.GetFiles(folderPath);
			string[] array = files;
			foreach (string path in array)
			{
			    try
			    {
			        File.Delete(path);
			    }
			    catch (Exception ex)
			    {
			        MessageBox.Show(ex.Message);
			    }
			}
		}

		private void outVkcheck_CheckedChanged(object sender, EventArgs e)
		{
			User.Default.OutVk = _outVkcheck.Checked;
			_lSettingsStatus.Text = @"Приложение " + (_outVkcheck.Checked ? "" : "не ") + @"будет выходить с вашего аккаунта";
		}

		private void сменитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClosingApp();
			OutVk();
			Process.Start("WNSWofA.exe");
			Close();
		}

		private void PlaySound(string filename)
		{
			string text = UserConfigPath + "ringtons\\" + filename;
			bool flag = !File.Exists(text);
			if (!flag)
			{
			    SoundPlayer soundPlayer = new SoundPlayer {SoundLocation = text};
			    soundPlayer.Load();
				soundPlayer.Play();
			}
		}

		private void LoadSound()
		{
			string text = UserConfigPath + "ringtons\\";
			bool flag = File.Exists(text + User.Default.SoundPush);
		    if (flag)
		    {
		        string[] files = Directory.GetFiles(text, "*.wav");
		        string[] array = files;
		        foreach (string path in array)
		        {
		            string fileName = Path.GetFileName(path);
		            bool flag2 = fileName != null && _cbSound.Items.IndexOf(fileName) < 0;
		            if (flag2)
		                _cbSound.Items.Add(fileName);
		        }
		    }
		    else
		        DownloadSound();
		}

		private void DownloadSound(string filename = "tuturuu.wav")
		{
			string text = UserConfigPath + "ringtons";
			bool flag = !Directory.Exists(text);
			if (flag)
			{
				ShowStatus("Создание папки...");
				Directory.CreateDirectory(text);
			}
			ShowStatus("Загрузка мелодии...");
			WebClient webClient = new WebClient();
			webClient.DownloadFileAsync(new Uri("http://aldiamond.16mb.com/WNSWofA/ringtons/" + filename), text + "\\" + filename);
			webClient.DownloadFileCompleted += Complete;
		}

		private void ShowStatus(string text)
		{
			bool flag = !_notifyIcon1.Visible;
			if (flag)
			{
				_notifyIcon1.Visible = true;
			}
			_notifyIcon1.BalloonTipText = text;
			_notifyIcon1.ShowBalloonTip(1000);
		}
		private void Complete(object sender, EventArgs e)
		{
		    ShowStatus("Загруженно");
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			User.Default.SoundPush = _cbSound.Text;
			_lSettingsStatus.Text = @"Уведомление устанновленно";
		}

		private void копироватьСсылкуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = _listAnime.Items.Count > 0;
			if (flag)
			{
				int selectedIndex = _listAnime.SelectedIndex;
				Clipboard.SetText(_pagesAnime[selectedIndex].PageUrl);
				MessageBox.Show(@"Скопированно");
			}
		}

		private void toolpageAnime_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				bool flag = e.KeyChar == '\r';
				if (flag)
				{
					int count = _listAnime.Items.Count;
					AddAnime(_toolpageAnime.Text);
					bool flag2 = _listAnime.Items.Count > count;
					if (flag2)
					{
						MessageBox.Show(@"Добавленна", @"Страница");
						_toolpageAnime.Text = "";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void checkMute_CheckedChanged(object sender, EventArgs e)
		{
			User.Default.Mute = _checkMute.Checked;
			_lSettingsStatus.Text = @"Звук" + (_checkMute.Checked ? " выключен" : " включен");
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			try
			{
				User.Default.SoundPush = _cbSound.Text;
				User.Default.Mute = _checkMute.Checked;
				User.Default.Tray = _checkTray.Checked;
				User.Default.OutVk = _outVkcheck.Checked;
				SaveSettings();
				_lSettingsStatus.Text = @"Все настройки сохранены";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			PlaySound(_cbSound.Text);
		}

		private string Get(string url)
		{
			WebRequest webRequest = WebRequest.Create(url);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
		    if (responseStream != null)
		    {
		        StreamReader streamReader = new StreamReader(responseStream);
		        string result = streamReader.ReadToEnd();
		        streamReader.Close();
		        return result;
		    }
		    return null;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			string input = Get("http://aldiamond.16mb.com/WNSWofA/ringtons/");
			Regex regex = new Regex("<a href=\\\"(\\w+\\.wav)\\\">");
			foreach (Match match in regex.Matches(input))
			{
				_listRingtons.Items.Add(match.Groups[1]);
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			foreach (object current in _listRingtons.SelectedItems)
			{
				DownloadSound(current.ToString());
			}
			LoadSound();
		}
    }
}
