using System;
using System.Windows.Forms;

namespace WNSWofA
{
    /// <summary>
    /// Класс для хранения объекта Page страницы
    /// </summary>
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

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title
        {
            get => title;
            set => title = value;
        }

        /// <summary>
        /// Огониг ли
        /// </summary>
        public bool Ongoing
        {
            get => ongoing;
            set => ongoing = value;
        }

        /// <summary>
        /// Картинка
        /// </summary>
        public string Url_image
        {
            get => url_image;
            set => url_image = value;
        }

        /// <summary>
        /// Количество серий всего должно быть
        /// </summary>
        public int Count
        {
            get => count;
            set => count = value;
        }

        /// <summary>
        /// Количество имеющихся серий
        /// </summary>
        public int Count_series
        {
            get => count_series;
            set => count_series = value;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get => description;
            set => description = value;
        }

        /// <summary>
        /// id Группы
        /// </summary>
        public int Group_id
        {
            get => group_id;
            set => group_id = value;
        }

        /// <summary>
        /// id Cтраницы
        /// </summary>
        public int Page_id
        {
            get => page_id;
            set => page_id = value;
        }

        /// <summary>
        /// Обновленна ли серия
        /// </summary>
        public bool Refresh
        {
            get => refresh;
            set => refresh = value;
        }

        /// <summary>
        /// Ссылка на страницу
        /// </summary>
        public string Page_url => page_url;

        /// <summary>
        /// Инциилизация
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="ongoing">Онгинг ли</param>
        /// <param name="url_image">Картинка</param>
        /// <param name="count">Количество всего</param>
        /// <param name="count_series">Количество имеющихся</param>
        /// <param name="description">Описание</param>
        /// <param name="group_id">Id Группы</param>
        /// <param name="page_id">id Wiki страницы</param>
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

        /// <summary>
        /// Показать информцию
        /// </summary>
        /// <param name="rtb">Текстовое поле</param>
        /// <param name="pb">Элемент картинка</param>
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
