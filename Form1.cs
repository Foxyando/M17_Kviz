using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17_Kviz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int pocetSpravneZodpovezenych = 0;

            DialogResult otazkaJedna = MessageBox.Show("1+1=3", "Otázka 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult otazkaDva = MessageBox.Show("1+2=3", "Otázka 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (otazkaJedna)
            {
                case DialogResult.No:
                    pocetSpravneZodpovezenych++;
                    break;
            }
            switch (otazkaDva)
            {
                case DialogResult.Yes:
                    pocetSpravneZodpovezenych++;
                    break;
            }

            MessageBox.Show("Odpověděl jsi správně " + pocetSpravneZodpovezenych + " ze 2 otázek", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
