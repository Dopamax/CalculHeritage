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
    public partial class Form_Principale : Form
    {
        public Form_Principale()
        {
            InitializeComponent();
            question1CU1.BringToFront();
            btn_precedant.Enabled = false;
        }
        int pos = 0;
        Partition p = new Partition();
  
        string usercontrol_genre="";
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
                            usercontrol_genre = "H";
                            donneeHommeUC1.BringToFront();
                            btn_precedant.Enabled = true;
                            btn_Suivant.Enabled = true;
                            break;
                        }
                        else if (question1CU1.rdbtn_Femme.Checked)
                        {
                            usercontrol_genre = "F";
                            donneeFemmeUC1.BringToFront();
                            btn_precedant.Enabled = true;
                            btn_Suivant.Enabled = true;
                            break;

                        }
                        break;
                    }
                case 2:
                    {
                        if (usercontrol_genre=="H")
                        {
                            if (VerificationRemplissage(donneeHommeUC1))
                            {
                                affichageFinalUC1.BringToFront();
                                Affichage_Final();
                                btn_precedant.Enabled = true;
                                btn_Suivant.Enabled = false;
                                
                            }
                            else
                            {
                                MessageBox.Show("Veuillez Verifier le remplissage de tous les champs !");
                                usercontrol_genre = "";
                                --pos;
                                
                            }
                            
                        }
                        else if (usercontrol_genre=="F")
                        {
                            if (VerificationRemplissage(donneeFemmeUC1))
                            {
                                affichageFinalUC1.BringToFront();
                                Affichage_Final();
                                btn_precedant.Enabled = true;
                                btn_Suivant.Enabled = false;
                                

                            }
                            else
                            {
                                MessageBox.Show("Veuillez Verifier le remplissage de tous les champs !");
                                usercontrol_genre = "";
                                --pos;
                            }

                        }

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
        public bool VerificationRemplissage(UserControl uc)
        {
            bool verification_rdbtn = false;
            bool verification_txt = false;

            foreach (Control item_grb in uc.Controls)
            {
                if (item_grb is GroupBox  )
                {
                    foreach (RadioButton item_rdbtn in item_grb.Controls)
                    {
                        if (item_rdbtn.Checked)
                        {
                            verification_rdbtn = true;
                            break;
                        }

                    }
                    if (!verification_rdbtn)
                    {
                        //MessageBox.Show("Test");
                        return false;
                    }
                }
               /* else
                {
                    MessageBox.Show("is not a group");
                }
                */
                    
            }

            foreach (Control c in uc.Controls )
            {
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    if (c.Text != null)
                    {
                        verification_txt = true;
                    }
                    else
                    {
                        verification_txt = false;
                    }
                }               
            }
            return verification_txt && verification_rdbtn;
        }

        public bool VerifierVivant(RadioButton rd_oui,RadioButton rd_non)
        {
            bool vivant = true;
            if (rd_oui.Checked)
            {
                vivant = true;
            }
            else
            {
                vivant = false;
            }
            return vivant;
        }

        public void Affichage_Final()
        {
            if (question1CU1.rdbtn_Homme.Checked)
            {
                
                //Partition
                affichageFinalUC1.lbl_fils_part.Text = p.Partition_fils(int.Parse(donneeHommeUC1.txt_nombrefils.Text));
                affichageFinalUC1.lbl_filles_part.Text = p.Partition_filles(int.Parse(donneeHommeUC1.txt_nombrefille.Text));
                affichageFinalUC1.lbl_frere_part.Text = p.Partition_Frere(int.Parse(donneeHommeUC1.txt_nombrefreres.Text));
                affichageFinalUC1.lbl_soeurs_part.Text = p.Partition_Soeurs(int.Parse(donneeHommeUC1.txt_nombreSoeurs.Text));
                affichageFinalUC1.lbl_pere_part.Text = p.Partition_Pere(VerifierVivant(donneeHommeUC1.rdbtn_p_oui,donneeHommeUC1.rdbtn_p_non));
                affichageFinalUC1.lbl_mere_part.Text = p.Partition_Mere(VerifierVivant(donneeHommeUC1.rdbtn_m_oui, donneeHommeUC1.rdbtn_m_non));
                affichageFinalUC1.lbl_epouses_part.Text = p.Partition_Epouses(int.Parse(donneeHommeUC1.txt_nombrepouse.Text));
                affichageFinalUC1.lbl_grand_pere_part.Text = p.Partition_Grandpere(VerifierVivant(donneeHommeUC1.rdbtn_gp_oui,donneeHommeUC1.rdbtn_gp_non));
                affichageFinalUC1.lbl_grande_mere_m.Text = p.Partition_GrandeMere_matern(VerifierVivant(donneeHommeUC1.rdbtn_gm_m_oui,donneeHommeUC1.rdbtn_gm_m_non));
                affichageFinalUC1.lbl_grandmere_p_part.Text = p.Partition_GrandeMere_patern(VerifierVivant(donneeHommeUC1.rdbtn_gm_paternelle_oui,donneeHommeUC1.rdbtn_gm_paternelle_non));
                affichageFinalUC1.lbl_epouse_ou_marie.Text = "Epouse(s)";

                affichageFinalUC1.lbl_numero_matiere.Text = p.OrigineDeLaMAtiere();
            }
            else if (question1CU1.rdbtn_Femme.Checked)
            {
                //Partition
                affichageFinalUC1.lbl_fils_part.Text = p.Partition_fils(int.Parse(donneeFemmeUC1.txt_nombrefils.Text));
                affichageFinalUC1.lbl_filles_part.Text = p.Partition_filles(int.Parse(donneeFemmeUC1.txt_nombrefille.Text));
                affichageFinalUC1.lbl_frere_part.Text = p.Partition_Frere(int.Parse(donneeFemmeUC1.txt_nombrefreres.Text));
                affichageFinalUC1.lbl_soeurs_part.Text = p.Partition_Soeurs(int.Parse(donneeFemmeUC1.txt_nombreSoeurs.Text));
                affichageFinalUC1.lbl_pere_part.Text = p.Partition_Pere(VerifierVivant(donneeFemmeUC1.rdbtn_p_oui, donneeFemmeUC1.rdbtn_p_non));
                affichageFinalUC1.lbl_mere_part.Text = p.Partition_Mere(VerifierVivant(donneeFemmeUC1.rdbtn_m_oui, donneeFemmeUC1.rdbtn_m_non));
                affichageFinalUC1.lbl_grand_pere_part.Text = p.Partition_Grandpere(VerifierVivant(donneeFemmeUC1.rdbtn_gp_oui, donneeHommeUC1.rdbtn_gp_non));
                affichageFinalUC1.lbl_grande_mere_m.Text = p.Partition_GrandeMere_matern(VerifierVivant(donneeFemmeUC1.rdbtn_gm_m_oui, donneeFemmeUC1.rdbtn_gm_m_non));
                affichageFinalUC1.lbl_grandmere_p_part.Text = p.Partition_GrandeMere_patern(VerifierVivant(donneeFemmeUC1.rdbtn_gm_paternelle_oui, donneeFemmeUC1.rdbtn_gm_paternelle_non));
                affichageFinalUC1.lbl_epouse_ou_marie.Text = "Marie";

                affichageFinalUC1.lbl_numero_matiere.Text = p.OrigineDeLaMAtiere();
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
