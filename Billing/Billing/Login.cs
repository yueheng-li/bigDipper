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
        public string userId;
        public string username;
        Db Baza;

        public FrmLogin()
        {
            this.Baza = new Db();
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
            string id = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM teachers where 1=1 ");
            sql.Append(" AND teacher_id='");
            sql.Append(id);
            sql.Append("' AND teacher_pw='");
            sql.Append(pwd);
            sql.Append("';");
            SQLiteDataReader dane = this.Baza.comSelect(sql.ToString());
            Teachers teacher = null;
            while (dane.Read())
            {
                string teacherId = dane["teacher_id"].ToString();
                string teacherName = dane["teacher_name"].ToString();
                string password = dane["teacher_pw"].ToString();
                Console.WriteLine("teacherId: {0}", teacherId);
                teacher = new Teachers(teacherId, teacherName, password);
            }
            dane.Close();

            if (teacher != null)
            {
                this.userId = teacher.teacherId;
                this.username = teacher.teacherName;
                //FrmSearch frmSearch = new FrmSearch();
                //this.Hide();
                //frmSearch.Show();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            //FrmSearch frmSearch = new FrmSearch();
            //this.Hide();
            //frmSearch.Show();
            //this.DialogResult = DialogResult.OK;
            //this.Close();

        }
        
    }
}
