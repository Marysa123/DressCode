using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DressCode.forms
{
    public partial class DressAccounting : Form
    {
        public DressAccounting()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=109.233.236.26;Initial Catalog=DressCode;User ID=stud;Password = 123456789;Encrypt=False");
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DressAccounting_Load(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (ID_tb.Text == "" || Count_tb.Text == "" || brend_box.Text.ToString() == "" || Size_tb.Text == "" || Price_tb.Text == "" || Quality_tb.Text == "" || Category_box.Text == "")
            {
                MessageBox.Show("Информация введена некорректно!");

            }
            else
            {
                try
                {
                    conn.Open();
                    String sql = "insert into ScladDress () values";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}
