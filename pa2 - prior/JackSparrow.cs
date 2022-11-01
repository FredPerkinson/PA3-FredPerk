using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
{
    public class JackSparrow : Player
    {
        public JackSparrow()
        {
            //Creates Jack Sparrow 
            attack = new DistractAttack();
        }
    }
}