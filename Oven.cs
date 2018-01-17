using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Kitchen_Maffins
{
    class Oven
    {
        class oven
        {
            //противень
            private Baking baking;
            //состояние духовки
            public bool state { set; get; }
            //свойство получения и возврата противеня
            public Baking Baking { set { baking = value; } get { return baking; } }
            //метод готовки
            public void cook()
            {
                if (state)
                {
                    while (!baking.is_ready())
                    {
                        baking.get_maffins();
                    }
                }
            }
        }
    }
}
