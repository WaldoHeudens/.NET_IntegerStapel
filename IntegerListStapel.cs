using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerStapel
{
    internal class IntegerListStapel
    {
        List<int> stapel = new List<int>();

        public void OpStapel(int toeTeVoegen)
        {
            stapel.Add(toeTeVoegen);
        }

        public int? VanStapel()
        {
            if (stapel.Count > 0)
            {
                int even = stapel[stapel.Count-1];
                stapel.RemoveAt(stapel.Count - 1);
                return even;
            }
            return null;
        }

 
        public override string ToString()
        {
            string content = "";
            foreach (int i in stapel)
                content += i + "; ";
            return content;
        }
    }
}
