using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Signup
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grAcc_Enter(object sender, EventArgs e)
        {

        }

        private void cbbChangeConnect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ItemList c = new ItemList();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }
    }
}
