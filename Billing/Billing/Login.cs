using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Billing
{
    public partial class FrmLogin : Form
    {
        public string username;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dateBussiness.Value = DateTime.Now.AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //FrmSearch frmSearch = new FrmSearch();
            //this.Hide();
            //frmSearch.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
