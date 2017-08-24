using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paway.Windows.Forms;

namespace Paway.Windows.Test
{
    public partial class Form2 : QQForm
    {
        public Form2()
        {
            InitializeComponent();
            NotifyForm.AnimalShow("消息提示", "“末日”前晒出流逝的岁月，上传一组证明您岁月痕迹的新老对比照片，即可获得抽奖资格和微博积分");
            this.contextMenuStrip1.Renderer = new QQToolStripRenderer();
        }

        private void qqButton1_Click(object sender, EventArgs e)
        {
            using (Form1 form = new Form1())
            {
                form.ShowDialog();
            }
        }
    }
}
