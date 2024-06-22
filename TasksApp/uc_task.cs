using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApp
{
    public partial class uc_task : UserControl
    {
        public uc_task()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.bunifuPanel1.BackgroundColor = Color.FromArgb(63, 164, 122);
            this.lbdate.BackColor= Color.FromArgb(63, 164, 122);
            this.lbname.BackColor = Color.FromArgb(63, 164, 122);
            this.lbDesrioc.BackColor = Color.FromArgb(63, 164, 122);
            this.lbdate.ForeColor = Color.White;
            this.lbname.ForeColor = Color.White;
            this.lbDesrioc.ForeColor = Color.White;
        }
    }
}
