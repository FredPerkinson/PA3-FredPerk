using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utility
{
    public class Utility
    {
        public int Add(int x, int y){
            return x+y;
        }

        public int Subtract(int x, int y){
            return x-y;
        }

        public bool IsOdd(int x){
            if(x % 2 ==0){
                return false;
            }
            return true;
        }

        
    }
}