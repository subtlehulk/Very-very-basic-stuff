/*
            //Verifying input ==> someone's name
            Console.WriteLine("Please enter your name.");
            var userName = Console.ReadLine();
            Console.WriteLine($"Your name is {userName}, is that correct?");
            var verificationOfName = Console.ReadLine();

            
            Basic if statement
            if (verificationOfName == "yes" || verificationOfName == "Yes" || verificationOfName == "y")
            {
                Console.WriteLine("Thank you");
            } 
            else
                Console.WriteLine("Don't lie to me");
            

            //Using a while loop to verifiy someone's name
            while (verificationOfName == "No" || verificationOfName == "no" || verificationOfName == "n")
            {
                Console.WriteLine("Please enter your correct name");
                var name = Console.ReadLine();
                Console.WriteLine("Is this name correct?");
                var correct = Console.ReadLine();
                if (correct == "Yes" || correct == "yes" || correct == "y") 
                {
                    break;
                }
            }
            Console.WriteLine("Thank you");
            
            string nameOne = "";
            string nameTwo = "";
            string nameThree = "";

            for (int i=2;i<=3; i++) {
                Console.WriteLine("What is your name?");
            }
            

            //Converting Strings into number values.
            //NOTE: Use decimals/doubles for ease of use. Will convert ints into decimals but will look like a whole integer.

            var number = "30090";
            var numberConverted = Convert.ToInt32(number);
            Console.WriteLine(numberConverted);

            var numberTwo = "30090.5";
            var numberConvertedTwo = Convert.ToDouble(numberTwo);
            Console.WriteLine(numberConvertedTwo);

            var numberThree = "30090.54568568";
            var numberConvertedThree = Convert.ToDecimal(numberThree);
            Console.WriteLine(numberConvertedThree);
            

            var apples = 100;
            var oranges = 2;
            var result = apples % oranges;
            Console.WriteLine(result);
            result = oranges % apples;
            Console.Write(result + "\n");
            Console.WriteLine(DateTime.Now);

            //implicit variable declaration
            var num = 0;

            //explicit variable declaration
            int numbTwo;

            Console.Write("Enter a number, bro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another, Broseph: ");
            numbTwo = Convert.ToInt32(Console.ReadLine());
            var answer = num + numbTwo;
            Console.WriteLine($"I just added {num} and {numbTwo} together to make {answer}, dumbass.");


        static void Main(string[] args)
        {
            GreetUser();
            AddNums(4, 1000);
            int result = AddUserNumbers();
            Console.WriteLine(result);
        }

        //These methods must be written outside the scop of the Main(string[] args) method above but must be called WITHIN the Main method.
             public static void GreetUser() 
        {
            Console.WriteLine("Hello there!");
        }

        //This method takes two values as parameters to print out the sum of them to the console.
        public static void AddNums (int one, int two)
        {
            Console.WriteLine(one + two);
        }

        //This method allows us to take an input from the user, convert it to an integer and then print out the sum
        public static void AddUserNumbers ()
        {
            Console.WriteLine("Provide me with a number");
            var numbOne = Console.ReadLine();
            Console.WriteLine("Provide me with a number");
            var numbTwo = Console.ReadLine();

            int numberOne = Convert.ToInt32(numbOne);
            int numberTwo = Convert.ToInt32(numbTwo);
            int answer = numberOne + numberTwo;
            Console.WriteLine(answer);
        }

        //This method goes a step further by doing the same as the method above, but it RETURNS the value of answer to the main method, which can then be
        //manipulated by the main part of the program.
        public static int AddUserNumbers()
        {
            Console.WriteLine("Provide me with a number");
            var numbOne = Console.ReadLine();
            Console.WriteLine("Provide me with a number");
            var numbTwo = Console.ReadLine();

            int numberOne = Convert.ToInt32(numbOne);
            int numberTwo = Convert.ToInt32(numbTwo);
            int answer = numberOne + numberTwo;
            return answer;
        }

*/