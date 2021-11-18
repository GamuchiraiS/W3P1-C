using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Str w = new Str(); //create an object for the Str class 
            w.ReverseWord(); //call the method
            Console.WriteLine(w.str); //prints the reversed string
            Console.ReadLine();

        }
        // create class 
        public class Str
        {
            public string str; //create a field
            //constructor
            public Str()
            {
                str = "Hello to the world"; //assign a value
            }
            //method
            public void ReverseWord()
            {
                //Creates an array filled with the words of the string
                string [] wordArray = str.Split(' '); 
                //Reverses the array
                Array.Reverse(wordArray);
                //Joins the reversed array and assigns the value
                //to str
                str = String.Join(" ", wordArray);
            }
        }
    }
}
