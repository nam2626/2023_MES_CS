using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    interface Power
    {
        public readonly static bool POWER_ON = true;
        public static readonly bool POWER_OFF = false;
        public abstract void PowerOn();
        public void PowerOff();
    }
    class TV : Power
    {
        public void PowerOff()
        {
            Console.WriteLine("TV 전원 Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("TV 전원 On");
        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {

        }
    }
}
