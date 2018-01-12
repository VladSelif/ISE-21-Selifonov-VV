using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba1
{
    class Dough
    {
        private Egg[] eggs;
        private Sugar sugar;
        private Flour flour;
        private Vanillin vanillin;
        private Flakes_gerkules flakes;

        public void Init(int count_egg)
        {
            eggs = new Egg[count_egg];
        }

        public void AddEgg(Egg e)
        {
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = e;
                    return;
                }
            }
        }

        public void AddSugar(Sugar s)
        {
            sugar = s;
            sugar.Count_Sugar = true;
        }

        public void AddFlour(Flour f)
        {
            flour = f;
            flour.Count_Flour = true;
        }

        public void AddVanillin(Vanillin v)
        {
            vanillin = v;
            vanillin.Count_Vanillin = true;
        }

        public void AddFlakes_gerkules(Flakes_gerkules g)
        {
            flakes = g;
            flakes.Count_Flakes = true;
        }

        private int has_ready = 0;
        public int Has_ready { get { return has_ready; } }

        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }

        public bool Cut { get; internal set; }
        public bool Check()
        {
            if (eggs == null)
            {
                return false;
            }
            if (eggs.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_shell_egg)
                {
                    return false;
                }
            }

            if (eggs.Length < 1) return false;

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null) return false;
            }

            if (!sugar.Count_Sugar) return false;

            if (!flour.Count_Flour) return false;

            if (!vanillin.Count_Vanillin) return false;

            if (!flakes.Count_Flakes) return false;

            return true;
        }
    }            
 }

