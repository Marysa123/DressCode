using DressCode.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressCode
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            WProgressBar.Value = startpoint;
            DProgressBar.Value = startpoint;
            if (DProgressBar.Value == 100) { 
            WProgressBar.Value = 0;
                DProgressBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
