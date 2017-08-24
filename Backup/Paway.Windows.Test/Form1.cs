using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paway.Windows.Forms;
using Paway.Windows.Forms.Metro;
using Paway.Windows.Helper;
//Download by http://www.codefans.net
namespace Paway.Windows.Test
{
    public partial class Form1 : _360Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolBar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("下标改变了，当前下标为：" + this.toolBar1.SelectedIndex);
        }

        private void toolBar1_SelectedItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show("项发生改变了，当前项为：" + this.toolBar1.SelectedItem);
        }
    }
}
