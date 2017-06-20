using System;

namespace SimpleMethods
{
    class MainClass
    {
        public static void Main(string[] args){
            HelloWorld();
        }

        private static void HelloWorld(){
            Console.WriteLine("Hello World!");
            Console.WriteLine("This was printed in a method and not a main method");
        }

    }
}
