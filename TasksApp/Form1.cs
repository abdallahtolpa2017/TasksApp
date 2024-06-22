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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0; i<2; i++) 
            {
                uc_task Task = new uc_task();
                flowLayoutPanel1.Controls.Add(Task);
                //flowLayoutPanel1.Controls.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pltask.Height == 102)
            {
                pltask.Height = 220;
            }
            else { pltask.Height = 102; }
        }

        public void clear() 
        {
            txtName.Clear();
            txtDatiels.Clear();
            
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            uc_task task = new uc_task();
            task.lbname.Text =txtName.Text;
            task.lbDesrioc.Text=txtDatiels.Text;
            task.lbdate.Text=dateTask.Value.ToString("dd-MM-yyyy");
            flowLayoutPanel1.Controls.Add(task);
            clear();


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            pltask.Height = 102;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
