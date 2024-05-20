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
    public partial class List_Angsuran : Form
    {
        public List_Angsuran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori_Angsuran form=new Kategori_Angsuran();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tambah_Angsuran form = new Tambah_Angsuran();
            form.ShowDialog();
        }
    }
}
