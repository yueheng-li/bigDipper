﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Billing
{
    public partial class FrmSearch : Form
    {
        // 登录用户名
        public string username;

        public FrmSearch(string username)
        {
            // 保存登录用户名
            this.username = username;
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
            //SearchResult result = new SearchResult();
            //this.Close();
            //result.Show();
        }
    }
}
