using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cheese : PizzaDecorator
    {
       private Pizza pizza;

       public Cheese(Pizza pizza){
        this.pizza = pizza;
       }

       public override string GetDescription(){
        return pizza.GetDescription() + " , add Cheese";
       }

       public override void SetSize(String size){
            pizza.SetSize(size);
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
        return cost;
       }
    }
}