using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
{
    public partial class Pendu : Form
    {
        public Pendu()
        {
            InitializeComponent();
        }

        private void remplirCombo()
        {
            // vide le combo
            cboLettre.Items.Clear();
            // remplit le combo avec les lettres de l'alphabet
            for (int i = 0; i < 26; i++)
            {
                cboLettre.Items.Add((char)('A' + i));
            }
            // met le choix par défaut à A
            cboLettre.SelectedIndex = 0;
        }

        private void saisieMot()
        {
            if (txtMot.Text.Length > 14)
            {

            }
        }

        private void Pendu_Load(object sender, EventArgs e)
        {
            remplirCombo();
        }
    }
}
