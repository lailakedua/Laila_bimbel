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
    public partial class Dasboard_siswa : Form
    {
        public Dasboard_siswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Histori_Angsuran form = new Histori_Angsuran();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Jadwal_Pelajaran_2 form= new Jadwal_Pelajaran_2();
            form.ShowDialog();


        }

        private void Dasboard_siswa_Load(object sender, EventArgs e)
        {

        }
    }
}
