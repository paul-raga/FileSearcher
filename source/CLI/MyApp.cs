using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEnterprise
{
    //classe che chiama tutti gli handeler 
    public class MyApp
    {
        private int stopFlag = 0;
        public MyApp() {
            this.execute();
          }

        //loop di esecuzione dell'applicazione
        public void execute() {

            while (this.stopFlag == 0) {
               Console.WriteLine("Type 'R' to read data, 'W' to downlad a file and search for a pattern, 'C' to delete saved data");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "R":
                        Commands.readData();
                        break;

                    case "W":
                        Console.WriteLine("Write the name of the file to be downloaded:  ");
                        Console.WriteLine("Options are: 'sample1' , 'sample2' ,'sample3' ");

                        string filename = Console.ReadLine();

                        Console.WriteLine("write the string to be matched: ");
                        string pattern = Console.ReadLine();

                        Commands.downloadAndSearch(filename, pattern);
                        break;

                    case "C":
                        Logger.getInstance.flush();
                        break;

                    default:
                        Console.WriteLine("WRONG INPUT");

                        break;

                    

                }
                Console.WriteLine("Continue the execution? (Y/N)");
                string response = Console.ReadLine();
                switch (response) {
                    case "Y": 
                        break;

                    case "N": 
                        this.stopFlag  = 1; 
                        break;

                    default: 
                        Console.WriteLine("WRONG INPUT");
                       
                        break;

                }

            } 
        }
    }
}
