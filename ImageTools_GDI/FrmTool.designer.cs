
namespace ImageTools_GDI
{
    partial class FrmTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTool));
            this.btnScrn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnA4LocationBottom = new MetroFramework.Controls.MetroButton();
            this.btnA4LocationCenter = new MetroFramework.Controls.MetroButton();
            this.btnA4LocationTop = new MetroFramework.Controls.MetroButton();
            this.picScrn = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panelScrnBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Panel();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnCutPic = new System.Windows.Forms.Button();
            this.btnHorFlip = new System.Windows.Forms.Button();
            this.btnVerFlip = new System.Windows.Forms.Button();
            this.btnRightRotate90 = new System.Windows.Forms.Button();
            this.btnLeftRotate90 = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cbA4SizeFollow = new MetroFramework.Controls.MetroCheckBox();
            this.cbA4 = new MetroFramework.Controls.MetroCheckBox();
            this.btnA4Fill = new MetroFramework.Controls.MetroButton();
            this.btnA4Zoom = new MetroFramework.Controls.MetroButton();
            this.tbRotate = new MetroFramework.Controls.MetroTrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panelScrnBar.SuspendLayout();
            this.btntest.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScrn
            // 
            this.btnScrn.BackColor = System.Drawing.Color.White;
            this.btnScrn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScrn.BackgroundImage")));
            this.btnScrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScrn.FlatAppearance.BorderSize = 0;
            this.btnScrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrn.Location = new System.Drawing.Point(3, 3);
            this.btnScrn.Name = "btnScrn";
            this.btnScrn.Size = new System.Drawing.Size(25, 25);
            this.btnScrn.TabIndex = 0;
            this.btnScrn.UseVisualStyleBackColor = false;
            this.btnScrn.Click += new System.EventHandler(this.btnScrn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "截屏";
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Location = new System.Drawing.Point(4, 50);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(1067, 478);
            this.panelImage.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbA4);
            this.groupBox1.Controls.Add(this.cbA4SizeFollow);
            this.groupBox1.Controls.Add(this.btnA4LocationBottom);
            this.groupBox1.Controls.Add(this.btnA4Zoom);
            this.groupBox1.Controls.Add(this.btnA4Fill);
            this.groupBox1.Controls.Add(this.btnA4LocationCenter);
            this.groupBox1.Controls.Add(this.btnA4LocationTop);
            this.groupBox1.Location = new System.Drawing.Point(921, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A4";
            // 
            // btnA4LocationBottom
            // 
            this.btnA4LocationBottom.FontSize = MetroFramework.MetroLabelSize.Small;
            this.btnA4LocationBottom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnA4LocationBottom.Highlight = false;
            this.btnA4LocationBottom.Location = new System.Drawing.Point(9, 105);
            this.btnA4LocationBottom.Name = "btnA4LocationBottom";
            this.btnA4LocationBottom.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationBottom.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnA4LocationBottom.StyleManager = null;
            this.btnA4LocationBottom.TabIndex = 5;
            this.btnA4LocationBottom.Text = "底部";
            this.btnA4LocationBottom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnA4LocationBottom.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // btnA4LocationCenter
            // 
            this.btnA4LocationCenter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.btnA4LocationCenter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnA4LocationCenter.Highlight = false;
            this.btnA4LocationCenter.Location = new System.Drawing.Point(9, 74);
            this.btnA4LocationCenter.Name = "btnA4LocationCenter";
            this.btnA4LocationCenter.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationCenter.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnA4LocationCenter.StyleManager = null;
            this.btnA4LocationCenter.TabIndex = 5;
            this.btnA4LocationCenter.Text = "居中";
            this.btnA4LocationCenter.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnA4LocationCenter.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // btnA4LocationTop
            // 
            this.btnA4LocationTop.FontSize = MetroFramework.MetroLabelSize.Small;
            this.btnA4LocationTop.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnA4LocationTop.Highlight = false;
            this.btnA4LocationTop.Location = new System.Drawing.Point(9, 43);
            this.btnA4LocationTop.Name = "btnA4LocationTop";
            this.btnA4LocationTop.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationTop.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnA4LocationTop.StyleManager = null;
            this.btnA4LocationTop.TabIndex = 5;
            this.btnA4LocationTop.Text = "顶部";
            this.btnA4LocationTop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnA4LocationTop.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // picScrn
            // 
            this.picScrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picScrn.BackColor = System.Drawing.Color.White;
            this.picScrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picScrn.Location = new System.Drawing.Point(922, 35);
            this.picScrn.Name = "picScrn";
            this.picScrn.Size = new System.Drawing.Size(149, 130);
            this.picScrn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScrn.TabIndex = 2;
            this.picScrn.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.picImage.Location = new System.Drawing.Point(2, 35);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(913, 503);
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            this.picImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picImage_Paint);
            // 
            // panelScrnBar
            // 
            this.panelScrnBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScrnBar.BackColor = System.Drawing.Color.Goldenrod;
            this.panelScrnBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScrnBar.Controls.Add(this.label3);
            this.panelScrnBar.Location = new System.Drawing.Point(922, 3);
            this.panelScrnBar.Name = "panelScrnBar";
            this.panelScrnBar.Size = new System.Drawing.Size(149, 30);
            this.panelScrnBar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "截 图";
            // 
            // btntest
            // 
            this.btntest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btntest.BackColor = System.Drawing.Color.Goldenrod;
            this.btntest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btntest.Controls.Add(this.tbRotate);
            this.btntest.Controls.Add(this.btnSub);
            this.btntest.Controls.Add(this.btnAdd);
            this.btntest.Controls.Add(this.label2);
            this.btntest.Controls.Add(this.btnOpenImage);
            this.btntest.Controls.Add(this.btnCut);
            this.btntest.Controls.Add(this.btnCutPic);
            this.btntest.Controls.Add(this.btnHorFlip);
            this.btntest.Controls.Add(this.btnVerFlip);
            this.btntest.Controls.Add(this.btnRightRotate90);
            this.btntest.Controls.Add(this.btnLeftRotate90);
            this.btntest.Location = new System.Drawing.Point(2, 3);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(913, 30);
            this.btntest.TabIndex = 0;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSub.BackgroundImage = global::ImageTools_GDI.Properties.Resources.sub;
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSub.Location = new System.Drawing.Point(125, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(20, 20);
            this.btnSub.TabIndex = 0;
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.BackgroundImage = global::ImageTools_GDI.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(367, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "0°";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage.BackgroundImage = global::ImageTools_GDI.Properties.Resources.打开;
            this.btnOpenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenImage.FlatAppearance.BorderSize = 0;
            this.btnOpenImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnOpenImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnOpenImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenImage.Location = new System.Drawing.Point(854, 7);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(20, 15);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnCut
            // 
            this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCut.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCut.BackgroundImage = global::ImageTools_GDI.Properties.Resources.截图;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.FlatAppearance.BorderSize = 0;
            this.btnCut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.ForeColor = System.Drawing.Color.Black;
            this.btnCut.Location = new System.Drawing.Point(883, 3);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(22, 20);
            this.btnCut.TabIndex = 0;
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCutPic
            // 
            this.btnCutPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCutPic.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCutPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCutPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCutPic.FlatAppearance.BorderSize = 0;
            this.btnCutPic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnCutPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnCutPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCutPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCutPic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCutPic.Image = global::ImageTools_GDI.Properties.Resources.btnSelect;
            this.btnCutPic.Location = new System.Drawing.Point(823, 3);
            this.btnCutPic.Name = "btnCutPic";
            this.btnCutPic.Size = new System.Drawing.Size(20, 20);
            this.btnCutPic.TabIndex = 0;
            this.btnCutPic.UseVisualStyleBackColor = false;
            this.btnCutPic.Click += new System.EventHandler(this.btnCutPic_Click);
            // 
            // btnHorFlip
            // 
            this.btnHorFlip.BackgroundImage = global::ImageTools_GDI.Properties.Resources.垂直翻转;
            this.btnHorFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorFlip.FlatAppearance.BorderSize = 0;
            this.btnHorFlip.FlatAppearance.CheckedBackColor = System.Drawing.Color.Goldenrod;
            this.btnHorFlip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnHorFlip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnHorFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorFlip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHorFlip.Location = new System.Drawing.Point(94, 3);
            this.btnHorFlip.Name = "btnHorFlip";
            this.btnHorFlip.Size = new System.Drawing.Size(20, 20);
            this.btnHorFlip.TabIndex = 0;
            this.btnHorFlip.UseVisualStyleBackColor = true;
            this.btnHorFlip.Click += new System.EventHandler(this.btnHorFlip_Click);
            // 
            // btnVerFlip
            // 
            this.btnVerFlip.BackgroundImage = global::ImageTools_GDI.Properties.Resources.水平翻转;
            this.btnVerFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerFlip.FlatAppearance.BorderSize = 0;
            this.btnVerFlip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnVerFlip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnVerFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFlip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerFlip.Location = new System.Drawing.Point(64, 3);
            this.btnVerFlip.Name = "btnVerFlip";
            this.btnVerFlip.Size = new System.Drawing.Size(20, 20);
            this.btnVerFlip.TabIndex = 0;
            this.btnVerFlip.UseVisualStyleBackColor = true;
            this.btnVerFlip.Click += new System.EventHandler(this.btnVerFlip_Click);
            // 
            // btnRightRotate90
            // 
            this.btnRightRotate90.BackgroundImage = global::ImageTools_GDI.Properties.Resources.btnRotate90;
            this.btnRightRotate90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRightRotate90.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRightRotate90.FlatAppearance.BorderSize = 0;
            this.btnRightRotate90.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnRightRotate90.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRightRotate90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightRotate90.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRightRotate90.Location = new System.Drawing.Point(38, 4);
            this.btnRightRotate90.Name = "btnRightRotate90";
            this.btnRightRotate90.Size = new System.Drawing.Size(20, 20);
            this.btnRightRotate90.TabIndex = 0;
            this.btnRightRotate90.UseVisualStyleBackColor = true;
            this.btnRightRotate90.Click += new System.EventHandler(this.btnRightRotate90_Click);
            // 
            // btnLeftRotate90
            // 
            this.btnLeftRotate90.BackgroundImage = global::ImageTools_GDI.Properties.Resources.btnRotate270;
            this.btnLeftRotate90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeftRotate90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftRotate90.FlatAppearance.BorderSize = 0;
            this.btnLeftRotate90.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLeftRotate90.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnLeftRotate90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftRotate90.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeftRotate90.Location = new System.Drawing.Point(7, 4);
            this.btnLeftRotate90.Name = "btnLeftRotate90";
            this.btnLeftRotate90.Size = new System.Drawing.Size(20, 20);
            this.btnLeftRotate90.TabIndex = 0;
            this.btnLeftRotate90.UseVisualStyleBackColor = true;
            this.btnLeftRotate90.Click += new System.EventHandler(this.btnLeftRotate90_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1082, 580);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnScrn);
            this.metroTabPage1.Controls.Add(this.panelImage);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.CustomBackground = false;
            this.metroTabPage1.HorizontalScrollbar = false;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1074, 540);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "截屏";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = false;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.picScrn);
            this.metroTabPage2.Controls.Add(this.panelScrnBar);
            this.metroTabPage2.Controls.Add(this.btntest);
            this.metroTabPage2.Controls.Add(this.picImage);
            this.metroTabPage2.CustomBackground = false;
            this.metroTabPage2.HorizontalScrollbar = false;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1074, 540);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.StyleManager = null;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "编辑";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = false;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // cbA4SizeFollow
            // 
            this.cbA4SizeFollow.AutoSize = true;
            this.cbA4SizeFollow.Checked = true;
            this.cbA4SizeFollow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbA4SizeFollow.CustomBackground = false;
            this.cbA4SizeFollow.Enabled = false;
            this.cbA4SizeFollow.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cbA4SizeFollow.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbA4SizeFollow.Location = new System.Drawing.Point(69, 20);
            this.cbA4SizeFollow.Name = "cbA4SizeFollow";
            this.cbA4SizeFollow.Size = new System.Drawing.Size(75, 15);
            this.cbA4SizeFollow.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbA4SizeFollow.StyleManager = null;
            this.cbA4SizeFollow.TabIndex = 6;
            this.cbA4SizeFollow.Text = "大小跟随";
            this.cbA4SizeFollow.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbA4SizeFollow.UseStyleColors = false;
            this.cbA4SizeFollow.UseVisualStyleBackColor = true;
            this.cbA4SizeFollow.CheckedChanged += new System.EventHandler(this.cbA4SizeFollow_CheckedChanged);
            // 
            // cbA4
            // 
            this.cbA4.AutoSize = true;
            this.cbA4.CustomBackground = false;
            this.cbA4.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cbA4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbA4.Location = new System.Drawing.Point(9, 20);
            this.cbA4.Name = "cbA4";
            this.cbA4.Size = new System.Drawing.Size(37, 15);
            this.cbA4.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbA4.StyleManager = null;
            this.cbA4.TabIndex = 6;
            this.cbA4.Text = "A4";
            this.cbA4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbA4.UseStyleColors = false;
            this.cbA4.UseVisualStyleBackColor = true;
            this.cbA4.CheckedChanged += new System.EventHandler(this.cbA4_CheckedChanged);
            // 
            // btnA4Fill
            // 
            this.btnA4Fill.Enabled = false;
            this.btnA4Fill.FontSize = MetroFramework.MetroLabelSize.Small;
            this.btnA4Fill.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnA4Fill.Highlight = false;
            this.btnA4Fill.Location = new System.Drawing.Point(87, 43);
            this.btnA4Fill.Name = "btnA4Fill";
            this.btnA4Fill.Size = new System.Drawing.Size(57, 23);
            this.btnA4Fill.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnA4Fill.StyleManager = null;
            this.btnA4Fill.TabIndex = 5;
            this.btnA4Fill.Text = "填充";
            this.btnA4Fill.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnA4Fill.Click += new System.EventHandler(this.btnA4ImageStyleMode_Click);
            // 
            // btnA4Zoom
            // 
            this.btnA4Zoom.Enabled = false;
            this.btnA4Zoom.FontSize = MetroFramework.MetroLabelSize.Small;
            this.btnA4Zoom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnA4Zoom.Highlight = false;
            this.btnA4Zoom.Location = new System.Drawing.Point(87, 74);
            this.btnA4Zoom.Name = "btnA4Zoom";
            this.btnA4Zoom.Size = new System.Drawing.Size(57, 23);
            this.btnA4Zoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnA4Zoom.StyleManager = null;
            this.btnA4Zoom.TabIndex = 5;
            this.btnA4Zoom.Text = "缩放";
            this.btnA4Zoom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnA4Zoom.Click += new System.EventHandler(this.btnA4ImageStyleMode_Click);
            // 
            // tbRotate
            // 
            this.tbRotate.BackColor = System.Drawing.Color.Goldenrod;
            this.tbRotate.CustomBackground = true;
            this.tbRotate.LargeChange = ((uint)(5u));
            this.tbRotate.Location = new System.Drawing.Point(149, 3);
            this.tbRotate.Maximum = 360;
            this.tbRotate.Minimum = 0;
            this.tbRotate.MouseWheelBarPartitions = 10;
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(195, 23);
            this.tbRotate.SmallChange = ((uint)(1u));
            this.tbRotate.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRotate.StyleManager = null;
            this.tbRotate.TabIndex = 5;
            this.tbRotate.Text = "metroTrackBar1";
            this.tbRotate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRotate.Value = 0;
            this.tbRotate.ValueChanged += new System.EventHandler(this.tbRotate_ValueChanged);
            this.tbRotate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbRotate_Scroll);
            // 
            // FrmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 660);
            this.Controls.Add(this.metroTabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmTool";
            this.Load += new System.EventHandler(this.FrmTool_Load);
            this.SizeChanged += new System.EventHandler(this.FrmScrn_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panelScrnBar.ResumeLayout(false);
            this.panelScrnBar.PerformLayout();
            this.btntest.ResumeLayout(false);
            this.btntest.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel btntest;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox picScrn;
        private System.Windows.Forms.Panel panelScrnBar;
        private System.Windows.Forms.Button btnLeftRotate90;
        private System.Windows.Forms.Button btnRightRotate90;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnHorFlip;
        private System.Windows.Forms.Button btnVerFlip;
        private System.Windows.Forms.Button btnCutPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnA4LocationTop;
        private MetroFramework.Controls.MetroCheckBox cbA4SizeFollow;
        private MetroFramework.Controls.MetroButton btnA4LocationBottom;
        private MetroFramework.Controls.MetroButton btnA4LocationCenter;
        private MetroFramework.Controls.MetroCheckBox cbA4;
        private MetroFramework.Controls.MetroButton btnA4Zoom;
        private MetroFramework.Controls.MetroButton btnA4Fill;
        private MetroFramework.Controls.MetroTrackBar tbRotate;
    }
}