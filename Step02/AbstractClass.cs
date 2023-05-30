using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    //추상 클래스, 추상 메서드
    abstract class Gun
    {
        public abstract void shot();
        public void reload()
        {
            Console.WriteLine("Reload!!!");
        }
    }

    class M16 : Gun
    {
        public override void shot()
        {
            Console.WriteLine("Bang!!");
        }
    }

    internal class AbstractClass
    {
        static void Main(string[] args)
        {
            //추상 클래스는 직접적으로 생성 X
            //Gun a = new Gun();
            M16 m16 = new M16();
            m16.reload();
            m16.shot();
        }
    }
}



