using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiHasarakPorc
{
    public delegate void Patasxan (string massage);

    class Zangogh
    {
        
        public string Name { get; set; }

        public string Tip { get; set; }

        public void Zang( Patasxan metod )
        {
         metod(string.Format("Barev, {0} {1}n a",Tip, Name)); 
        }


    }
}
