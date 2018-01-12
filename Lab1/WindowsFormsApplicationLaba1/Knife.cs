using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Knife
    {
        public void Cut_Egg(Egg e)
        {
            if (e.Have_shell_egg)
            {
                e.Have_shell_egg = false;
            }
        }

        public void Cut_Dough(Dough testo)
        {        
                if (testo.Cut)
                {
                    testo.Cut = false;
                }
        }
    }
}
