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
        
        int fils = 0, filles = 0, pere = 0, mere = 0, seour = 0, frere = 0, gpere = 0, gmerep = 0, gmerem = 0, epousse = 0, marie = 0;
        int Mfils = 0, Mfilles = 0, Mpere = 0, Mmere = 0, Mseour = 0, Mfrere = 0, Mgpere = 0, Mgmerep = 0, Mgmerem = 0, Mepousse = 0, Mmarie = 0;
        List<int> menbres = new List<int>();
        
        public Partition()
        {
            
        }

        public Partition(List<int> membre)
        {
            membres = AjouterMembre();
        }

        public int lcm(int[] t, int n)
        {

            for (int i = 0; i <= n; i++)
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
            }
            else if (nombre==1 && fils==0)
            {
                partition= "1/2";
                Mfilles = 2;
            }
            else if (nombre>1 && fils>=0)
            {
                partition= "2/3";
                Mfilles = 3;
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
                }
                else if (filles>0)
                {
                    partition = "1/6 + R";
                    Mpere=6;
                }
                else
                {
                    partition = "R";
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
                }
                else
                {
                    partition = "1/3";
                    Mmere = 6;
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
                if ( (fils>0 || filles>0 || seour>0) && pere==0)
                {
                    partition = "1/6";
                    Mgpere = 6;
                }
                else if (pere==0)
                {
                    partition = "R";
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
                    if (nombre>1)
                    {
                        partition = "R";
                    }
                    else
                    {
                        partition = "R";
                    }
                }
            }
            return partition;
        }
        public string Partition_Soeurs(int nombre)
        {
            string partition = null;
            seour = nombre;
           
            if (nombre ==0)
            {
                if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere == 0)
                {
                    partition ="1/2";
                    Mseour = 2;
                }
            }
            else if (nombre > 1)
            {
                if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere == 0)
                {
                    partition = "2/3";
                    Mseour = 3;
                }
                else if (fils == 0 && filles == 0 && pere == 0 && gpere == 0 && frere > 0)
                {
                    partition = "RF";
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
                }
                else
                {
                    partition = "1/2";
                    Mmarie = 2;
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
                }
                else
                {
                    partition = "1/4";
                    Mepousse = 4;
                }
            }
            return partition;
        }

        public string OrigineDeLaMAtiere()
        {

            string numero_matiere = null;

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
       
        public List<int> AjouterMembre()
        {
            List<int> membre = membres;
            membres.Add(fils );
            membres.Add(filles);
            membres.Add(pere);
            membres.Add( mere);
            membres.Add( seour);
            membres.Add(frere);
            membres.Add(gpere);
            membres.Add( gmerep);
            membres.Add(gmerem);
            membres.Add(epousse);
            membres.Add(marie);
            
            return membre;
            
        }

       
    }
}