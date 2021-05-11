using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ImageTools_GDI.control;

namespace ImageTools_GDI
{
    public partial class FrmTool : MetroFramework.Forms.MetroForm
    {
        #region args

        [DllImport("PrScrn.dll", EntryPoint = "PrScrn")]
        public extern static int PrScrn();

        public CutPicPanelTools ScrnTools = null;
        CutPicPanel panel1 = null;


        /// <summary>
        /// 裁剪图片
        /// </summary>
        Boolean isCut = false;

        /// <summary>
        /// 移动图片
        /// </summary>
        Boolean isPicMove = true;

        /// <summary>
        /// 移动矩形
        /// </summary>
        Boolean isRectMove = false;


        /// <summary>
        /// 当前鼠标按下的坐标
        /// </summary>
        Point m_now_point;

        /// <summary>
        /// 鼠标是否按下
        /// </summary>
        Boolean m_down = false;

        /// <summary>
        /// 原始图片
        /// </summary>
        Image orig_image = null;

        /// <summary>
        /// 操作后的图片
        /// </summary>
        Image src_image = null;

        #region 矩形选矿
        /// <summary>
        /// 矩形选框的工具栏
        /// </summary>
        Boolean show_tools = false;

        /// <summary>
        /// 当前鼠标坐标(拖动矩形选框用)
        /// </summary>
        Point rect_basepoint;

        /// <summary>
        /// 矩形选框移动次数
        /// </summary>
        int rect_move_count;

        Bitmap bitmap = null;
        Graphics graph;
        Pen pen;
        Rectangle draw_rect;
        #endregion

        #region 缩放拖拽

        Point mouseDownPoint;
        int width, height;
        /// <summary>
        /// 宽高比
        /// </summary>
        decimal percent = 0m;
        /// <summary>
        /// 缩放
        /// </summary>
        Rectangle rect;
        #endregion

        #region 改变图片大小
        Rectangle[] rectArray = new Rectangle[8];
        bool isSizeMove = false;
        bool isEdit = false;
        Brush sizeRectColor = new SolidBrush(Color.FromArgb(0, 122, 204));
        Rectangle rotateMaxRect;
        #endregion

        /// <summary>
        /// 图片位置 默认1
        /// 0:top 1:center 2:bottom
        /// </summary>
        int img_location = 1;

        /// <summary>
        /// 图片缩放模式 默认1
        /// 0:fill 1:zoom
        /// </summary>
        int img_style_model = 1;

        bool a4Hide, editHide, dashHide;
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (keyData == (Keys.R))
            {
                tbRotate.Value = 0;
            }
            if (keyData == (Keys.Right))
            {
                if (isEdit)
                {
                    rect.X++;
                    picImage.Invalidate();
                }
                else
                {
                    if (tbRotate.Value >= 1800) return true;
                    tbRotate.Value++;
                }
            }
            if (keyData == (Keys.Left))
            {
                if (isEdit)
                {
                    rect.X--;
                    picImage.Invalidate();
                }
                else
                {
                    if (tbRotate.Value <= -1800) return true;
                    tbRotate.Value--;
                }
            }
            if (keyData==Keys.Up && isEdit)
            {
                rect.Y--;
                picImage.Invalidate();
            }
            if (keyData==Keys.Down && isEdit)
            {
                rect.Y++;
                picImage.Invalidate();
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }

        public FrmTool()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            panel1 = new CutPicPanel();
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.MouseDown += this.FrmScrn_MouseDown;
            panel1.MouseMove += this.FrmScrn_MouseMove;
            panel1.MouseUp += this.FrmScrn_MouseUp;
            panel1.MouseWheel += this.Panel1_MouseWheel;
            panel1.MouseDoubleClick += Panel1_MouseDoubleClick; ;
            panel1.DragDrop += Panel1_DragDrop;
            panel1.DragEnter += Panel1_DragEnter;
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
            panel1.AllowDrop = true;
            picImage.Controls.Add(panel1);
        }

