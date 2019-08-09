using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculHeritage
{
    public class Personne
    {
        private string typep;
        private double part;


        public string Typep { get => typep; set => typep = value; }
        public double Part { get => part; set => part = value; }

        public Personne(string typep, double part)

        {
            this.Typep = typep;
            this.Part = part;
        }

        public Personne()
        {

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

        public string Partition_filles(int nombre)
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }

        public string Partition_fils(int nombre)
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }

        public string Partition_Grandpere()
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }
        public string Partition_GrandeMere_matern()
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }

        public string Partition_GrandeMere_patern()
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }
        public string Partition_Epouses()
        {
            string partition = null;
            //Ici votre Code

            return partition;
        }

        public string OrigineDeLaMAtiere()
        {

            string numero_matiere = null;

            return numero_matiere;
        }
    }
}