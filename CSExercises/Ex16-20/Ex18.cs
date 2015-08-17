namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            String grade = "";

            if (marks >= 80)
            {
                grade = "A";
                Console.WriteLine("You score {0} which is grade {1}", marks, grade);
            }

            if ((marks >= 60) && (marks <= 79))
            {
                grade = "B";
                Console.WriteLine("You score {0} + marks which is grade{1}", marks, grade);
                Console.ReadLine();
            }

            if ((marks >= 40) && (marks <= 59))
            {
                grade = "C";
                Console.WriteLine("You score " + marks + "which is" + "grade " + grade);
                Console.ReadLine();
            }
            if ((marks <= 40) && (marks >= 0))
            {

                Console.WriteLine("You score " + marks + "which is" + "grade " + grade);
                Console.ReadLine();
            }
            if ((marks < 0) || (marks > 100))
            {
                Console.WriteLine("You have entered the marks wrongly.  Please enter again:");
                Console.ReadLine();

            }
        }
    }
}



            
        
