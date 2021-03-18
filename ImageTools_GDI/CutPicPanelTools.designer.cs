
namespace ImageTools_GDI.control
{
    partial class CutPicPanelTools
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCenter
            // 
            this.btnCenter.BackgroundImage = global::ImageTools_GDI.Properties.Resources.叉号;
            this.btnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCenter.FlatAppearance.BorderSize = 0;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCenter.Location = new System.Drawing.Point(7, 5);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(20, 20);
            this.btnCenter.TabIndex = 0;
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::ImageTools_GDI.Properties.Resources.对号;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(40, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(25, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CutPicPanelTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCenter);
            this.Name = "CutPicPanelTools";
            this.Size = new System.Drawing.Size(72, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnOk;
    }
}
