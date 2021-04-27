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
            */