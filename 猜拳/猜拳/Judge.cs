using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    class Judge
    {
        public string IsWiner(int a, int b)
        {
            if (a - b == -1 || a - b == 2)
                return "玩家胜";
            else if (a - b == -2 || a - b == 1)
                return "AI胜";
            else
                return "平局";

        }
    }
}
