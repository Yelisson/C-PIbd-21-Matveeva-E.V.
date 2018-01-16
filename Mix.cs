using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Kitchen_Maffins
{
    class Mix
    {
        public double mass;
        //смешиваем ингредиенты
        public double mixer(Milk m, Sugar s, Flour f, Eggs e)
        {
            mass = m.count_milk + s.count_sugar + f.count_flour + e.count_eggs;
            return mass;
        }
    }
}
