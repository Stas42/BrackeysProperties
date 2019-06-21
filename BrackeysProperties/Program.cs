using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrackeysProperties
{
    class MainCLass   
    {
        static void Main(string[] args)
        {
            Player tom = new Player();
            Console.WriteLine(tom.health);

            //tom.health =40;
            //Console.WriteLine(tom.health);
            //tom.Damage(50);
            //tom.health = 30;  - can't be performed cause the "health" is readonly = only get

            tom.health -= 200;
            Console.WriteLine(tom.health);
            tom.health += 400;
            Console.WriteLine(tom.health);
            tom.health -= 70;
            Console.WriteLine(tom.health);


        }
    }
}
