using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//мазь
namespace appHomeWork7
{
    internal class clsOintment : clsMedicamentBase
    {
        int _percent_absordence; //процент впитываемости
        public clsOintment(string name, double price, byte mode_of_application, Byte prescript, int percent_absordence) : base(name, price, mode_of_application, prescript)
        {
            PercentAbsordence = percent_absordence;
            ApplicationType = 0;

        }
    public int PercentAbsordence
        {
            get
            {
                return _percent_absordence;
            }
            set
            {
                _percent_absordence = value;
            }
        }
        public override void PrintPropertyAdditional()
        {
            base.PrintPropertyAdditional();
            Console.WriteLine($"Впитываемость : {PercentAbsordence}%");
        }
    }
}
