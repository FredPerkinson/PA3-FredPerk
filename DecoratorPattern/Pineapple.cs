using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public class Pineapple : PizzaDecorator
    {
        
    }

        public override double Cost(){
        double cost = pizza.Cost();
        switch(pizza.GetSize()){
            case "Small":
            cost += .5;
            break;
            case "Medium":
            cost += 1.0;
            break;
            case "Large":
            cost += 1.5;
            break;
        }
    }
}