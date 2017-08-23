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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьВБраузереToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьСсылкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалиьИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВБраузереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolpageAnime = new System.Windows.Forms.ToolStripTextBox();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pageUrl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listAnime = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.posterBox = new System.Windows.Forms.PictureBox();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPlayUrl = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listRingtons = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outVkcheck = new System.Windows.Forms.CheckBox();
            this.checkMute = new System.Windows.Forms.CheckBox();
            this.checkTray = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSound = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lSettingsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВБраузереToolStripMenuItem1,
            this.копироватьСсылкуToolStripMenuItem,
            this.удалиьИзСпискаToolStripMenuItem});
            this.contextMenuStrip1.Name = "_contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            // 
            // открытьВБраузереToolStripMenuItem1
            // 
            this.открытьВБраузереToolStripMenuItem1.Name = "открытьВБраузереToolStripMenuItem1";
            this.открытьВБраузереToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.открытьВБраузереToolStripMenuItem1.Text = "Открыть в браузере";
            this.открытьВБраузереToolStripMenuItem1.Click += new System.EventHandler(this.открытьВБраузереToolStripMenuItem_Click);
            // 
            // копироватьСсылкуToolStripMenuItem
            // 
            this.копироватьСсылкуToolStripMenuItem.Name = "копироватьСсылкуToolStripMenuItem";
            this.копироватьСсылкуToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.копироватьСсылкуToolStripMenuItem.Text = "Копировать ссылку";
            this.копироватьСсылкуToolStripMenuItem.Click += new System.EventHandler(this.копироватьСсылкуToolStripMenuItem_Click);
            // 
            // удалиьИзСпискаToolStripMenuItem
            // 
            this.удалиьИзСпискаToolStripMenuItem.Name = "удалиьИзСпискаToolStripMenuItem";
            this.удалиьИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.удалиьИзСпискаToolStripMenuItem.Text = "Удалиь из списка";
            this.удалиьИзСпискаToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзСпискаToolStripMenuItem_Click);
            // 
            // удалитьИзСпискаToolStripMenuItem
            // 
            this.удалитьИзСпискаToolStripMenuItem.Name = "удалитьИзСпискаToolStripMenuItem";
            this.удалитьИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.удалитьИзСпискаToolStripMenuItem.Text = "Удалить из списка";
            // 
            // открытьВБраузереToolStripMenuItem
            // 
            this.открытьВБраузереToolStripMenuItem.Name = "открытьВБраузереToolStripMenuItem";
            this.открытьВБраузереToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.открытьВБраузереToolStripMenuItem.Text = "Открыть в браузере";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WNSWofA";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.списокToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.закрытьToolStripMenuItem1,
            this.сменитьАккаунтToolStripMenuItem});
            this.contextMenuStrip2.Name = "_contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(168, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolpageAnime});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            // 
            // toolpageAnime
            // 
            this.toolpageAnime.Name = "toolpageAnime";
            this.toolpageAnime.Size = new System.Drawing.Size(100, 23);
            this.toolpageAnime.ToolTipText = "Ссылку на страницу с аниме";
            this.toolpageAnime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolpageAnime_KeyPress);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.списокToolStripMenuItem.Text = "Список";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // сменитьАккаунтToolStripMenuItem
            // 
            this.сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            this.сменитьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            this.сменитьАккаунтToolStripMenuItem.Click += new System.EventHandler(this.сменитьАккаунтToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 562);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pageUrl);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(633, 530);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // pageUrl
            // 
            this.pageUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageUrl.Location = new System.Drawing.Point(113, 3);
            this.pageUrl.Name = "pageUrl";
            this.pageUrl.Size = new System.Drawing.Size(423, 20);
            this.pageUrl.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(542, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ссылка на аниме:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listAnime);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.posterBox);
            this.splitContainer2.Panel2.Controls.Add(this.descriptionText);
            this.splitContainer2.Size = new System.Drawing.Size(633, 501);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 0;
            // 
            // listAnime
            // 
            this.listAnime.AllowDrop = true;
            this.listAnime.ContextMenuStrip = this.contextMenuStrip1;
            this.listAnime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAnime.FormattingEnabled = true;
            this.listAnime.Location = new System.Drawing.Point(0, 13);
            this.listAnime.Name = "listAnime";
            this.listAnime.Size = new System.Drawing.Size(211, 488);
            this.listAnime.TabIndex = 0;
            this.listAnime.Click += new System.EventHandler(this.listAnime_Click);
            this.listAnime.DragDrop += new System.Windows.Forms.DragEventHandler(this.listAnime_DragDrop);
            this.listAnime.DragEnter += new System.Windows.Forms.DragEventHandler(this.listAnime_DragEnter);
            this.listAnime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listAnime_KeyUp);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавленные аниме";
            // 
            // posterBox
            // 
            this.posterBox.BackColor = System.Drawing.Color.White;
            this.posterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.posterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posterBox.Image = global::Properties.Resources.posterBox2;
            this.posterBox.Location = new System.Drawing.Point(0, 0);
            this.posterBox.Name = "posterBox";
            this.posterBox.Size = new System.Drawing.Size(418, 266);
            this.posterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.posterBox.TabIndex = 0;
            this.posterBox.TabStop = false;
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionText.Location = new System.Drawing.Point(0, 266);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.Size = new System.Drawing.Size(418, 235);
            this.descriptionText.TabIndex = 1;
            this.descriptionText.Text = "Описание";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnPlayUrl);
            this.tabPage2.Controls.Add(this.btnDownload);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listRingtons);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // btnPlayUrl
            // 
            this.btnPlayUrl.AutoSize = true;
            this.btnPlayUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayUrl.Image = global::WNSWofA.Properties.Resources.player_volume_4201;
            this.btnPlayUrl.Location = new System.Drawing.Point(131, 257);
            this.btnPlayUrl.Name = "btnPlayUrl";
            this.btnPlayUrl.Size = new System.Drawing.Size(38, 38);
            this.btnPlayUrl.TabIndex = 15;
            this.btnPlayUrl.UseVisualStyleBackColor = true;
            this.btnPlayUrl.Click += new System.EventHandler(this.btnPlayUrl_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(11, 257);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(114, 38);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Скачать";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Рингтоны";
            // 
            // listRingtons
            // 
            this.listRingtons.FormattingEnabled = true;
            this.listRingtons.Location = new System.Drawing.Point(11, 130);
            this.listRingtons.Name = "listRingtons";
            this.listRingtons.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRingtons.Size = new System.Drawing.Size(158, 121);
            this.listRingtons.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.btnSaveSettings);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 23);
            this.panel4.TabIndex = 11;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(633, 23);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.outVkcheck);
            this.panel1.Controls.Add(this.checkMute);
            this.panel1.Controls.Add(this.checkTray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 51);
            this.panel1.TabIndex = 10;
            // 
            // outVkcheck
            // 
            this.outVkcheck.AutoSize = true;
            this.outVkcheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.outVkcheck.Location = new System.Drawing.Point(0, 34);
            this.outVkcheck.Name = "outVkcheck";
            this.outVkcheck.Size = new System.Drawing.Size(633, 17);
            this.outVkcheck.TabIndex = 4;
            this.outVkcheck.Text = "Выходить из вк";
            this.outVkcheck.UseVisualStyleBackColor = true;
            this.outVkcheck.CheckedChanged += new System.EventHandler(this.outVkcheck_CheckedChanged);
            // 
            // checkMute
            // 
            this.checkMute.AutoSize = true;
            this.checkMute.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkMute.Location = new System.Drawing.Point(0, 17);
            this.checkMute.Name = "checkMute";
            this.checkMute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkMute.Size = new System.Drawing.Size(633, 17);
            this.checkMute.TabIndex = 7;
            this.checkMute.Text = "Выключить звук";
            this.checkMute.UseVisualStyleBackColor = true;
            this.checkMute.CheckedChanged += new System.EventHandler(this.checkMute_CheckedChanged);
            // 
            // checkTray
            // 
            this.checkTray.AutoSize = true;
            this.checkTray.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkTray.Location = new System.Drawing.Point(0, 0);
            this.checkTray.Name = "checkTray";
            this.checkTray.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkTray.Size = new System.Drawing.Size(633, 17);
            this.checkTray.TabIndex = 3;
            this.checkTray.Text = "Запускать приложение свернутым";
            this.checkTray.UseVisualStyleBackColor = true;
            this.checkTray.CheckedChanged += new System.EventHandler(this.checkTray_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSound);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 24);
            this.panel3.TabIndex = 9;
            // 
            // cbSound
            // 
            this.cbSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSound.FormattingEnabled = true;
            this.cbSound.Location = new System.Drawing.Point(101, 0);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(494, 21);
            this.cbSound.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Image = global::WNSWofA.Properties.Resources.player_volume_4201;
            this.btnPlay.Location = new System.Drawing.Point(595, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 24);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Звук уведомления";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.lSettingsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(0, 17);
            // 
            // lSettingsStatus
            // 
            this.lSettingsStatus.Name = "lSettingsStatus";
            this.lSettingsStatus.Size = new System.Drawing.Size(96, 17);
            this.lSettingsStatus.Text = "Статус настроек";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 0);
            this.panel2.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "listAnime";
            this.openFileDialog1.Filter = "wnsofa|*.wnsofa";
            this.openFileDialog1.Title = "Выберети загружаемый список";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "listAnime";
            this.saveFileDialog1.Filter = "wnsofa|*.wnsofa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 562);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Когда новая серия WofA?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private ContextMenuStrip contextMenuStrip1;

        private ToolStripMenuItem удалитьИзСпискаToolStripMenuItem;

        private ToolStripMenuItem открытьВБраузереToolStripMenuItem;

        private Timer timer1;

        private NotifyIcon notifyIcon1;

        private ContextMenuStrip contextMenuStrip2;

        private ToolStripMenuItem закрытьToolStripMenuItem;

        private ToolStripMenuItem настройкиToolStripMenuItem;

        private ToolStripMenuItem открытьВБраузереToolStripMenuItem1;

        private ToolStripMenuItem удалиьИзСпискаToolStripMenuItem;

        private ToolStripMenuItem настройкиToolStripMenuItem1;

        private ToolStripMenuItem закрытьToolStripMenuItem1;

        private TabControl tabControl1;

        private TabPage tabPage1;

        private SplitContainer splitContainer1;

        private SplitContainer splitContainer2;

        private TabPage tabPage2;

        private Button btnAdd;

        private TextBox pageUrl;

        private Label label1;

        private Label label2;

        private ListBox listAnime;

        private RichTextBox descriptionText;

        private PictureBox posterBox;

        private CheckBox checkTray;

        private CheckBox outVkcheck;

        private ToolStripMenuItem сменитьАккаунтToolStripMenuItem;

        private ComboBox cbSound;

        private Label label3;

        private Panel panel2;

        private ToolStripMenuItem копироватьСсылкуToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripTextBox toolpageAnime;

        private CheckBox checkMute;

        private Button btnSaveSettings;

        private StatusStrip statusStrip1;

        private ToolStripStatusLabel toolStripProgressBar1;

        private ToolStripStatusLabel lSettingsStatus;

        private Button btnPlay;

        private Panel panel4;

        private Panel panel1;

        private Panel panel3;

        private Button btnDownload;

        private Label label4;

        private ListBox listRingtons;
        private Button btnPlayUrl;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem списокToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}