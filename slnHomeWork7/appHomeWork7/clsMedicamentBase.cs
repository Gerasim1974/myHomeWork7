using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork7
{
    internal class clsMedicamentBase : clsMedicament
    {
        Dictionary<int, string> _app_type;
        Dictionary<int, string> _presc;
        Dictionary<int, string> _mode;
        byte _app_lication_type; //тип: мазь, таблетка, сироп
        string _name; //наименование лекарства
        double _price; //цена
        byte _mode_of_application; //способ применения: орально внутрь, наружное
        string _list_of_deseases; //список болезней - показания к применению
        byte _prescript;//тип отпуска в аптеке: по рецепту, без рецепта

        public clsMedicamentBase(string name, double price, byte mode_of_application, byte prescript)
        {
            _app_type = new Dictionary<int, string>()
             {
                 { 0, "Мазь" },
                 { 1, "Таблетка" },
                 { 2, "Сироп" }
             };
            _presc = new Dictionary<int, string>()
            {
                {0, "По рецепту" },
                {1, "Без рецепта" }
            };
            _mode = new Dictionary<int, string>()
            {
                { 0, "Орально внутрь" },
                { 1, "Наружное" }
            };
            Name = name;
            Price = price;
            ModeOfApplication = mode_of_application;
            //Prescript = prescript;  
        }

        public override byte ApplicationType
        {
            get
            {
                return _app_lication_type;
            }
            set
            {
                _app_lication_type = value;
            }
        }
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public override byte ModeOfApplication
        {
            get
            {
                return _mode_of_application;
            }
            set
            {
                _mode_of_application = value;
            }
        }
        public override string ListOfDeseases //список болезней - показания к применению
        {
            get
            {
                return _list_of_deseases;
            }
            set
            {
                _list_of_deseases = value;
            }
        }  //список болезней - показания к применению
        public override byte Prescript //тип отпуска в аптеке: по рецепту, без рецепта
        {
            get
            {
                return _prescript;
            }
            set
            {
                _prescript = value;
            }
        }
        public override void AddToListOfDeseases(string s)
        {
            if (!!string.IsNullOrWhiteSpace(s))
            {
                ListOfDeseases = "Общеукрепляющее средство";
            }
            else
            {
                if (!!string.IsNullOrEmpty(ListOfDeseases))
                {
                    ListOfDeseases += ";";
                }
                ListOfDeseases += s;
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Название : {Name}");
            Console.WriteLine($"Цена : {Price} руб");
            Console.WriteLine($"Тип : {_app_type[ApplicationType]}") ;
            Console.WriteLine($"Отпуск : {_presc[Prescript]}");
            Console.WriteLine($"Показания к применению : {ListOfDeseases}");
            PrintPropertyAdditional();
        }
        public virtual void PrintPropertyAdditional()
        {
            //переопределяем в потомке
        }

    }
}
