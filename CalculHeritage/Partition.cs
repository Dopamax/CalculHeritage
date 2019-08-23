using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculHeritage
{
    public class Partition
    {
        /// <summary>
        /// we need somme variables 
        /// </summary>
        /// 
        
        int fils = 0, filles = 0, pere = 0, mere = 0, soeur = 0, frere = 0, gpere = 0, gmerep = 0, gmerem = 0, epousse = 0, marie = 0;
        int Mfils = 0, Mfilles = 0, Mpere = 0, Mmere = 0, Msoeur = 0, Mfrere = 0, Mgpere = 0, Mgmerep = 0, Mgmerem = 0, Mepousse = 0, Mmarie = 0;
        List<int> menbres = new List<int>();
        int LCM=0;
        public Partition()
        {
            
        }

        public int lcm(List<int> t, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (t[i] == 0) t[i] = 1;
            }
            int[] initialArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                initialArray[i] = t[i];
            }
            int index, m, x, b = 1;
            while (b == 1)
            {
                b = 0;
                x = t[0];
                m = t[0];
                index = 0;
                for (int i = 0; i < n; i++)
                {
                    if (x != t[i])
                    {
                        b = 1;
                    }
                    if (m > t[i])
                    {
                        m = t[i];
                        index = i;
                    }
                }
                if (b == 1)
                {
                    t[index] = t[index] + initialArray[index];
                }
            }
            return t[0];
        }

        public string Partition_fils(int nombre)
        {
            string partition = null;
            fils = nombre;
            
            if (nombre>0)
            {
                partition= "R";
                membres.Add(fils);
            }
            return partition;
        }
        public string Partition_filles(int nombre)
        {
            string partition = null;
            filles = nombre;
            
            if (nombre==1 && fils>0)
            {
                partition= "RF";
                membres.Add(filles);
            }
            else if (nombre==1 && fils==0)
            {
                partition= "1/2";
                Mfilles = 2;
                membres.Add(filles);
                m.Add(Mfilles);
            }
            else if (nombre>1 && fils>=0)
            {
                partition= "2/3";
                Mfilles = 3;
                membres.Add(filles);
                m.Add(Mfilles);
            }
            return partition;
        }

        public string Partition_Pere(bool vivant)
        {
            string partition = null;
            pere = Convert.ToInt16(vivant);
           
            if (vivant)
            {
                if (fils>0)
                {
                    partition = "1/6";
                    Mpere = 6;
                    membres.Add(pere);
                    m.Add(Mpere);
                }
                else if (filles>0)
                {
                    partition = "1/6+R";
                    Mpere=6;
                    membres.Add(pere);
                    m.Add(Mpere);
                }
                else
                {
                    partition = "R";
                    membres.Add(pere);
                }
            }
            return partition;
        }
        public string Partition_Mere(bool vivante)
        {
            string partition = null;
            
            if (vivante)
            {
                if (fils > 0 || filles>0)
                {
                    partition = "1/6";
                    Mmere = 6;
                    membres.Add(mere);
                    m.Add(Mmere);
                }
                else
                {
                    partition = "1/3";
                    Mmere = 3;
                    membres.Add(mere);
                    m.Add(Mmere);
                }
            }
            return partition;
        }
        public string Partition_Grandpere(bool vivante)
        {
            string partition = null;
            gpere = Convert.ToInt16(vivante);
           
            if (vivante)
            {
                if ( (fils>0 || filles>0 || soeur>0) && pere==0)
                {
                    partition = "1/6";
                    Mgpere = 6;
                    membres.Add(gpere);
                    m.Add(Mgpere);
                }
                else if (pere==0)
                {
                    partition = "R";
                    membres.Add(gpere);
                }
            }
            return partition;
        }
        public string Partition_GrandeMere_matern(bool vivante)
        {
            string partition = null;
            gmerem= Convert.ToInt16(vivante);
           
            if (vivante)
            {
                if (mere==0)
                {
                    partition = "1/6";
                    Mgmerem = 6;
                    membres.Add(gmerem);
                    m.Add(Mgmerem);
                }
            }
            return partition;
        }

        public string Partition_GrandeMere_patern(bool vivante)
        {
            string partition = null;
            gmerep= Convert.ToInt16(vivante);
            
            if (vivante)
            {
                if (mere==0 && pere==0)
                {
                    partition = "1/6";
                    Mgmerep = 6;
                    membres.Add(gmerep);
                    m.Add(Mgmerep);
                }
            }
            return partition;
        }
        public string Partition_Frere(int nombre)
        {
            string partition = null;
            frere = nombre;
            
            if (nombre>0)
            {
                if (fils==0 && filles==0 && pere==0 && gpere==0)
                {
                    partition = "R";
                    membres.Add(frere);
                }
            }
            return partition;
        }
        public string Partition_Soeurs(int nombre)
        {
            string partition = null;
            soeur = nombre;
           
            if (nombre ==1)
            {
                if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere == 0)
                {
                    partition ="1/2";
                    Msoeur = 2;
                    membres.Add(soeur);
                    m.Add(Msoeur);
                }
            }
            else if (nombre > 1)
            {
                if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere == 0)
                {
                    partition = "2/3";
                    Msoeur = 3;
                    membres.Add(soeur);
                    m.Add(Msoeur);
                }
                else if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere > 0)
                {
                    partition = "RF";
                    membres.Add(soeur);
                }
            }
            return partition;
        }
        public string Partition_Marie(bool vivante)
        {
            string partition = null;
            marie = Convert.ToInt16(vivante);
       
            if (vivante)
            {
                if (fils>0 || filles>0)
                {
                    partition = "1/4";
                    Mmarie = 4;
                    membres.Add(marie);
                    m.Add(Mmarie);
                }
                else
                {
                    partition = "1/2";
                    Mmarie = 2;
                    membres.Add(marie);
                    m.Add(Mmarie);
                }
            }
            return partition;
        }
        public string Partition_Epouses(int nombre)
        {
            string partition = null;
            epousse = nombre;
          
            if (nombre>0)
            {
                if (fils>0 || filles>0)
                {
                    partition = "1/8";
                    Mepousse = 8;
                    membres.Add(epousse);
                    m.Add(Mepousse);
                }
                else
                {
                    partition = "1/4";
                    Mepousse = 4;
                    membres.Add(epousse);
                    m.Add(Mepousse);
                }
            }
            return partition;
        }

        public string OrigineDeLaMAtiere()
        {
            LCM = lcm(m, m.Count);
            string numero_matiere = LCM.ToString();

            //ici votre code
            
            return numero_matiere;
        }
        void hello()
        {
            bool itswork = true;
            if (itswork)
            {
                System.Windows.Forms.MessageBox.Show("Hello");
            }
        }

           public List<int> membres = new List<int>();
                
            public List<int> m = new List<int>();
       

        /// <summary>
        ///              Fleches
        /// </summary>
        
        private double verification()
        {
            double som = 0;
            som += double.Parse(Fleches_Epouses());
            som += double.Parse(Fleches_Marie());
            som += double.Parse(Fleches_GrandeMere_matern());
            som += double.Parse(Fleches_GrandeMere_patern());
            som += double.Parse(Fleches_Mere());
            som += double.Parse(Fleches_Soeurs());
            som += double.Parse(Fleches_Frere());
            som += double.Parse(Fleches_filles());
            som += double.Parse(Fleches_Grandpere());// Attention !!!
            som += double.Parse(Fleches_Pere());// Attention !!!
            som += double.Parse(Fleches_fils());

            if (som>=LCM)
            {
                LCM = Convert.ToInt16(som);
                System.Windows.Forms.MessageBox.Show("#donc  la nouvelle origine de la matiere c'est: "+LCM);
            }
            return som;
        }

        private int reste()
        {
            return LCM- Convert.ToInt16(verification());
        }
        public string Fleches_fils()
        {
            string fleches = "0";

            if (Partition_fils(fils) != null)
            {
                if (Partition_filles(filles)=="RF")
                {
                    fleches= (2*reste()/3).ToString();
                }
                else
                {
                    fleches = reste().ToString();
                }
            }
            return fleches;
        }
        public string Fleches_filles()
        {
            string fleches = "0";

            if (Partition_filles(filles) != null)
            {
                if (Partition_filles(filles) == "RF")
                {
                    fleches = reste().ToString();
                }
                else
                {
                    fleches = ((Mfilles-1)*LCM / Mfilles).ToString();
                }
            }
            return fleches;
        }

        public string Fleches_Pere()
        {
            string fleches = "0";

            if (Partition_Pere(Convert.ToBoolean(pere))!= null)
            {
                if (Partition_Pere(Convert.ToBoolean(pere)) == "R")
                {
                    fleches = reste().ToString();
                }
                else if (Partition_Pere(Convert.ToBoolean(pere)) == "1/6+R")
                {
                    fleches = (LCM / Mpere + reste()).ToString();
                }
                else
                {
                    fleches = (LCM / Mpere).ToString();
                }
            }
            return fleches;
        }
        public string Fleches_Mere()
        {
            string fleches = "0";

            if (Partition_Mere(Convert.ToBoolean(pere)) != null)
            {
                fleches = (LCM / Mmere).ToString();
            }
            return fleches;
        }
        public string Fleches_Grandpere()
        {
            string fleches = "0";

            if (Partition_Grandpere(Convert.ToBoolean(gpere)) != null)
            {
                if (Partition_Grandpere(Convert.ToBoolean(pere)) == "R")
                {
                    fleches = reste().ToString();
                }
                else
                {
                    fleches = (LCM / Mgpere).ToString();
                }
            }
            return fleches;
        }
        public string Fleches_GrandeMere_matern()
        {
            string fleches = "0";

            if (Partition_GrandeMere_matern(Convert.ToBoolean(gmerem)) != null)
            {
                fleches = (LCM / Mgmerem).ToString();
            }
            return fleches;
        }

        public string Fleches_GrandeMere_patern()
        {
            string fleches = "0";

            if (Partition_GrandeMere_patern(Convert.ToBoolean(gmerep)) != null)
            {
                fleches = (LCM / Mgmerem).ToString();
            }
            return fleches;
        }
        public string Fleches_Frere()
        {
            string fleches = "0";

            if (Partition_Frere(frere) != null)
            {
                if (Partition_Soeurs(filles) == "RF")
                {
                    fleches = (2 * reste() / 3).ToString();
                }
                else
                {
                    fleches = reste().ToString();
                }
            }
            return fleches;
        }
        public string Fleches_Soeurs()
        {
            string fleches = "0";

            if (Partition_Soeurs(soeur) != null)
            {
                if (Partition_Soeurs(soeur) == "RF")
                {
                    fleches = reste().ToString();
                }
                else
                {
                    fleches = ((Msoeur - 1) * LCM / Msoeur).ToString();
                }
            }
            return fleches;
        }
        public string Fleches_Marie()
        {
            string fleches = "0";

            if (Partition_Marie(Convert.ToBoolean(marie)) != null)
            {
                fleches = (LCM / Mmarie).ToString();
            }
            return fleches;
        }
        public string Fleches_Epouses()
        {
            string fleches = "0";

            if (Partition_Epouses(epousse) != null)
            {
                fleches = (LCM / Mepousse).ToString();
            }
            return fleches;
        }
        public string Somme(string p,double somme)
        {
            double part = 0;
            if (p!=null)
            {
                part = (somme / LCM) * Convert.ToDouble(p);
            }
            return part.ToString();
        }
    }
}