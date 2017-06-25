using System;

namespace UnderstandingScope
{
    // scope and accessibility modifiers.

    class MainClass
    {

        // private (called only in this class)
        private static string k = "";
        // private and public are called accessibility modifiers to implements
        // encapsulation.

        // encapsulation: all the important behind the scenes functionality should be
        // hidden in interfaces and classes.
        // but consumer of the class shouldn't have to know any of the inner workings
        // of the class to be able to use it.

        public static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++){
                // simple for loop printing 0 - 9.
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if(i == 9){
                    string l = i.ToString();
                }
                // Console.WriteLine(l);
                // ^ doesn't work since scope is only the if statement.
            }
            //Console.WriteLine(i);
            // ^ does not work because it is outside of the scope of its definition.

            Console.WriteLine("Outside of the for: {0}", j);
            // declared outside for loop so it can be used.

            Console.WriteLine("Outside of the for: {0}", k);
            // declared private in this class so it can be used.

            HelperMethod();


            Car myCar = new Car();
            myCar.DoSomething();
            // you know that this will print out hello world, but you don't know
            // how it does this.
        }

        public static void HelperMethod(){
            // k is defined inside the class so this method in the class can use it.
            Console.WriteLine("Value of k from the HelperMethod {0}", k);
        }
    }

    class Car{
        // have parts of classes you have access to (DoSomething)
        // and parts that you don't have access to (helperMethod)
        
        public void DoSomething(){
            Console.WriteLine(helperMethod());   
        }

        private string helperMethod(){
            return "Hello world!";
        }
    }
}
