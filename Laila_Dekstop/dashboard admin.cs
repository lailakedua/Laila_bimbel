using System;
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
    public partial class dashboard_admin : Form
    {
        public dashboard_admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            master_data formPanggil=new master_data();
            formPanggil.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jadwal_Pelajaran form= new Jadwal_Pelajaran();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Dasboard_siswa form= new Dasboard_siswa();
            form.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List_Angsuran form = new List_Angsuran();
            form.Show();

        }
    }
}
