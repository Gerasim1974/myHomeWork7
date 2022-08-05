using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork7
{
    internal class clsTablet : clsMedicamentBase
    {
        string _color;
        public clsTablet(string name, double price, byte mode_of_application, byte prescript, string color) : base(name, price, mode_of_application, prescript)
        {
            Color = color;
            ApplicationType = 2;
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public override void PrintPropertyAdditional()
        {
            base.PrintPropertyAdditional();
            Console.WriteLine($"Цвет : {Color}");
        }
    }
}
