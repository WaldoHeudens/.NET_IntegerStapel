using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerStapel
{
    internal class IntegerStapel
    {
        int[] stapel = new int[5];
        int positie = -1;

        public void OpStapel(int toeTeVoegen)
        {
            positie++;
            if (positie >= stapel.Length)
                VergrootStapel();
            stapel[positie] = toeTeVoegen;
        }

        public int? VanStapel()
        {
            if (positie >= 0)
            {
                positie--;
                return stapel[positie + 1];
            }
            return null;
        }

        void VergrootStapel()
        {
            int[] even = stapel;
            stapel = new int[stapel.Length + 5];
            for (int i = 0;  i < even.Length; i++)
            {
                stapel[i] = even[i];
            }
        }

        public override string ToString()
        {
            string content = "";
            for (int i = 0; i <= positie; i++)
                content += stapel[i] + "; ";
            return content;
        }
    }
}
