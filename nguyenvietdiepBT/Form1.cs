﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenvietdiepBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int tong = 0, tongchan = 0, tongle = 0;

        private void txtNhap_MouseEnter(object sender, EventArgs e)
        {
            txtNhap.SelectAll();
        }

        private void txtNhap_MouseClick(object sender, MouseEventArgs e)
        {
            txtNhap.SelectAll();
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtDaySo.Text = txtDaySo.Text + txtNhap.Text + ",";

            int iNhap = Convert.ToInt32(txtNhap.Text);
            tong = tong + iNhap;
            txtTong.Text = tong.ToString();
            if (iNhap % 2 == 0)
            {

                tongchan = tongchan + iNhap;

            }
            else
            {
                tongle = tongle + iNhap;
            }
            txtTongchan.Text = tongchan.ToString();
            txtTongle.Text = tongle.ToString();
        }
    }
}
