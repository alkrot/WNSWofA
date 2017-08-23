using System;
using System.Windows.Forms;

namespace WNSWofA
{
	[Serializable]
	public class PageAnime
	{
        private string title;

        private bool ongoing = true;

        private string url_image;

        private int count;

        private int count_series;

        private string description;

        private int group_id;

        private int page_id;

        private string page_url;

        private bool refresh = false;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public bool Ongoing
        {
            get
            {
                return ongoing;
            }
            set
            {
                ongoing = value;
            }
        }

        public string Url_image
        {
            get
            {
                return url_image;
            }
            set
            {
                url_image = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public int Count_series
        {
            get
            {
                return count_series;
            }
            set
            {
                count_series = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int Group_id
        {
            get
            {
                return group_id;
            }
            set
            {
                group_id = value;
            }
        }

        public int Page_id
        {
            get
            {
                return page_id;
            }
            set
            {
                page_id = value;
            }
        }

        public bool Refresh
        {
            get
            {
                return refresh;
            }
            set
            {
                refresh = value;
            }
        }

        public string Page_url
        {
            get
            {
                return page_url;
            }
        }

        public PageAnime(string title, bool ongoing, string url_image, int count, int count_series, string description, int group_id, int page_id)
        {
            Title = title;
            Ongoing = ongoing;
            Url_image = url_image;
            Count = count;
            Count_series = count_series;
            Description = description;
            Group_id = group_id;
            Page_id = page_id;
            page_url = string.Concat(new object[] { "https://vk.com/page", Group_id, "_", Page_id });
        }

        public void Show(RichTextBox rtb, PictureBox pb)
        {
            string value = string.Concat(new object[]
            {
                "Добавленно серий: ",
                Count,
                "\r\n________________________\r\n",
                Ongoing ? "Онгоинг" : "Закончен",
                "\r\n________________________\r\n"
            });
            rtb.Text = Description.Insert(0, value);
            pb.ImageLocation = Url_image;
        }

        public override string ToString()
        {
            return Refresh ? ("*" + Title) : Title;
        }
    }
}
