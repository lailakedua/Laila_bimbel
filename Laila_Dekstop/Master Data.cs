﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laila_Dekstop
{
    public partial class master_data : Form
    {
        public master_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Admin form=new Data_Admin();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Guru form=new Data_Guru();
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_Siswa form=new Data_Siswa();
            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Master_Data_Kelas form=new Master_Data_Kelas();
            form.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data_Paket_Bimbel form=new Data_Paket_Bimbel();
            form.ShowDialog();

        }
    }
}
