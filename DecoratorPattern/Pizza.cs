using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
    public abstract class Pizza
    {
        public string size;
        public string description;
        public Pizza(){
            description = "Unknown Pizza";
        }

        public virtual string GetDescription(){
            return size + " " + description;
        }

        public virtual string GetSize(){
            return size;
        }

        public virtual void SetSize(string size){
            this.size = size;
        }

        public abstract void Cost();
    }
}