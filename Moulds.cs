using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Kitchen_Maffins
{
    class Moulds
    {
        double form;

        //наличие однородной массы в формочке
        public bool have_mass { set; get; }
        //добавление массы в формочку
        public double add(Mix m)
        {
            if (have_mass == false)
            {
                form = form + m.mass;
            }
            return form;
        }
    }
}
