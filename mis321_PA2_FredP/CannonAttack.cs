using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_PA2_FredP 
{
    public class CannonAttack : IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Used Cannon Attack!"); //Interface for cannon attack
        }
    }
}