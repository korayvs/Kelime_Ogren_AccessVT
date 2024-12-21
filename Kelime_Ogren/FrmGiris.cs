using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ogren
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            if (TxtKisiAd.Text != null)
            {
                fr.kisiad = TxtKisiAd.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Adınızı Giriniz!");
            }
        }
    }
}
