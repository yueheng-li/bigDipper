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
    public partial class FrmSearch : Form
    {
        // 登录用户名
        public string username;
        List<Students> students;
        Teachers t;

        public FrmSearch(string username)
        {
            // 保存登录用户名
            this.username = username;
            InitializeComponent();
        }
   
        public FrmSearch(string id, string name)
        {
            // 保存登录用户名
            this.t = new Teachers(id, name, "");
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string idCard = this.idCard.Text;
            
            StringBuilder sql = new StringBuilder();
            sql.Append(" select ");
            sql.Append(" sd.students_id as id ");
            sql.Append(" ,sd.student_name as name ");
            sql.Append(" ,sd.class_id as classId ");
            sql.Append(" ,mc.class_name as className ");
            sql.Append(" ,case when sd.accommodation_flg =0 then '是' else '否' end as flg ");
            sql.Append(" from students sd, m_classes mc ");
            sql.Append(" where sd.class_id = mc.class_id ");
            sql.Append(" and sd.students_id like '%");
            sql.Append(idCard);
            sql.Append("%';");

            Db conn = new Db();
            SQLiteDataReader dane = conn.comSelect(sql.ToString());
            students = new List<Students>();
            while (dane.Read())
            {
                string id = dane["id"].ToString();
                string name = dane["name"].ToString();
                string classId = dane["classId"].ToString();
                string className = dane["className"].ToString();
                string flg = dane["flg"].ToString();
                Students s = new Students(id, name, classId, className, flg);
                students.Add(s);
            }
            dane.Close();

            if (this.students != null && this.students.Count > 0)
            {
                //FrmSearch frmSearch = new FrmSearch();
                //this.Hide();
                //frmSearch.Show();
                //this.DialogResult = DialogResult.OK;
                //this.Close();

            }

            //dane.commend("INSERT INTO slowka (SlowkoPL, SlowkoEn, PunktyTlumaczenieNaPL, PunktyTlumaczenieNaEN, OpisPL, OpisEN) VALUES ('" + this.textBox_pds_p8.Text + "', '" + this.textBox_pds_a8.Text + "',0,0,'" + this.textBox_pds_pp8.Text + "','" + this.textBox_pds_aa8.Text + "');");
            /*
             INSERT INTO students (
                         students_id,
                         student_name,
                         class_id,
                         accommodation_flg,
                         create_user,
                         create_dt,
                         update_user,
                         update_dt
                     )
                     VALUES (
                         'students_id',
                         'student_name',
                         'class_id',
                         'accommodation_flg',
                         'create_user',
                         'create_dt',
                         'update_user',
                         'update_dt'
                     );
             * */
            //SearchResult result = new SearchResult();
            //this.Close();
            //result.Show();
        }
    }
}
