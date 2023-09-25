using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrediKartiMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBankamatik_Click(object sender, EventArgs e)
        {
            BankamatikKarti bankamatik = new BankamatikKarti(); 
        }

        private void mnuKKPlatinium_Click(object sender, EventArgs e)
        {
            KrediKartiPlatinium platinium = new KrediKartiPlatinium();
        }

        private void mnuKKGold_Click(object sender, EventArgs e)
        {
            KrediKartiGold gold = new KrediKartiGold(); 
        }

        private void mnuKKSilver_Click(object sender, EventArgs e)
        {
            KrediKartiSilver silver = new KrediKartiSilver();
        }
    }
}
