using System;
using System.IO;

namespace HandlingExceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string content =
                    File.ReadAllText("/Users/stephen/desktop/C#/learning/HandlingExceptions/tes.txt");
                // supposed to be test.txt but tes.txt causes an FileNotFoundException
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                // can google method name and get the exceptions that can be 
                // caused and what causes them.
                Console.WriteLine("There was a problem !");
                Console.WriteLine("Could not find file tes.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem !");
                Console.WriteLine("Could not find directory HandlingExceptions");
            }catch(Exception ex){
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }finally{
                // code to finalize before closing application.
                Console.WriteLine("Closing Application");
            }

        }
    }
}
