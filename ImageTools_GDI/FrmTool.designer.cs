
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnA4Zoom = new System.Windows.Forms.Button();
            this.btnA4Fill = new System.Windows.Forms.Button();
            this.btnA4LocationCenter = new System.Windows.Forms.Button();
            this.btnA4LocationBottom = new System.Windows.Forms.Button();
            this.btnA4LocationTop = new System.Windows.Forms.Button();
            this.cbA4SizeFollow = new System.Windows.Forms.CheckBox();
            this.cbA4 = new System.Windows.Forms.CheckBox();
            this.picScrn = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panelScrnBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Panel();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRotate = new System.Windows.Forms.TrackBar();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnCutPic = new System.Windows.Forms.Button();
            this.btnHorFlip = new System.Windows.Forms.Button();
            this.btnVerFlip = new System.Windows.Forms.Button();
            this.btnRightRotate90 = new System.Windows.Forms.Button();
            this.btnLeftRotate90 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScrn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panelScrnBar.SuspendLayout();
            this.btntest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScrn
            // 
            this.btnScrn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScrn.BackgroundImage")));
            this.btnScrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScrn.FlatAppearance.BorderSize = 0;
            this.btnScrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrn.Location = new System.Drawing.Point(8, 6);
            this.btnScrn.Name = "btnScrn";
            this.btnScrn.Size = new System.Drawing.Size(25, 25);
            this.btnScrn.TabIndex = 0;
            this.btnScrn.UseVisualStyleBackColor = true;
            this.btnScrn.Click += new System.EventHandler(this.btnScrn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
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
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Location = new System.Drawing.Point(9, 53);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(965, 498);
            this.panelImage.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 585);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnScrn);
            this.tabPage1.Controls.Add(this.panelImage);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.picScrn);
            this.tabPage2.Controls.Add(this.picImage);
            this.tabPage2.Controls.Add(this.panelScrnBar);
            this.tabPage2.Controls.Add(this.btntest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnA4Zoom);
            this.groupBox1.Controls.Add(this.btnA4Fill);
            this.groupBox1.Controls.Add(this.btnA4LocationCenter);
            this.groupBox1.Controls.Add(this.btnA4LocationBottom);
            this.groupBox1.Controls.Add(this.btnA4LocationTop);
            this.groupBox1.Controls.Add(this.cbA4SizeFollow);
            this.groupBox1.Controls.Add(this.cbA4);
            this.groupBox1.Location = new System.Drawing.Point(824, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A4";
            // 
            // btnA4Zoom
            // 
            this.btnA4Zoom.Enabled = false;
            this.btnA4Zoom.Location = new System.Drawing.Point(87, 81);
            this.btnA4Zoom.Name = "btnA4Zoom";
            this.btnA4Zoom.Size = new System.Drawing.Size(57, 23);
            this.btnA4Zoom.TabIndex = 4;
            this.btnA4Zoom.Text = "缩放";
            this.btnA4Zoom.UseVisualStyleBackColor = true;
            this.btnA4Zoom.Click += new System.EventHandler(this.btnA4ImageStyleMode_Click);
            // 
            // btnA4Fill
            // 
            this.btnA4Fill.Enabled = false;
            this.btnA4Fill.Location = new System.Drawing.Point(87, 47);
            this.btnA4Fill.Name = "btnA4Fill";
            this.btnA4Fill.Size = new System.Drawing.Size(57, 23);
            this.btnA4Fill.TabIndex = 4;
            this.btnA4Fill.Text = "填充";
            this.btnA4Fill.UseVisualStyleBackColor = true;
            this.btnA4Fill.Click += new System.EventHandler(this.btnA4ImageStyleMode_Click);
            // 
            // btnA4LocationCenter
            // 
            this.btnA4LocationCenter.Enabled = false;
            this.btnA4LocationCenter.Location = new System.Drawing.Point(9, 77);
            this.btnA4LocationCenter.Name = "btnA4LocationCenter";
            this.btnA4LocationCenter.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationCenter.TabIndex = 4;
            this.btnA4LocationCenter.Text = "居中";
            this.btnA4LocationCenter.UseVisualStyleBackColor = true;
            this.btnA4LocationCenter.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // btnA4LocationBottom
            // 
            this.btnA4LocationBottom.Enabled = false;
            this.btnA4LocationBottom.Location = new System.Drawing.Point(9, 109);
            this.btnA4LocationBottom.Name = "btnA4LocationBottom";
            this.btnA4LocationBottom.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationBottom.TabIndex = 4;
            this.btnA4LocationBottom.Text = "底部";
            this.btnA4LocationBottom.UseVisualStyleBackColor = true;
            this.btnA4LocationBottom.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // btnA4LocationTop
            // 
            this.btnA4LocationTop.Enabled = false;
            this.btnA4LocationTop.Location = new System.Drawing.Point(9, 45);
            this.btnA4LocationTop.Name = "btnA4LocationTop";
            this.btnA4LocationTop.Size = new System.Drawing.Size(57, 23);
            this.btnA4LocationTop.TabIndex = 4;
            this.btnA4LocationTop.Text = "顶部";
            this.btnA4LocationTop.UseVisualStyleBackColor = true;
            this.btnA4LocationTop.Click += new System.EventHandler(this.btnA4Location_Click);
            // 
            // cbA4SizeFollow
            // 
            this.cbA4SizeFollow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbA4SizeFollow.AutoSize = true;
            this.cbA4SizeFollow.Checked = true;
            this.cbA4SizeFollow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbA4SizeFollow.Enabled = false;
            this.cbA4SizeFollow.Location = new System.Drawing.Point(72, 20);
            this.cbA4SizeFollow.Name = "cbA4SizeFollow";
            this.cbA4SizeFollow.Size = new System.Drawing.Size(72, 16);
            this.cbA4SizeFollow.TabIndex = 3;
            this.cbA4SizeFollow.Text = "大小跟随";
            this.cbA4SizeFollow.UseVisualStyleBackColor = true;
            this.cbA4SizeFollow.CheckedChanged += new System.EventHandler(this.cbA4SizeFollow_CheckedChanged);
            // 
            // cbA4
            // 
            this.cbA4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbA4.AutoSize = true;
            this.cbA4.Location = new System.Drawing.Point(9, 20);
            this.cbA4.Name = "cbA4";
            this.cbA4.Size = new System.Drawing.Size(36, 16);
            this.cbA4.TabIndex = 3;
            this.cbA4.Text = "A4";
            this.cbA4.UseVisualStyleBackColor = true;
            this.cbA4.CheckedChanged += new System.EventHandler(this.cbA4_CheckedChanged);
            // 
            // picScrn
            // 
            this.picScrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picScrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picScrn.Location = new System.Drawing.Point(825, 42);
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
            this.picImage.BackColor = System.Drawing.Color.LightGray;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.picImage.Location = new System.Drawing.Point(4, 42);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(815, 511);
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
            this.panelScrnBar.Location = new System.Drawing.Point(825, 6);
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
            this.btntest.Controls.Add(this.btnSub);
            this.btntest.Controls.Add(this.btnAdd);
            this.btntest.Controls.Add(this.label2);
            this.btntest.Controls.Add(this.tbRotate);
            this.btntest.Controls.Add(this.btnOpenImage);
            this.btntest.Controls.Add(this.btnCut);
            this.btntest.Controls.Add(this.btnCutPic);
            this.btntest.Controls.Add(this.btnHorFlip);
            this.btntest.Controls.Add(this.btnVerFlip);
            this.btntest.Controls.Add(this.btnRightRotate90);
            this.btntest.Controls.Add(this.btnLeftRotate90);
            this.btntest.Location = new System.Drawing.Point(4, 6);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(815, 30);
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
            // tbRotate
            // 
            this.tbRotate.Location = new System.Drawing.Point(144, 4);
            this.tbRotate.Maximum = 360;
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(211, 45);
            this.tbRotate.TabIndex = 1;
            this.tbRotate.Scroll += new System.EventHandler(this.tbRotate_Scroll);
            this.tbRotate.ValueChanged += new System.EventHandler(this.tbRotate_ValueChanged);
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
            this.btnOpenImage.Location = new System.Drawing.Point(756, 7);
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
            this.btnCut.Location = new System.Drawing.Point(785, 3);
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
            this.btnCutPic.Location = new System.Drawing.Point(725, 3);
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
            // FrmScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 585);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmScrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScrn";
            this.SizeChanged += new System.EventHandler(this.FrmScrn_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScrn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panelScrnBar.ResumeLayout(false);
            this.panelScrnBar.PerformLayout();
            this.btntest.ResumeLayout(false);
            this.btntest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TrackBar tbRotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbA4;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnA4Fill;
        private System.Windows.Forms.Button btnA4LocationCenter;
        private System.Windows.Forms.Button btnA4LocationBottom;
        private System.Windows.Forms.Button btnA4LocationTop;
        private System.Windows.Forms.CheckBox cbA4SizeFollow;
        private System.Windows.Forms.Button btnA4Zoom;
    }
}