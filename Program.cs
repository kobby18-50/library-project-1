
using System;

namespace AssignmentTwo{

    class Program
    {
            
        public static void Main(string[] args){

            Console.WriteLine("Enter the date book was borrowed (Use the format - DD/MM/YYYY)");
            DateTime date_taken = Convert.ToDateTime(Console.ReadLine());
            // System.Console.WriteLine(date_taken);
           
            Console.WriteLine("Enter the date book was returned (Use the format - DD/MM/YYYY)");
            DateTime date_delivered = Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine("");


            // System.Console.WriteLine(date_delivered);

            var penalty_Points = (date_delivered - date_taken).Days;
            // System.Console.WriteLine(penalty_Points);
            
            if(penalty_Points <= 5 && penalty_Points >= 0){
                
                System.Console.WriteLine("You will pay $ 0 for borrowing the book for {0} days",penalty_Points);
            }

            else if(penalty_Points > 5 && penalty_Points <= 10 ){
                var fine_to_pay = penalty_Points * 0.5;
                System.Console.WriteLine("You will pay $ {0} for borrowing the book for {1} days",fine_to_pay,penalty_Points);
            }

            else if(penalty_Points > 10 && penalty_Points <=30){
                var fine_to_pay = penalty_Points * 1.5;
                System.Console.WriteLine("You will pay $ {0} for borrowing the book for {1} days",fine_to_pay,penalty_Points);             
            }

            else if(penalty_Points > 30){
                var fine_to_pay = penalty_Points * 4.5;
                System.Console.WriteLine("You will pay $ {0} for borrowing the book for {1} days",fine_to_pay,penalty_Points);             
            }

            else
            {
                System.Console.WriteLine("Don't come here again!!!!");
            }





            // System.Console.WriteLine("Enter the date the book was taken DD-MM-YYYY");
            // DateTime LDT = Convert.ToDateTime(Console.ReadLine());

            // System.Console.WriteLine("You entered {0}", LDT.ToLongDateString());
        
           
        }

        
    }

    
}