        private void Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rect.Contains(e.Location))
            {
                isEdit = true;
            }
            else
            {
                isEdit = false;
            }
            picImage.Invalidate();
        }

        #region 事件
        /// <summary>
        /// 截图按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScrn_Click(Object sender, EventArgs e)
        {
            if (PrScrn() == 1)
            {
                if (Clipboard.ContainsImage())
                {
                    //panelImage.BackgroundImage = Clipboard.GetImage();
                }
            }
        }

        #region 画布工作区
        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();       //获得路径
            orig_image = Image.FromFile(path);
            src_image = Image.FromFile(path);

            width = src_image.Width;
            height = src_image.Height;
            percent = Convert.ToDecimal(width) / Convert.ToDecimal(height);
            rect = new Rectangle(0, 0, width, height);
            picImage.Invalidate();
        }

        private void Panel1_MouseWheel(Object sender, MouseEventArgs e)
        {
            width += (e.Delta / 5);
            height = Convert.ToInt32(width / percent);
            picImage.Invalidate();
        }

        private void FrmScrn_MouseUp(Object sender, MouseEventArgs e)
        {
            m_down = false;
            isRectMove = false;
            isPicMove = false;
            if (show_tools && draw_rect.Height > 0 && draw_rect.Width > 0)
            {
                ScrnTools = new CutPicPanelTools();
                ScrnTools.Size = new System.Drawing.Size(72, 30);
                ScrnTools.Location = new System.Drawing.Point(draw_rect.X + draw_rect.Width - ScrnTools.Width, draw_rect.Y + draw_rect.Height + 2);
                ScrnTools.BringToFront();
                ScrnTools.Visible = true;
                ScrnTools.ToolsClickEvent += this.ScrnTools_ToolsClickEvent;
                ScrnTools.Show();
                panel1.Controls.Add(ScrnTools);
            }
            if (isPicMove)
            {
                isPicMove = false;
            }
            Cursor.Current = Cursors.Default;
        }

        private void FrmScrn_MouseMove(Object sender, MouseEventArgs e)
        {
            if (m_down)//左键按下时
            {
                //砍掉，使用微信截图dll
                if (isCut)
                {
                    if (isRectMove)
                    {
                        //移动矩形框
                        draw_rect.X = draw_rect.X + (e.X - m_now_point.X);
                        draw_rect.Y = draw_rect.Y + (e.Y - m_now_point.Y);

                        //判断是否超过左上角           
                        if (draw_rect.X < 0)
                            draw_rect.X = 0;
                        if (draw_rect.Y < 0)
                            draw_rect.Y = 0;
                        //判断是否超过右下 角     
                        if (draw_rect.X > (this.Width - draw_rect.Width - 1))
                            draw_rect.X = this.Width - draw_rect.Width - 1;
                        if (draw_rect.Y > (this.Height - draw_rect.Height - 1))
                            draw_rect.Y = this.Height - draw_rect.Height - 1;
                        //画图              
                        bitmap = new Bitmap(panel1.Width, panel1.Height);
                        graph = Graphics.FromImage(bitmap);
                        pen = new Pen(Color.Red, 1.0f);
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                        //graph.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.LightGreen)), draw_rect);
                        graph.DrawRectangle(pen, draw_rect);

                        m_now_point.X = e.X;
                        m_now_point.Y = e.Y;
                        rect_move_count++;
                        show_tools = true;
                        panel1.BackgroundImage = bitmap;
                        graph.Dispose();
                        pen.Dispose();
                    }
                    else
                    {
                        //画矩形
                        bitmap = new Bitmap(panel1.Width, panel1.Height);
                        graph = Graphics.FromImage(bitmap);
                        pen = new Pen(Color.Red, 1.0f);
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        if (e.X < rect_basepoint.X && e.Y < rect_basepoint.Y)
                        {
                            draw_rect = new Rectangle(e.X, e.Y, System.Math.Abs(e.X - rect_basepoint.X), System.Math.Abs(e.Y - rect_basepoint.Y));
                            graph.DrawRectangle(pen, draw_rect);
                            //graph.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.LightGreen)), draw_rect);
                        }
                        else if (e.X > rect_basepoint.X && e.Y < rect_basepoint.Y)
                        {
                            draw_rect = new Rectangle(rect_basepoint.X, e.Y, System.Math.Abs(e.X - rect_basepoint.X), System.Math.Abs(e.Y - rect_basepoint.Y));
                            graph.DrawRectangle(pen, draw_rect);
                            //graph.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.LightGreen)), draw_rect);
                        }
                        else if (e.X < rect_basepoint.X && e.Y > rect_basepoint.Y)
                        {
                            draw_rect = new Rectangle(e.X, rect_basepoint.Y, System.Math.Abs(e.X - rect_basepoint.X), System.Math.Abs(e.Y - rect_basepoint.Y));
                            graph.DrawRectangle(pen, draw_rect);
                            //graph.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.LightGreen)), draw_rect);
                        }
                        else
                        {
                            draw_rect = new Rectangle(rect_basepoint.X, rect_basepoint.Y, System.Math.Abs(e.X - rect_basepoint.X), System.Math.Abs(e.Y - rect_basepoint.Y));
                            graph.DrawRectangle(pen, draw_rect);
                            //graph.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.LightGreen)), draw_rect);
                        }
                    }

                    show_tools = true;
                    panel1.BackgroundImage = bitmap;
                    graph.Dispose();
                    pen.Dispose();
                }
                else if (isPicMove)
                {
                    if (rect.Contains(e.Location))
                    {
                        Cursor.Current = Cursors.Hand;
                        Point nowPoint = e.Location;
                        nowPoint.Offset(-mouseDownPoint.X, -mouseDownPoint.Y);
                        rect.Location = nowPoint;
                        picImage.Invalidate();
                    }
                    else
                        Cursor.Current = Cursors.Default;
                }
                else if (isSizeMove)
                {
                    width = e.X - rect.Location.X;
                    height = e.Y - rect.Location.Y;
                    if (width <= 50 || height <= 50)
                    {
                        return;
                    }
                    picImage.Invalidate();
                }
            }
            else
            {
                if (rectArray[0].Contains(e.Location))
                {
                    sizeRectColor = new SolidBrush(Color.Red);
                }
                else
                {
                    sizeRectColor = new SolidBrush(Color.FromArgb(0, 122, 204));
                }
                picImage.Invalidate();
            }
        }

        private void FrmScrn_MouseDown(Object sender, MouseEventArgs e)
        {
            if (src_image == null) return;
            m_now_point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left)//画图，取消，拖动,旋转
            {
                if (rectArray[0].Contains(m_now_point))
                {
                    m_down = true;
                    isSizeMove = true;
                    picImage.Invalidate();
                    return;
                }
                if (draw_rect != null && draw_rect.Contains(m_now_point))
                {
                    //鼠标在矩形范围内拖动
                    isRectMove = true;
                    //isPicMove = false;
                }
                else
                {
                    rect_basepoint = e.Location;
                    isPicMove = true;

                    //鼠标不在矩形范围内，图片移动，清除矩形
                    bitmap = new Bitmap(panel1.Width, panel1.Height);
                    graph = Graphics.FromImage(bitmap);
                    graph.Clear(Color.Transparent);
                    panel1.BackgroundImage = bitmap;
                    draw_rect = new Rectangle(0, 0, 0, 0);

                    //图片移动
                    mouseDownPoint = e.Location;
                    mouseDownPoint.Offset(-rect.X, -rect.Y);
                    isPicMove = e.Button == MouseButtons.Left;
                    if (isPicMove && rect.Contains(e.Location))
                        Cursor.Current = Cursors.Hand;
                    else
                        Cursor.Current = Cursors.Default;
                }
                //清除矩形工具栏
                if (ScrnTools != null)
                {
                    ScrnTools.Visible = false;
                    ScrnTools.Dispose();
                    panel1.Controls.Clear();
                    ScrnTools = null;
                    show_tools = false;
                    isPicMove = false;
                }
            }
            m_down = true;
        }
        #endregion


        /// <summary>
        /// 打开图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenImage_Click(Object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                orig_image = Image.FromFile(ofd.FileName);
                src_image = Image.FromFile(ofd.FileName);

                width = src_image.Width;
                height = src_image.Height;
                percent = Convert.ToDecimal(width) / Convert.ToDecimal(height);

                var x = (picImage.Width / 2) - (src_image.Width / 2);
                var y = (picImage.Height / 2) - (src_image.Height / 2);
                rect = new Rectangle(x, y, width, height);
                picImage.Invalidate();
            }
        }

        private void ScrnTools_ToolsClickEvent(Object sender, EventArgs e)
        {
            if ((int)sender == 1)
            {
                Point r = new Point();
                Bitmap image = new Bitmap(draw_rect.Width, draw_rect.Height);
                Graphics imgGh = Graphics.FromImage(image);
                r.X = draw_rect.X;
                r.Y = draw_rect.Y;
                r = panel1.PointToScreen(r);
                imgGh.CopyFromScreen(r, new Point(0, 0), new Size(draw_rect.Width, draw_rect.Height));

                picScrn.Image = image;
            }
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(bitmap);
            graph.Clear(Color.Transparent);
            panel1.BackgroundImage = bitmap;
            draw_rect = new Rectangle(0, 0, 0, 0);
            ScrnTools.Visible = false;
            ScrnTools.Dispose();
            panel1.Controls.Clear();
            show_tools = false;
        }

        /// <summary>
        /// 向左旋转90°
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeftRotate90_Click(Object sender, EventArgs e)
        {
            if (this.src_image == null) return;
            Image img = this.src_image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            picImage.Invalidate();
        }

        /// <summary>
        /// 向右旋转90°
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRightRotate90_Click(Object sender, EventArgs e)
        {
            if (this.src_image == null) return;
            Image img = this.src_image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picImage.Invalidate();
        }

        /// <summary>
        /// 向右旋转1°
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbRotate.Value >= 1800) return;
            tbRotate.Value++;
        }

        /// <summary>
        /// 向左旋转1°
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (tbRotate.Value <= -1800) return;
            tbRotate.Value--;
        }

        /// <summary>
        /// 图片旋转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRotate_Scroll(Object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 旋转图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRotate_ValueChanged(object sender, EventArgs e)
        {
            if (this.src_image == null) return;
            float angle = tbRotate.Value * 0.1F;
            txtRotate.Text = angle.ToString();
            picImage.Invalidate();
        }

        /// <summary>
        /// 垂直翻转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerFlip_Click(Object sender, EventArgs e)
        {
            if (this.src_image == null) return;
            Image img = this.src_image;
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            picImage.Invalidate();
        }

        /// <summary>
        /// 水平翻转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHorFlip_Click(Object sender, EventArgs e)
        {
            if (this.src_image == null) return;
            Image img = this.src_image;
            img.RotateFlip(RotateFlipType.Rotate180FlipX);
            picImage.Invalidate();
        }

        /// <summary>
        /// 画布重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picImage_Paint(Object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            if (src_image == null) return;
            if (width <= 10 || height <= 10)
            {
                width = rect.Width;
                height = rect.Height;
            }

            rect.Width = width;
            rect.Height = height;
            e.Graphics.Clear(Color.White);
            float rotate = tbRotate.Value * 0.1F;
            RoatetImage(src_image, e.Graphics, rect, rotate);

            if (cbA4.Checked && !a4Hide)
            {
                pen = new Pen(Color.Red, 2.0f);
                var rect = GetA4Rectangle();
                e.Graphics.DrawRectangle(pen, rect);
            }
            if (cbDash.Checked && !dashHide)
            {
                pen = new Pen(DashColor.BackColor, 0.5f);
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new float[] { 2, 4 };


                int hline2Y = panel1.Height / 2;
                e.Graphics.DrawLine(pen, 0, hline2Y, panel1.Width, hline2Y);

                int hline1Y = hline2Y / 2;
                e.Graphics.DrawLine(pen, 0, hline1Y, panel1.Width, hline1Y);

                int hline3Y = hline2Y + hline1Y;
                e.Graphics.DrawLine(pen, 0, hline3Y, panel1.Width, hline3Y);

                int vline2X = panel1.Width / 2;
                e.Graphics.DrawLine(pen, vline2X, 0, vline2X, panel1.Height);

                int vline1X = vline2X / 2;
                e.Graphics.DrawLine(pen, vline1X, 0, vline1X, panel1.Height);

                int vline3X = vline2X + vline1X;
                e.Graphics.DrawLine(pen, vline3X, 0, vline3X, panel1.Height);
            }
            if (isEdit && !editHide)
            {
                pen = new Pen(Color.FromArgb(0, 122, 204), 1.0f);
                //获取最大外边框
                rotateMaxRect = GetRotateRectangle(rect, rotate);
                e.Graphics.DrawRectangle(pen, rotateMaxRect);

                rectArray[0] = new Rectangle(rotateMaxRect.X + rotateMaxRect.Width - 4, rotateMaxRect.Y + rotateMaxRect.Height - 4, 7, 7);
                e.Graphics.FillRectangle(sizeRectColor, rectArray[0]);

                if (double.Parse(txtRotate.Text) != 0)
                {
                    e.Graphics.DrawString(rect.Width.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(0, 122, 204)), rotateMaxRect.X + (rotateMaxRect.Width / 2), rotateMaxRect.Y - 15);
                    e.Graphics.DrawString(rect.Height.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(0, 122, 204)), rotateMaxRect.X - 22, rotateMaxRect.Y + (rotateMaxRect.Height / 2));
                }
                else
                {
                    e.Graphics.DrawString(rect.Width.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(0, 122, 204)), rect.X + (rect.Width / 2), rect.Y - 15);
                    e.Graphics.DrawString(rect.Height.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(0, 122, 204)), rect.X - 22, rect.Y + (rect.Height / 2));
                }
            }
            e.Graphics.DrawString($"{rect}",new Font("Arial",8),new SolidBrush(Color.Red),new Point(0,0));
        }

        /// <summary>
        /// 截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCutPic_Click(Object sender, EventArgs e)
        {
            if (PrScrn() == 1)
            {
                if (Clipboard.ContainsImage())
                {
                    picScrn.Image = Clipboard.GetImage();
                }
            }
        }

        /// <summary>
        /// 画布大小改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmScrn_SizeChanged(Object sender, EventArgs e)
        {
            A4_FillImageModel();
        }

        /// <summary>
        /// 启用A4操作区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbA4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA4.Checked)
            {
                btnA4Fill.Enabled = true;
                btnA4LocationBottom.Enabled = true;
                btnA4LocationCenter.Enabled = true;
                btnA4LocationTop.Enabled = true;
                btnA4Zoom.Enabled = true;
            }
            else
            {
                btnA4Fill.Enabled = false;
                btnA4LocationBottom.Enabled = false;
                btnA4LocationCenter.Enabled = false;
                btnA4LocationTop.Enabled = false;
                btnA4Zoom.Enabled = false;
            }
            A4_FillImageModel();
        }

        /// <summary>
        /// 裁剪图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCut_Click(object sender, EventArgs e)
        {
            Point r = new Point();
            dashHide = true;
            editHide = true;
            a4Hide = true;
            picImage.Refresh();
            if (cbA4.Checked)
            {
                var a4 = GetA4Rectangle();
                Bitmap image = new Bitmap(a4.Width - 2, a4.Height - 2);
                Graphics imgGh = Graphics.FromImage(image);
                r.X = a4.X + 1;
                r.Y = a4.Y + 1;
                r = panel1.PointToScreen(r);
                imgGh.CopyFromScreen(r, new Point(0, 0), new Size(a4.Width - 2, a4.Height - 2));

                picScrn.Image = image;
                //Clipboard.SetImage(image);
            }
            else
            {
                Size cutSize = rect.Size;
                Point cutPoint = rect.Location;
                if ((cutPoint.Y + cutSize.Height) > panel1.Height)
                {
                    cutSize.Height = panel1.Height - rect.Y - 2;
                }
                if ((cutPoint.X + cutSize.Width) > panel1.Width)
                {
                    cutSize.Width = panel1.Width - rect.X - 2;
                }
                if (cutPoint.X < 0)
                {
                    cutSize.Width = cutSize.Width + cutPoint.X;
                    cutPoint.X = 0;
                }
                if (cutPoint.Y < 0)
                {
                    cutSize.Height = cutSize.Height + cutPoint.Y;
                    cutPoint.Y = 0;
                }
                if (double.Parse(txtRotate.Text) != 0)
                {
                    var maxRect = GetRotateRectangle(rect, (float)double.Parse(txtRotate.Text));
                    cutSize = maxRect.Size;
                    r = maxRect.Location;
                    cutPoint = maxRect.Location;
                }
                Bitmap image = new Bitmap(cutSize.Width, cutSize.Height);
                Graphics imgGh = Graphics.FromImage(image);
                r = panel1.PointToScreen(cutPoint);
                imgGh.CopyFromScreen(r, new Point(0, 0), cutSize);
                picScrn.Image = image;
            }
            a4Hide = false;
            dashHide = false;
            editHide = false;
            picImage.Refresh();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 图片大小跟所A4工作区大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbA4SizeFollow_CheckedChanged(object sender, EventArgs e)
        {
            A4_FillImageModel();
        }

        /// <summary>
        /// 图片位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnA4Location_Click(object sender, EventArgs e)

        {
            var button = (Button)sender;
            var name = button.Name;
            switch (name)
            {
                case "btnA4LocationTop":
                    img_location = 0;
                    break;
                case "btnA4LocationCenter":
                    img_location = 1;
                    break;
                case "btnA4LocationBottom":
                    img_location = 2;
                    break;
                default:
                    break;
            }
            ImageLocation();
        }

        /// <summary>
        /// 图片缩放模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnA4ImageStyleMode_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var name = button.Name;
            if (name == "btnA4Fill")
            {
                img_style_model = 0;
            }
            else if (name == "btnA4Zoom")
            {
                img_style_model = 1;
            }
            A4_FillImageModel();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 获取A4大小矩形
        /// </summary>
        /// <returns></returns>
        public Rectangle GetA4Rectangle()
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                float dpiX = graphics.DpiX;
                float dpiY = graphics.DpiY;

                int a4width = Convert.ToInt32((8.27 - 0.75 * 2) * dpiX);
                int a4height = Convert.ToInt32((11.69 - 0.75 * 2) * dpiY);

                int rectWidth = panel1.Width;
                int rectHeight = panel1.Height;


                var newRectLocation = new Point();

                var res = AutoSize(rectWidth, rectHeight, a4width, a4height);

                var midPoint = panel1.Width / 2;
                var rectMidPoint = (res["Width"] - 4) / 2;
                var localX = midPoint - rectMidPoint;
                Rectangle a4 = new Rectangle(localX, 1, res["Width"] - 4, res["Height"] - 4);
                //矩形四点坐标
                //var p1 = a4.Location;
                //var p2 = new Point(a4.X+a4.Width-3,a4.Y);
                //var p3 = new Point(a4.X,a4.Height-3);
                //var p4 = new Point(a4.X + a4.Width-3, a4.Height-3);
                return a4;
            }
        }

        /// <summary>
        /// 获取指定区域内最大同比矩形
        /// </summary>
        /// <param name="spcWidth"></param>
        /// <param name="spcHeight"></param>
        /// <param name="orgWidth"></param>
        /// <param name="orgHeight"></param>
        /// <returns></returns>
        public static Dictionary<string, int> AutoSize(int spcWidth, int spcHeight, int orgWidth, int orgHeight)
        {
            Dictionary<string, int> size = new Dictionary<string, int>();
            // 原始宽高在指定宽高范围内，不作任何处理 
            if (orgWidth <= spcWidth && orgHeight <= spcHeight)
            {
                size["Width"] = orgWidth;
                size["Height"] = orgHeight;
            }
            else
            {
                // 取得比例系数 
                float w = orgWidth / (float)spcWidth;
                float h = orgHeight / (float)spcHeight;
                // 宽度比大于高度比 
                if (w > h)
                {
                    size["Width"] = spcWidth;
                    size["Height"] = (int)(w >= 1 ? Math.Round(orgHeight / w) : Math.Round(orgHeight * w));
                }
                // 宽度比小于高度比 
                else if (w < h)
                {
                    size["Height"] = spcHeight;
                    size["Width"] = (int)(h >= 1 ? Math.Round(orgWidth / h) : Math.Round(orgWidth * h));
                }
                // 宽度比等于高度比 
                else
                {
                    size["Width"] = spcWidth;
                    size["Height"] = spcHeight;
                }
            }
            return size;
        }

        /// <summary>
        /// 以逆时针为方向对图像进行旋转
        /// </summary>
        /// <param name="b">位图流</param>
        /// <param name="angle">旋转角度[0,360](前台给的)</param>
        /// <returns></returns>
        public void RoatetImage(Image image, Graphics g, Rectangle r, float angle)
        {
            using (Matrix m = new Matrix())
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawImage(image, r);
                g.ResetTransform();
            }
        }

        /// <summary>
        /// 将图片填充至指定大小矩形内
        /// </summary>
        private void A4_FillImage2Rect()
        {
            if (src_image == null) return;
            var a4Rect = GetA4Rectangle();
            var res = AutoSize(a4Rect.Width, a4Rect.Height, src_image.Width, src_image.Height);
            rect = new Rectangle(a4Rect.X + 2, a4Rect.Y + 2, res["Width"] - 4, res["Height"] - 4);
            width = rect.Width;
            height = rect.Height;
        }

        /// <summary>
        /// 图片缩放模式
        /// </summary>
        private void A4_FillImageModel()
        {
            if (cbA4.Checked && cbA4SizeFollow.Checked)
                A4_FillImage2Rect();
            else
                img_location = 1;
            ImageLocation();
            ImageStyleModel();
            picImage.Invalidate();
        }

        /// <summary>
        /// 旋转矩形
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="angle"></param>
        public void RotateRectangle(Graphics g, Rectangle r, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawRectangle(new Pen(Color.Red, 1.0F), r);
                g.ResetTransform();
            }
        }


        public Rectangle GetRotateRectangle(Rectangle rect, float angle)
        {
            double radian = angle * Math.PI / 180;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //只需要考虑到第四象限和第三象限的情况取大值(中间用绝对值就可以包括第一和第二象限)
            int newWidth = (int)(Math.Max(Math.Abs(rect.Width * cos - rect.Height * sin), Math.Abs(rect.Width * cos + rect.Height * sin)));
            int newHeight = (int)(Math.Max(Math.Abs(rect.Width * sin - rect.Height * cos), Math.Abs(rect.Width * sin + rect.Height * cos)));
            int rectX = rect.X + (rect.Width / 2) - (rotateMaxRect.Width / 2);
            int rectY = rect.Y + (rect.Height / 2) - (rotateMaxRect.Height / 2);
            return new Rectangle(rectX, rectY, newWidth, newHeight);
        }

        /// <summary>
        /// 缩放模式
        /// </summary>
        private void ImageStyleModel()
        {
            switch (img_style_model)
            {
                case 0:
                    var a4 = GetA4Rectangle();
                    width = a4.Width;
                    height = a4.Height;
                    rect.Location = new Point((picImage.Width / 2) - (width / 2) - 1, 3);
                    ImageLocation();
                    break;
                case 1:
                    if (rect == null) break;
                    width = rect.Width;
                    height = rect.Height;
                    break;
                default:
                    break;
            }
        }

        private void btnImgSave_Click(object sender, EventArgs e)
        {
            if (picScrn.Image == null) return;
            SaveFileDialog fsd = new SaveFileDialog();
            fsd.FileName = "图片_" + DateTime.Now.ToString("yyyy-MM-HH hh-mm-ss");
            fsd.DefaultExt = ".jpg";
            fsd.Filter = "*.jpg|jpg";
            if (fsd.ShowDialog() == DialogResult.OK)
            {
                string name = fsd.FileName;
                picScrn.Image.Save(name);
            }
        }

        private void btntest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A4Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                A4Color.BackColor = colorChoosed;
            }
            picImage.Invalidate();
        }

        private void DashColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                DashColor.BackColor = colorChoosed;
            }
            picImage.Invalidate();
        }

        private void txtRotate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal result;
                if (decimal.TryParse(txtRotate.Text, out result))
                {
                    double rotate = (double)decimal.Parse(txtRotate.Text);
                    double temp = rotate * 10.0;
                    if (temp > 1800 || temp < -1800)
                    {
                        tbRotate.Value = 0;
                    }
                    else
                    {
                        tbRotate.Value = (int)temp;
                    }
                }
                return;
            }
            if (Char.IsDigit(e.KeyChar) || (int)e.KeyChar == 46 || (int)e.KeyChar == 8 || (int)e.KeyChar == 45)
            {
                return;
            }
            e.Handled = true;
        }

        private void cbDash_CheckedChanged(object sender, EventArgs e)
        {
            picImage.Invalidate();
        }

        private void FrmTool_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 图片定位
        /// </summary>
        private void ImageLocation()
        {
            if (img_style_model == 0) return;
            switch (img_location)
            {
                case 0:
                    rect.Location = new Point((picImage.Width / 2) - (width / 2) - 1, 3);
                    break;
                case 1:
                    rect.Location = new Point((picImage.Width / 2) - (width / 2) - 1, (picImage.Height / 2) - (height / 2) + 3);
                    break;
                case 2:
                    rect.Location = new Point((picImage.Width / 2) - (width / 2) - 1, picImage.Height - height - 5);
                    break;
                default:
                    break;
            }
            picImage.Invalidate();
        }
        #endregion
    }
}
