using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18work1
{
    class PC
    {
        public string Maker;
        public string Color;
        public string OS;

        public PC(string maker, string color, string OS)
        {
            this.Maker = maker;
            this.Color = color;
            this.OS = OS;
        }
        public string PowerOn()
        {
            return this.Maker + this.Color + this.OS + "is Lauching... Welcome!";
        }
        public string PowerOff()
        {
            return this.Maker + this.Color + this.OS + "is shutting down... Goodbye!";
        }


    }   
}
