using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TerrariumFormatException: Exception
    {
        public TerrariumFormatException():
            base("Файл не соответствует нужному формату")
        { }
    }
}
