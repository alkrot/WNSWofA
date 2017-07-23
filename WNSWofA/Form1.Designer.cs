using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WNSWofA.Properties;

namespace WNSWofA
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components;


        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && components != null;
            if (flag)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            _contextMenuStrip1 = new ContextMenuStrip(components);
            _открытьВБраузереToolStripMenuItem1 = new ToolStripMenuItem();
            _копироватьСсылкуToolStripMenuItem = new ToolStripMenuItem();
            _удалиьИзСпискаToolStripMenuItem = new ToolStripMenuItem();
            _удалитьИзСпискаToolStripMenuItem = new ToolStripMenuItem();
            _открытьВБраузереToolStripMenuItem = new ToolStripMenuItem();
            _timer1 = new Timer(components);
            _notifyIcon1 = new NotifyIcon(components);
            _contextMenuStrip2 = new ContextMenuStrip(components);
            _toolStripMenuItem1 = new ToolStripMenuItem();
            _toolpageAnime = new ToolStripTextBox();
            _настройкиToolStripMenuItem1 = new ToolStripMenuItem();
            _закрытьToolStripMenuItem1 = new ToolStripMenuItem();
            _сменитьАккаунтToolStripMenuItem = new ToolStripMenuItem();
            _закрытьToolStripMenuItem = new ToolStripMenuItem();
            _настройкиToolStripMenuItem = new ToolStripMenuItem();
            _tabControl1 = new TabControl();
            _tabPage1 = new TabPage();
            _splitContainer1 = new SplitContainer();
            _pageUrl = new TextBox();
            _btnAdd = new Button();
            _label1 = new Label();
            _splitContainer2 = new SplitContainer();
            _listAnime = new ListBox();
            _label2 = new Label();
            _posterBox = new PictureBox();
            _descriptionText = new RichTextBox();
            _tabPage2 = new TabPage();
            _btnDownload = new Button();
            _label4 = new Label();
            _listRingtons = new ListBox();
            _panel4 = new Panel();
            _btnSaveSettings = new Button();
            _panel1 = new Panel();
            _outVkcheck = new CheckBox();
            _checkMute = new CheckBox();
            _checkTray = new CheckBox();
            _panel3 = new Panel();
            _cbSound = new ComboBox();
            _button1 = new Button();
            _label3 = new Label();
            _statusStrip1 = new StatusStrip();
            _toolStripProgressBar1 = new ToolStripStatusLabel();
            _lSettingsStatus = new ToolStripStatusLabel();
            _panel2 = new Panel();
            _contextMenuStrip1.SuspendLayout();
            _contextMenuStrip2.SuspendLayout();
            _tabControl1.SuspendLayout();
            _tabPage1.SuspendLayout();
            ((ISupportInitialize)(_splitContainer1)).BeginInit();
            _splitContainer1.Panel1.SuspendLayout();
            _splitContainer1.Panel2.SuspendLayout();
            _splitContainer1.SuspendLayout();
            ((ISupportInitialize)(_splitContainer2)).BeginInit();
            _splitContainer2.Panel1.SuspendLayout();
            _splitContainer2.Panel2.SuspendLayout();
            _splitContainer2.SuspendLayout();
            ((ISupportInitialize)(_posterBox)).BeginInit();
            _tabPage2.SuspendLayout();
            _panel4.SuspendLayout();
            _panel1.SuspendLayout();
            _panel3.SuspendLayout();
            _statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _contextMenuStrip1
            // 
            _contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
                _открытьВБраузереToolStripMenuItem1,
                _копироватьСсылкуToolStripMenuItem,
                _удалиьИзСпискаToolStripMenuItem});
            _contextMenuStrip1.Name = "_contextMenuStrip1";
            _contextMenuStrip1.Size = new Size(184, 70);
            // 
            // _открытьВБраузереToolStripMenuItem1
            // 
            _открытьВБраузереToolStripMenuItem1.Name = "_открытьВБраузереToolStripMenuItem1";
            _открытьВБраузереToolStripMenuItem1.Size = new Size(183, 22);
            _открытьВБраузереToolStripMenuItem1.Text = @"Открыть в браузере";
            _открытьВБраузереToolStripMenuItem1.Click += открытьВБраузереToolStripMenuItem_Click;
            // 
            // _копироватьСсылкуToolStripMenuItem
            // 
            _копироватьСсылкуToolStripMenuItem.Name = "_копироватьСсылкуToolStripMenuItem";
            _копироватьСсылкуToolStripMenuItem.Size = new Size(183, 22);
            _копироватьСсылкуToolStripMenuItem.Text = @"Копировать ссылку";
            _копироватьСсылкуToolStripMenuItem.Click += копироватьСсылкуToolStripMenuItem_Click;
            // 
            // _удалиьИзСпискаToolStripMenuItem
            // 
            _удалиьИзСпискаToolStripMenuItem.Name = "_удалиьИзСпискаToolStripMenuItem";
            _удалиьИзСпискаToolStripMenuItem.Size = new Size(183, 22);
            _удалиьИзСпискаToolStripMenuItem.Text = @"Удалиь из списка";
            _удалиьИзСпискаToolStripMenuItem.Click += удалитьИзСпискаToolStripMenuItem_Click;
            // 
            // _удалитьИзСпискаToolStripMenuItem
            // 
            _удалитьИзСпискаToolStripMenuItem.Name = "_удалитьИзСпискаToolStripMenuItem";
            _удалитьИзСпискаToolStripMenuItem.Size = new Size(174, 22);
            _удалитьИзСпискаToolStripMenuItem.Text = @"Удалить из списка";
            // 
            // _открытьВБраузереToolStripMenuItem
            // 
            _открытьВБраузереToolStripMenuItem.Name = "_открытьВБраузереToolStripMenuItem";
            _открытьВБраузереToolStripMenuItem.Size = new Size(183, 22);
            _открытьВБраузереToolStripMenuItem.Text = @"Открыть в браузере";
            // 
            // _timer1
            // 
            _timer1.Interval = 3000;
            _timer1.Tick += timer1_Tick;
            // 
            // _notifyIcon1
            // 
            _notifyIcon1.ContextMenuStrip = _contextMenuStrip2;
            _notifyIcon1.Icon = ((Icon)(resources.GetObject("_notifyIcon1.Icon")));
            _notifyIcon1.Text = @"WNSWofA";
            _notifyIcon1.BalloonTipClicked += notifyIcon1_BalloonTipClicked;
            _notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            _notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // _contextMenuStrip2
            // 
            _contextMenuStrip2.Items.AddRange(new ToolStripItem[] {
                _toolStripMenuItem1,
                _настройкиToolStripMenuItem1,
                _закрытьToolStripMenuItem1,
                _сменитьАккаунтToolStripMenuItem});
            _contextMenuStrip2.Name = "_contextMenuStrip2";
            _contextMenuStrip2.Size = new Size(168, 92);
            // 
            // _toolStripMenuItem1
            // 
            _toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] {
                _toolpageAnime});
            _toolStripMenuItem1.Name = "_toolStripMenuItem1";
            _toolStripMenuItem1.Size = new Size(167, 22);
            _toolStripMenuItem1.Text = @"Добавить";
            // 
            // _toolpageAnime
            // 
            _toolpageAnime.Name = "_toolpageAnime";
            _toolpageAnime.Size = new Size(100, 23);
            _toolpageAnime.ToolTipText = @"Ссылку на страницу с аниме";
            _toolpageAnime.KeyPress += toolpageAnime_KeyPress;
            // 
            // _настройкиToolStripMenuItem1
            // 
            _настройкиToolStripMenuItem1.Name = "_настройкиToolStripMenuItem1";
            _настройкиToolStripMenuItem1.Size = new Size(167, 22);
            _настройкиToolStripMenuItem1.Text = @"Настройки";
            _настройкиToolStripMenuItem1.Click += настройкиToolStripMenuItem1_Click;
            // 
            // _закрытьToolStripMenuItem1
            // 
            _закрытьToolStripMenuItem1.Name = "_закрытьToolStripMenuItem1";
            _закрытьToolStripMenuItem1.Size = new Size(167, 22);
            _закрытьToolStripMenuItem1.Text = @"Закрыть";
            _закрытьToolStripMenuItem1.Click += закрытьToolStripMenuItem1_Click;
            // 
            // _сменитьАккаунтToolStripMenuItem
            // 
            _сменитьАккаунтToolStripMenuItem.Name = "_сменитьАккаунтToolStripMenuItem";
            _сменитьАккаунтToolStripMenuItem.Size = new Size(167, 22);
            _сменитьАккаунтToolStripMenuItem.Text = @"Сменить аккаунт";
            _сменитьАккаунтToolStripMenuItem.Click += сменитьАккаунтToolStripMenuItem_Click;
            // 
            // _закрытьToolStripMenuItem
            // 
            _закрытьToolStripMenuItem.Name = "_закрытьToolStripMenuItem";
            _закрытьToolStripMenuItem.Size = new Size(120, 22);
            _закрытьToolStripMenuItem.Text = @"Закрыть";
            // 
            // _настройкиToolStripMenuItem
            // 
            _настройкиToolStripMenuItem.Name = "_настройкиToolStripMenuItem";
            _настройкиToolStripMenuItem.Size = new Size(134, 22);
            _настройкиToolStripMenuItem.Text = @"Настройки";
            // 
            // _tabControl1
            // 
            _tabControl1.Controls.Add(_tabPage1);
            _tabControl1.Controls.Add(_tabPage2);
            _tabControl1.Dock = DockStyle.Fill;
            _tabControl1.ImeMode = ImeMode.NoControl;
            _tabControl1.Location = new Point(0, 0);
            _tabControl1.Name = "_tabControl1";
            _tabControl1.SelectedIndex = 0;
            _tabControl1.Size = new Size(647, 562);
            _tabControl1.TabIndex = 2;
            // 
            // _tabPage1
            // 
            _tabPage1.BackColor = SystemColors.Control;
            _tabPage1.Controls.Add(_splitContainer1);
            _tabPage1.Location = new Point(4, 22);
            _tabPage1.Name = "_tabPage1";
            _tabPage1.Padding = new Padding(3);
            _tabPage1.Size = new Size(639, 536);
            _tabPage1.TabIndex = 0;
            _tabPage1.Text = @"Главная";
            // 
            // _splitContainer1
            // 
            _splitContainer1.Dock = DockStyle.Fill;
            _splitContainer1.FixedPanel = FixedPanel.Panel1;
            _splitContainer1.IsSplitterFixed = true;
            _splitContainer1.Location = new Point(3, 3);
            _splitContainer1.Name = "_splitContainer1";
            _splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // _splitContainer1.Panel1
            // 
            _splitContainer1.Panel1.Controls.Add(_pageUrl);
            _splitContainer1.Panel1.Controls.Add(_btnAdd);
            _splitContainer1.Panel1.Controls.Add(_label1);
            // 
            // _splitContainer1.Panel2
            // 
            _splitContainer1.Panel2.Controls.Add(_splitContainer2);
            _splitContainer1.Size = new Size(633, 530);
            _splitContainer1.SplitterDistance = 25;
            _splitContainer1.TabIndex = 0;
            // 
            // _pageUrl
            // 
            _pageUrl.BorderStyle = BorderStyle.FixedSingle;
            _pageUrl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _pageUrl.Location = new Point(113, 3);
            _pageUrl.Name = "_pageUrl";
            _pageUrl.Size = new Size(423, 20);
            _pageUrl.TabIndex = 1;
            // 
            // _btnAdd
            // 
            _btnAdd.FlatStyle = FlatStyle.Flat;
            _btnAdd.Location = new Point(542, 0);
            _btnAdd.Name = "_btnAdd";
            _btnAdd.Size = new Size(75, 25);
            _btnAdd.TabIndex = 2;
            _btnAdd.Text = @"Добавить";
            _btnAdd.UseVisualStyleBackColor = true;
            _btnAdd.Click += button1_Click;
            // 
            // _label1
            // 
            _label1.BackColor = Color.Gainsboro;
            _label1.BorderStyle = BorderStyle.FixedSingle;
            _label1.Dock = DockStyle.Left;
            _label1.Location = new Point(0, 0);
            _label1.Name = "_label1";
            _label1.Size = new Size(107, 25);
            _label1.TabIndex = 0;
            _label1.Text = @"Ссылка на аниме:";
            _label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _splitContainer2
            // 
            _splitContainer2.Dock = DockStyle.Fill;
            _splitContainer2.Location = new Point(0, 0);
            _splitContainer2.Name = "_splitContainer2";
            // 
            // _splitContainer2.Panel1
            // 
            _splitContainer2.Panel1.Controls.Add(_listAnime);
            _splitContainer2.Panel1.Controls.Add(_label2);
            // 
            // _splitContainer2.Panel2
            // 
            _splitContainer2.Panel2.Controls.Add(_posterBox);
            _splitContainer2.Panel2.Controls.Add(_descriptionText);
            _splitContainer2.Size = new Size(633, 501);
            _splitContainer2.SplitterDistance = 211;
            _splitContainer2.TabIndex = 0;
            // 
            // _listAnime
            // 
            _listAnime.ContextMenuStrip = _contextMenuStrip1;
            _listAnime.Dock = DockStyle.Fill;
            _listAnime.FormattingEnabled = true;
            _listAnime.Location = new Point(0, 13);
            _listAnime.Name = "_listAnime";
            _listAnime.Size = new Size(211, 488);
            _listAnime.TabIndex = 0;
            _listAnime.SelectedIndexChanged += listAnime_Click;
            _listAnime.KeyUp += listAnime_KeyUp;
            // 
            // _label2
            // 
            _label2.Dock = DockStyle.Top;
            _label2.Location = new Point(0, 0);
            _label2.Name = "_label2";
            _label2.Size = new Size(211, 13);
            _label2.TabIndex = 1;
            _label2.Text = @"Добавленные аниме";
            // 
            // _posterBox
            // 
            _posterBox.BackColor = Color.White;
            _posterBox.BorderStyle = BorderStyle.Fixed3D;
            _posterBox.Dock = DockStyle.Fill;
            _posterBox.Location = new Point(0, 0);
            _posterBox.Name = "_posterBox";
            _posterBox.Size = new Size(418, 266);
            _posterBox.SizeMode = PictureBoxSizeMode.CenterImage;
            _posterBox.TabIndex = 0;
            _posterBox.TabStop = false;
            // 
            // _descriptionText
            // 
            _descriptionText.BackColor = SystemColors.Control;
            _descriptionText.Dock = DockStyle.Bottom;
            _descriptionText.Location = new Point(0, 266);
            _descriptionText.Name = "_descriptionText";
            _descriptionText.ReadOnly = true;
            _descriptionText.Size = new Size(418, 235);
            _descriptionText.TabIndex = 1;
            _descriptionText.Text = @"Описание";
            // 
            // _tabPage2
            // 
            _tabPage2.BackColor = SystemColors.Control;
            _tabPage2.Controls.Add(_btnDownload);
            _tabPage2.Controls.Add(_label4);
            _tabPage2.Controls.Add(_listRingtons);
            _tabPage2.Controls.Add(_panel4);
            _tabPage2.Controls.Add(_panel1);
            _tabPage2.Controls.Add(_panel3);
            _tabPage2.Controls.Add(_statusStrip1);
            _tabPage2.Controls.Add(_panel2);
            _tabPage2.Location = new Point(4, 22);
            _tabPage2.Name = "_tabPage2";
            _tabPage2.Padding = new Padding(3);
            _tabPage2.Size = new Size(639, 536);
            _tabPage2.TabIndex = 1;
            _tabPage2.Text = @"Настройки";
            // 
            // _btnDownload
            // 
            _btnDownload.AutoSize = true;
            _btnDownload.FlatStyle = FlatStyle.Flat;
            _btnDownload.Location = new Point(11, 257);
            _btnDownload.Name = "_btnDownload";
            _btnDownload.Size = new Size(158, 25);
            _btnDownload.TabIndex = 14;
            _btnDownload.Text = @"Скачать";
            _btnDownload.UseVisualStyleBackColor = true;
            _btnDownload.Click += btnDownload_Click;
            // 
            // _label4
            // 
            _label4.AutoSize = true;
            _label4.Location = new Point(8, 114);
            _label4.Name = "_label4";
            _label4.Size = new Size(56, 13);
            _label4.TabIndex = 13;
            _label4.Text = @"Рингтоны";
            // 
            // _listRingtons
            // 
            _listRingtons.FormattingEnabled = true;
            _listRingtons.Location = new Point(11, 130);
            _listRingtons.Name = "_listRingtons";
            _listRingtons.SelectionMode = SelectionMode.MultiExtended;
            _listRingtons.Size = new Size(158, 121);
            _listRingtons.TabIndex = 12;
            // 
            // _panel4
            // 
            _panel4.AutoSize = true;
            _panel4.Controls.Add(_btnSaveSettings);
            _panel4.Dock = DockStyle.Top;
            _panel4.Location = new Point(3, 78);
            _panel4.Name = "_panel4";
            _panel4.Size = new Size(633, 23);
            _panel4.TabIndex = 11;
            // 
            // _btnSaveSettings
            // 
            _btnSaveSettings.Cursor = Cursors.Hand;
            _btnSaveSettings.Dock = DockStyle.Top;
            _btnSaveSettings.FlatStyle = FlatStyle.Flat;
            _btnSaveSettings.Location = new Point(0, 0);
            _btnSaveSettings.Name = "_btnSaveSettings";
            _btnSaveSettings.Size = new Size(633, 23);
            _btnSaveSettings.TabIndex = 7;
            _btnSaveSettings.Text = @"Сохранить";
            _btnSaveSettings.UseVisualStyleBackColor = true;
            _btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // _panel1
            // 
            _panel1.AutoSize = true;
            _panel1.Controls.Add(_outVkcheck);
            _panel1.Controls.Add(_checkMute);
            _panel1.Controls.Add(_checkTray);
            _panel1.Dock = DockStyle.Top;
            _panel1.Location = new Point(3, 27);
            _panel1.Name = "_panel1";
            _panel1.Size = new Size(633, 51);
            _panel1.TabIndex = 10;
            // 
            // _outVkcheck
            // 
            _outVkcheck.AutoSize = true;
            _outVkcheck.Dock = DockStyle.Top;
            _outVkcheck.Location = new Point(0, 34);
            _outVkcheck.Name = "_outVkcheck";
            _outVkcheck.Size = new Size(633, 17);
            _outVkcheck.TabIndex = 4;
            _outVkcheck.Text = @"Выходить из вк";
            _outVkcheck.UseVisualStyleBackColor = true;
            _outVkcheck.CheckedChanged += outVkcheck_CheckedChanged;
            // 
            // _checkMute
            // 
            _checkMute.AutoSize = true;
            _checkMute.Dock = DockStyle.Top;
            _checkMute.Location = new Point(0, 17);
            _checkMute.Name = "_checkMute";
            _checkMute.RightToLeft = RightToLeft.No;
            _checkMute.Size = new Size(633, 17);
            _checkMute.TabIndex = 7;
            _checkMute.Text = @"Выключить звук";
            _checkMute.UseVisualStyleBackColor = true;
            _checkMute.CheckedChanged += checkMute_CheckedChanged;
            // 
            // _checkTray
            // 
            _checkTray.AutoSize = true;
            _checkTray.Dock = DockStyle.Top;
            _checkTray.Location = new Point(0, 0);
            _checkTray.Name = "_checkTray";
            _checkTray.RightToLeft = RightToLeft.No;
            _checkTray.Size = new Size(633, 17);
            _checkTray.TabIndex = 3;
            _checkTray.Text = @"Запускать приложение свернутым";
            _checkTray.UseVisualStyleBackColor = true;
            _checkTray.CheckedChanged += checkTray_CheckedChanged;
            // 
            // _panel3
            // 
            _panel3.Controls.Add(_cbSound);
            _panel3.Controls.Add(_button1);
            _panel3.Controls.Add(_label3);
            _panel3.Dock = DockStyle.Top;
            _panel3.Location = new Point(3, 3);
            _panel3.Name = "_panel3";
            _panel3.Size = new Size(633, 24);
            _panel3.TabIndex = 9;
            // 
            // _cbSound
            // 
            _cbSound.Dock = DockStyle.Fill;
            _cbSound.FlatStyle = FlatStyle.Flat;
            _cbSound.FormattingEnabled = true;
            _cbSound.Location = new Point(101, 0);
            _cbSound.Name = "_cbSound";
            _cbSound.Size = new Size(494, 21);
            _cbSound.TabIndex = 2;
            _cbSound.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // _button1
            // 
            _button1.AutoSize = true;
            _button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _button1.Cursor = Cursors.Hand;
            _button1.Dock = DockStyle.Right;
            _button1.FlatStyle = FlatStyle.Popup;
            _button1.Image = Resources.player_volume_4201;
            _button1.Location = new Point(595, 0);
            _button1.Name = "_button1";
            _button1.Size = new Size(38, 24);
            _button1.TabIndex = 9;
            _button1.UseVisualStyleBackColor = true;
            _button1.Click += button1_Click_1;
            // 
            // _label3
            // 
            _label3.Dock = DockStyle.Left;
            _label3.Location = new Point(0, 0);
            _label3.Name = "_label3";
            _label3.Size = new Size(101, 24);
            _label3.TabIndex = 0;
            _label3.Text = @"Звук уведомления";
            // 
            // _statusStrip1
            // 
            _statusStrip1.Items.AddRange(new ToolStripItem[] {
                _toolStripProgressBar1,
                _lSettingsStatus});
            _statusStrip1.Location = new Point(3, 511);
            _statusStrip1.Name = "_statusStrip1";
            _statusStrip1.Size = new Size(633, 22);
            _statusStrip1.TabIndex = 8;
            _statusStrip1.Text = @"statusStrip1";
            // 
            // _toolStripProgressBar1
            // 
            _toolStripProgressBar1.Name = "_toolStripProgressBar1";
            _toolStripProgressBar1.Size = new Size(0, 17);
            // 
            // _lSettingsStatus
            // 
            _lSettingsStatus.Name = "_lSettingsStatus";
            _lSettingsStatus.Size = new Size(96, 17);
            _lSettingsStatus.Text = @"Статус настроек";
            // 
            // _panel2
            // 
            _panel2.AutoSize = true;
            _panel2.Dock = DockStyle.Top;
            _panel2.Location = new Point(3, 3);
            _panel2.Name = "_panel2";
            _panel2.Size = new Size(633, 0);
            _panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 562);
            ContextMenuStrip = _contextMenuStrip2;
            Controls.Add(_tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = ((Icon)(resources.GetObject("$this.Icon")));
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = @"Когда новая серия WofA?";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Shown += Form1_Shown;
            Resize += Form1_Resize;
            _contextMenuStrip1.ResumeLayout(false);
            _contextMenuStrip2.ResumeLayout(false);
            _tabControl1.ResumeLayout(false);
            _tabPage1.ResumeLayout(false);
            _splitContainer1.Panel1.ResumeLayout(false);
            _splitContainer1.Panel1.PerformLayout();
            _splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(_splitContainer1)).EndInit();
            _splitContainer1.ResumeLayout(false);
            _splitContainer2.Panel1.ResumeLayout(false);
            _splitContainer2.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(_splitContainer2)).EndInit();
            _splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)(_posterBox)).EndInit();
            _tabPage2.ResumeLayout(false);
            _tabPage2.PerformLayout();
            _panel4.ResumeLayout(false);
            _panel1.ResumeLayout(false);
            _panel1.PerformLayout();
            _panel3.ResumeLayout(false);
            _panel3.PerformLayout();
            _statusStrip1.ResumeLayout(false);
            _statusStrip1.PerformLayout();
            ResumeLayout(false);

        }

        private ContextMenuStrip _contextMenuStrip1;

        private ToolStripMenuItem _удалитьИзСпискаToolStripMenuItem;

        private ToolStripMenuItem _открытьВБраузереToolStripMenuItem;

        private Timer _timer1;

        private NotifyIcon _notifyIcon1;

        private ContextMenuStrip _contextMenuStrip2;

        private ToolStripMenuItem _закрытьToolStripMenuItem;

        private ToolStripMenuItem _настройкиToolStripMenuItem;

        private ToolStripMenuItem _открытьВБраузереToolStripMenuItem1;

        private ToolStripMenuItem _удалиьИзСпискаToolStripMenuItem;

        private ToolStripMenuItem _настройкиToolStripMenuItem1;

        private ToolStripMenuItem _закрытьToolStripMenuItem1;

        private TabControl _tabControl1;

        private TabPage _tabPage1;

        private SplitContainer _splitContainer1;

        private SplitContainer _splitContainer2;

        private TabPage _tabPage2;

        private Button _btnAdd;

        private TextBox _pageUrl;

        private Label _label1;

        private Label _label2;

        private ListBox _listAnime;

        private RichTextBox _descriptionText;

        private PictureBox _posterBox;

        private CheckBox _checkTray;

        private CheckBox _outVkcheck;

        private ToolStripMenuItem _сменитьАккаунтToolStripMenuItem;

        private ComboBox _cbSound;

        private Label _label3;

        private Panel _panel2;

        private ToolStripMenuItem _копироватьСсылкуToolStripMenuItem;

        private ToolStripMenuItem _toolStripMenuItem1;

        private ToolStripTextBox _toolpageAnime;

        private CheckBox _checkMute;

        private Button _btnSaveSettings;

        private StatusStrip _statusStrip1;

        private ToolStripStatusLabel _toolStripProgressBar1;

        private ToolStripStatusLabel _lSettingsStatus;

        private Button _button1;

        private Panel _panel4;

        private Panel _panel1;

        private Panel _panel3;

        private Button _btnDownload;

        private Label _label4;

        private ListBox _listRingtons;
    }
}