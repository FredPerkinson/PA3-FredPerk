using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2  
{
    public class CannonAttack : IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Used Cannon Attack!"); //Interface for cannon attack
        }
    }
}