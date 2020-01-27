using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsStrutturaDati2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeri = new HashSet<int>();
            using (StreamReader sr = new StreamReader("fileInteri.txt",Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int n = int.Parse(line);
                    numeri.Add(n);
                }
            }
            using (StreamWriter sw = new StreamWriter("fileSalvati.txt", false, Encoding.UTF8))
            {
                foreach(int s in numeri)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
