using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dersane1
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrEkle formogr = new frmOgrEkle();
            formogr.Show();
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
