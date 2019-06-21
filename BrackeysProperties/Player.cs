using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrackeysProperties
{
    class Player
    {
        private int _health = 100;
        //Get only poroperty (Readonly access )
        public int health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;

                }
            }
        }
    }
}
        //public void Damage(int _dmg)
        //{
        //    health -= _dmg;
        //}
    

