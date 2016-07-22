using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    class ai
    {
        public int result;
        public string FistName { get; set; }
        public string  fistname()
        {
            Random random = new Random();
            result = random.Next(1, 4);
            switch (result)
            {
                case 1:
                    return this.FistName = "石头";
                case 2:
                    return this.FistName = "剪刀";
                case 3:
                    return this.FistName = "布";
                default:
                    break;
            }
            return FistName;
        }
    }
}
