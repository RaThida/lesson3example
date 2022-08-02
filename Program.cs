using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3example
{
     class Cube
    {
        private float fltSide;
        //a constructor is a special method
        //(1) it is public
        //(2) it does not return anything, yet me do not put void 
        //(3) it has the same name as the class
        public Cube(float x)  //x is the float parameter
                              //

        {
            fltSide = x;
        }

        public string GetSide()
        {
            return fltSide.ToString();

        }
    }

    internal class Prgram
    {
        static void Main(string[] args)
        {
            Console.Write("type the length of the side for the cube: ");
            float x = float.Parse(Console.ReadLine());
            Cube c10bj = new Cube(x); //x is the float argument
            Console.WriteLine("The length of the side of the cube is {0}", c10bj.GetHashCode());
        }
    }
}
