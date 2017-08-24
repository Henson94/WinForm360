namespace Paway.Windows.Test
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Paway.Windows.Forms.ToolItem toolItem1 = new Paway.Windows.Forms.ToolItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Paway.Windows.Forms.ToolItem toolItem2 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem3 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem4 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem5 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem6 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem7 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem8 = new Paway.Windows.Forms.ToolItem();
            Paway.Windows.Forms.ToolItem toolItem9 = new Paway.Windows.Forms.ToolItem();
            this.toolBar1 = new Paway.Windows.Forms.ToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.Transparent;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            toolItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolItem1.Image")));
            toolItem1.Tag = null;
            toolItem1.Text = "电脑体检";
            toolItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolItem2.Image")));
            toolItem2.Tag = null;
            toolItem2.Text = "木马查杀";
            toolItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolItem3.Image")));
            toolItem3.Tag = null;
            toolItem3.Text = "漏洞修复";
            toolItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolItem4.Image")));
            toolItem4.Tag = null;
            toolItem4.Text = "系统修复";
            toolItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolItem5.Image")));
            toolItem5.Tag = null;
            toolItem5.Text = "电脑清理";
            toolItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolItem6.Image")));
            toolItem6.Tag = null;
            toolItem6.Text = "优化加速";
            toolItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolItem7.Image")));
            toolItem7.Tag = null;
            toolItem7.Text = "电脑门诊";
            toolItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolItem8.Image")));
            toolItem8.Tag = null;
            toolItem8.Text = "软件管家";
            toolItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolItem9.Image")));
            toolItem9.Tag = null;
            toolItem9.Text = "功能大全";
            this.toolBar1.Items.Add(toolItem1);
            this.toolBar1.Items.Add(toolItem2);
            this.toolBar1.Items.Add(toolItem3);
            this.toolBar1.Items.Add(toolItem4);
            this.toolBar1.Items.Add(toolItem5);
            this.toolBar1.Items.Add(toolItem6);
            this.toolBar1.Items.Add(toolItem7);
            this.toolBar1.Items.Add(toolItem8);
            this.toolBar1.Items.Add(toolItem9);
            this.toolBar1.ItemSpace = 0;
            this.toolBar1.Location = new System.Drawing.Point(3, 26);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(844, 82);
            this.toolBar1.TabIndex = 0;
            this.toolBar1.Text = "toolBar1";
            this.toolBar1.SelectedItemChanged += new System.EventHandler(this.toolBar1_SelectedItemChanged);
            this.toolBar1.SelectedIndexChanged += new System.EventHandler(this.toolBar1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(698, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 67);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 380);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolBar1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsResize = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 26, 3, 26);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "360安全卫士 8.7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Paway.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;










    }
}

