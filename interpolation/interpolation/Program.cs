using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ , Concat , Format , Interpolation
            
        

                string donanim1, donanim2, Sonuc;
                int fiyat = 100;
                double kdv = 0.18;

                donanim1 = "fare";
                donanim2 = "klavye";


                Sonuc = "1- " + donanim1 + "\n2- " + donanim2 + "\n+--------------\nTutar = " + (fiyat + (fiyat * kdv)) + "TL";

                Console.WriteLine(Sonuc);

                //Concat
                Sonuc = string.Concat("1- ", donanim1, "\n2- ", donanim2, "\n+-----------\nTutar= " + (fiyat + (fiyat * kdv)) + "TL");

                Console.WriteLine("\n{0}", Sonuc);

                //Format
                Sonuc = string.Format("1- {0}\n2- {1}\n+----------\nTutar= {2}", donanim1, donanim2, (fiyat + (fiyat * kdv)));

                Console.WriteLine("\n{0}", Sonuc);


                //Interpolation
                Sonuc = $"1- {donanim1}\n2- {donanim2}\n+-----------\nTutar= {fiyat + (fiyat * kdv)}";
                Console.WriteLine("\n{0}", Sonuc);

                Console.ReadLine();
            }
    }
}
