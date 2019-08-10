using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculHeritage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            question1CU1.BringToFront();
            btn_precedant.Enabled = false;
        }
        int pos = 0;
        int fils = 0, filles = 0, pere = 0, mere = 0, seour = 0, frere = 0, gpere = 0, gmerep = 0, gmerem = 0, epousse = 0, marie = 0;
        int Mfils = 0, Mfilles = 0, Mpere = 0, Mmere = 0, Mseour = 0, Mfrere = 0, Mgpere = 0, Mgmerep = 0, Mgmerem = 0, Mepousse = 0, Mmarie = 0;

        public void Navigation(int pos)
        {
            switch (pos)
            {
                case 0:
                    {
                        question1CU1.BringToFront();
                        btn_precedant.Enabled = false;
                        btn_Suivant.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        if (question1CU1.rdbtn_Homme.Checked)
                        {
                            donneeHommeUC1.BringToFront();
                            btn_precedant.Enabled = true;
                            btn_Suivant.Enabled = true;
                            break;
                        }
                        else
                        {
                            donneeFemmeUC1.BringToFront();
                            btn_precedant.Enabled = true;
                            btn_Suivant.Enabled = true;
                            break;

                        }
                       
                    }
                case 2:
                    {
                        affichageFinalUC1.BringToFront();
                        btn_precedant.Enabled = true;
                        btn_Suivant.Enabled = false;
                        break;
                    }

            }
        }

        private void btn_Suivant_Click(object sender, EventArgs e)
        {
            if (pos<2) {Navigation(++pos); }
            
        }

        private void btn_precedant_Click(object sender, EventArgs e)
        {
            if (pos>0)
            {
                Navigation(--pos);
            }
        }

        public void Affichage_Final()
        {

        }
    }
}
