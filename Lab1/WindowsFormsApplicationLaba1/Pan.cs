using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Pan
    {

        private Dough testo;

        public bool ReadyToGo { get { return Check(); } }

        public void AddDough(Dough dd)
        {
            testo = dd;
        }

        private bool Check()
        {

            if (testo == null)
            {
                return false;
            }

            return true;
        }


        public void Getheat()
        {
            if (!Check())
            {
                return;
            }

            bool flag = false;
            if (flag)
            {
                testo.GetHeat();
            }

        }

        public bool Isready()
        {
            if (testo.Has_ready < 10)
            {
                return false;
            }
            return true;
        }

    }

}

