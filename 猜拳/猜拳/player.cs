using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    class player
    {
        public string FistName { get; set; }
        public int result;
        public int ShowFist()
        {
            switch (FistName)
            {
                case "石头":
                    return result = 1;
                case "剪刀":
                    return result = 2;
                case "布":
                    return result = 3;
            }
            return result;
        }
    }
}
