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
            Shef.Zang(metod1);
            Shef.Tip = "Shef";

            Zangogh Banvor = new Zangogh();
            Banvor.Name = "Srap";
            Banvor.Zang(metod2);
            Banvor.Tip = "banvor";

            Zangogh Partqater = new Zangogh();
            Partqater.Name = "Smbo";
            Partqater.Zang(metod3);
            Partqater.Tip = "Partqater";
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
