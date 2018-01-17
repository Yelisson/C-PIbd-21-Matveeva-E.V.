using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Kitchen_Maffins
{
    class Baking
    {
        private Moulds[] forms;

        //степень готовности(есть золотая корочка или нет)
        public bool golden_crust = false;

        //всё ли готово к выпеканию
        public bool ready_to_go { get { return check(); } }

        //инициализация
        public void init(int count_moulds)
        {
            forms = new Moulds[count_moulds];
        }
        //добавление формочек на противень
        public void add_moulds(Moulds m)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] == null)
                {
                    forms[i] = m;
                    return;
                }
            }
        }
        //готовы ли формочки
        private bool check()
        {
            if (forms.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] == null)
                    return false;
            }
            return true;
        }
        //готовка
        public void get_maffins()
        {
            if (!check())
            {
                return;
            }
            golden_crust = true;
        }
        //проверяем, готовы ли маффины
        public bool is_ready()
        {
            if (golden_crust == false)
            {
                return false;
            }
            return true;
        }
        //достаем протвень
        public Moulds[] get_moulds()
        {
            return forms;
        }
    }
}
