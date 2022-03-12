using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJson
{
    public class Rice
    {
        public List<TypesOfRice> typesofrice;
        public List<Typesofgrain> typesofgrain;
        public List<TypesofWheat> typesofwheat;
    }
    public class TypesOfRice
    {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }
    }
    public class Typesofgrain
    {
        public string Name { get; set; }
        public  int Weight { get; set; }
        public int Price { get; set; }
    }
    public class TypesofWheat
    { 
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }


}
