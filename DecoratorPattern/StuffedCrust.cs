using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public class StuffedCrust :Pizza 
    {
        public StuffedCrust(){
            description = "Stuffed Crust Pizza";
        }

        public override double Cost(){
            double cost = 0.0;
            switch (size){
                case "Small":
                cost = 9.0;
                break;
                case "Medium":
                cost = 10.0;
                break;
                case "Large":
                cost = 12.0;
                break;
            }
        }
    }
    
}