using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
{
    public class SwordAttack : IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Used Sword Attack!");     //Creates sword attack from interface
        }
    }
}