using System;

class Program
{
    static void Main(string[] args)
    {
     
        // loop that will keep on asking if the user doent quit.
        //menu on 5 options
        bool quit = false;
        while (!quit) 
        {
            Console.WriteLine("PLease select one of the following choices");
            Console.WriteLine("1.Write\n2.Display\n3.load\n4.save\n5.Quit");
            string user_respons = Console.ReadLine();
            switch (user_respons) {
                case "1":{
                    string prompt = "randon question";
                    Console.WriteLine(prompt);
                    string user_answer = Console.ReadLine();
                    DateTime time = DateTime.Now;
                   
                     break;
                };
                case "2": break;
                case "3": break;
                case "4": break;
                case "5": break;
                
            
            }
        

        }
        //write
        //display
        //load
        //save
        //quit
    }
}