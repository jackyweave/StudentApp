using System.Linq.Expressions;
 class Program
{
    static void Main()
    {
        
        

        // Array to hold names
        string[] names = {
            "Justin", "Ethan", "Victoria", "Ethan", "Ben",
            "Kyra", "Jack", "Ramses", "Clare", "Ramsey",
            "Ali", "Pedro"
        };

        // Array to hold favorite foods
        string[] favoriteFoods = {
            "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs",
            "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum",
            "Indian", "Italian"
        };

        // Array to hold hometowns
        string[] hometowns = {
            "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham",
            "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn",
            "Dearborn Heights", "Chicago"
        };


        Console.WriteLine("Welcome to the database!");
        bool MainProgram = true; 
        while(MainProgram)
        {
            Console.Write("Enter a student number (1 to " + names.Length + "): ");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
             if (studentNumber < 1 || studentNumber > names.Length)
            {
                Console.WriteLine("Invalid student number. Please try again.");
                continue;
        }

            int studentIndex = studentNumber - 1;
            Console.WriteLine("Student's name: " + names[studentIndex]);

            Console.Write("Which category to display (Hometown or Favorite Food): ");
            string category = Console.ReadLine().ToLower();

            if (category != "hometown" && category != "favorite food")
            {
                Console.WriteLine("Invalid category. Please enter 'Hometown' or 'Favorite Food'.");
                continue;
            }

            switch (category)
            {
                case "hometown":
                    Console.WriteLine("Student's hometown: " + hometowns[studentIndex]);
                    break;
                case "favorite food":
                    Console.WriteLine("Student's favorite food: " + favoriteFoods[studentIndex]);
                    break;
            }




            Console.Write("Would you like to learn about another student? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                MainProgram = false; 
            }
        }

        Console.WriteLine("Thank you for using the Student Program!");
    }
}











     