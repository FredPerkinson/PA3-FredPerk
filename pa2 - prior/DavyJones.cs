using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
{
    public class DavyJones : Player
    {
        public DavyJones(){
            attack = new CannonAttack();    //Create Davy Jones
        }
    }
}