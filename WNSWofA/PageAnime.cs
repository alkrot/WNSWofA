using System;
using System.Windows.Forms;

namespace WNSWofA
{
	[Serializable]
	public class PageAnime
	{
		private string _title;

		private bool _ongoing = true;

		private string _urlImage;

		private int _count;

		private int _countSeries;

		private string _description;

		private int _groupId;

		private int _pageId;

	    private bool _refresh;

		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		public bool Ongoing
		{
			get
			{
				return _ongoing;
			}
			set
			{
				_ongoing = value;
			}
		}

		public string UrlImage
		{
			get
			{
				return _urlImage;
			}
			set
			{
				_urlImage = value;
			}
		}

		public int Count
		{
			get
			{
				return _count;
			}
			set
			{
				_count = value;
			}
		}

		public int CountSeries
		{
			get
			{
				return _countSeries;
			}
			set
			{
				_countSeries = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public int GroupId
		{
			get
			{
				return _groupId;
			}
			set
			{
				_groupId = value;
			}
		}

		public int PageId
		{
			get
			{
				return _pageId;
			}
			set
			{
				_pageId = value;
			}
		}

		public bool Refresh
		{
			get
			{
				return _refresh;
			}
			set
			{
				_refresh = value;
			}
		}

	    public string PageUrl { get; }

	    public PageAnime(string title, bool ongoing, string urlImage, int count, int countSeries, string description, int groupId, int pageId)
		{
			Title = title;
			Ongoing = ongoing;
			UrlImage = urlImage;
			Count = count;
			CountSeries = countSeries;
			Description = description;
			GroupId = groupId;
			PageId = pageId;
			PageUrl = string.Concat("https://vk.com/page", GroupId, "_", PageId);
		}

		public void Show(RichTextBox rtb, PictureBox pb)
		{
			string value = string.Concat("Добавленно серий: ", Count, "\r\n________________________\r\n", Ongoing ? "Онгоинг" : "Закончен", "\r\n________________________\r\n");
			rtb.Text = Description.Insert(0, value);
			pb.ImageLocation = UrlImage;
		}

		public override string ToString()
		{
			return Refresh ? ("*" + Title) : Title;
		}
	}
}
