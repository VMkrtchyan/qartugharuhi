using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiHasarakPorc
{
   public class Program
    {
        static void Main(string[] args)
        {
            Zangogh Shef = new Zangogh();
            Shef.Name = "Harut";
            Shef.Tip = "Shef";
            Shef.Zang(metod1);
            

            Zangogh Banvor = new Zangogh();
            Banvor.Name = "Srap";
            Banvor.Tip = "banvor";
            Banvor.Zang(metod2);
            

            Zangogh Partqater = new Zangogh();
            Partqater.Name = "Smbo";
            Partqater.Tip = "Partqater";
            Partqater.Zang(metod3);
            
            Console.Read();
        }
            


       static Patasxan metod1 = QarugharuhuPat1;
        static Patasxan metod2 = QarugharuhuPat2;
        static Patasxan metod3 = QarugharuhuPat3;


        static void QarugharuhuPat1 (string blablabla)
        {
        Console.WriteLine(blablabla);
            Console.WriteLine("Lsum em shef jan");
        }

        static void QarugharuhuPat2(string blablabla )
        {
            Console.WriteLine(blablabla);
            Console.WriteLine("El stex chzanges");
        }

        static void QarugharuhuPat3(string blablabla )
        {
            Console.WriteLine(blablabla);
            Console.WriteLine("Tnoren@ dzez het shutov kkapnvi");
        }
    }
}
