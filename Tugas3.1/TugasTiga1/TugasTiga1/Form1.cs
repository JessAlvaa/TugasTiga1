using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmTugasTiga1 : Form
    {
        public frmTugasTiga1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM       : 22.11.5135 ";
            lblNama.Text = "Nama    : Jessica Alva N ";
            lblKelas.Text = "Kelas     : 22 IF 10 ";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM       :  ";
            lblNama.Text = "Nama    : ";
            lblKelas.Text = "Kelas     :  ";
        }
    }
}
