using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork7
{
    internal class clsSyrup : clsMedicamentBase
    {
        string _flavor;
        public clsSyrup(string name, double price, byte mode_of_application, byte prescript, string flavor) : base(name, price, mode_of_application, prescript)
        {
            Flavor = flavor;
            ApplicationType = 1;
        }
        public string Flavor
        {
            get
            {
                return _flavor;
            }
            set
            {
                _flavor = value;
            }
        }
        public override void PrintPropertyAdditional()
        {
            base.PrintPropertyAdditional();
            Console.WriteLine($"Вкус : {Flavor}");
        }
    }
}

