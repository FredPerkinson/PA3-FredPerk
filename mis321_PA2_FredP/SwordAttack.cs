using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_PA2_FredP
{
    public class SwordAttack : IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Used Sword Attack!");     //Creates sword attack from interface
        }
    }
}