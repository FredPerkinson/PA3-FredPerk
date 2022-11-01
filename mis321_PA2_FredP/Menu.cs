using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu
{
    public class Menu
    {
        public int GetCharacter(){
            System.Console.WriteLine("Please choose your character from the options below:");
            System.Console.WriteLine("\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Elizabeth Swann");
            int userInput = int.Parse(Console.ReadLine()); //Makes character choice
            while(userInput != 1 && userInput != 2 && userInput != 3 && userInput != 4) //error handling 
            {
                System.Console.WriteLine("Error... Please choose 1, 2, 3, or 4 from the options below.");
                System.Console.WriteLine("\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Elizabeth Swann");
                userInput = int.Parse(Console.ReadLine()); //Update Read, Makes character choice
            }
            return userInput; //returns the character choice
        }
    }
}