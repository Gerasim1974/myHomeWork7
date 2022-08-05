using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork7
{
    abstract class clsMedicament
    {
        public abstract byte ApplicationType { get; set; } //тип: мазь, таблетка, сироп

        public abstract string Name { get; set; } //наименование лекарства

        public abstract double Price { get; set; } //цена

        public abstract byte ModeOfApplication { get; set; } //способ применения: орально внутрь, наружное  

        public abstract string ListOfDeseases { get; set; }  //список болезней - показания к применению

        public abstract byte Prescript { get; set; } //тип отпуска в аптеке: по рецепту, без рецепта

        public abstract void AddToListOfDeseases(string s); //добавляем болезнь в список

        public abstract void Print(); //выводим список болезней

        // public abstract void InputNewMedicament(); //добавляем новое лекарство

    }

}

