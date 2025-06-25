using System;

class Program
{
    static void Main()
    {
        #region 1. Write a program that allows the user to enter a number then print it.
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered: {number}");
        #endregion



        #region 2. Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

        string value = "123abc";
        int result = int.Parse(value); // This will cause an error beacuase we can't convert abc to int


        #endregion

        #region 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        float a = 5.5f;
        float b = 2.2f;
        Console.WriteLine($"Result: {a + b}");
        #endregion

        #region 4. Write C# program that Extract a substring from a given string.
        string text = "Hello, World!";
        string sub = text.Substring(7, 5); //Start position, number of characters to move
        Console.WriteLine(sub); // Output: World
        #endregion

        #region 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        int x = 10;
        int y = x;
        y = 20;
        Console.WriteLine($"x = {x}, y = {y}");
        // We just copy the value of x and then the two variables are indepenednet 
        #endregion

        #region 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 99;
        Console.WriteLine(arr1[0]); // Output: 99
        // both arr1 and arr2 point to the same object in memory so any change on either will effect both
        #endregion

        #region 7. Write C# program that take two string variables and print them as one variable 
        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}");
        #endregion

        #region 8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
        double principal = 1000, rate = 5, time = 2;
        double interest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest = {interest}");
        #endregion

        #region 9. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
        double weight = 98, height = 1.74;
        double bmi = weight / (height * height);
        Console.WriteLine($"BMI = {bmi}");
        #endregion

        #region 10. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
        int temp = 25;
        string res = (temp < 10) ? "Just Cold" : (temp > 30) ? "Just Hot" : "Just Good";
        Console.WriteLine(res);
        #endregion

        #region 11. Write a program that takes the date from the user and displays it in various formats using string interpolation.
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"Today's date: {day} , {month} , {year}");
        Console.WriteLine($"Today's date: {day} / {month} / {year}");
        Console.WriteLine($"Today's date: {day} – {month} – {year}");
        #endregion

        #region 12. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 3 == 0 && num % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        #endregion

        #region 13. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(input < 0 ? "Negative" : "Positive");
        #endregion

        #region 14. Write a program that takes 3 integers from the user then prints the max element and the min element.
        Console.WriteLine("Enter three numbers:");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int max = Math.Max(n1, Math.Max(n2, n3));
        int min = Math.Min(n1, Math.Min(n2, n3));
        Console.WriteLine($"Max element = {max}");
        Console.WriteLine($"Min element = {min}");
        #endregion

        #region 15. Write a program that allows the user to insert an integer number then check If a number is even or odd
        Console.Write("Enter a number: ");
        int evenOdd = int.Parse(Console.ReadLine());
        Console.WriteLine(evenOdd % 2 == 0 ? "Even" : "Odd");
        #endregion

        #region 16. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        Console.Write("Enter a character: ");
        char inputCharacter = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        Console.WriteLine("aeiou".Contains(inputCharacter) ? "Vowel" : "Consonant"); //contains checks of the variable inputCharacter is in one of the letter of the string 'aeiou'
        #endregion

        #region 17. Write a program to input the month number and print the number of days in that month.
        Console.Write("Enter Month Number: ");
        int m = int.Parse(Console.ReadLine());
        int days;

        if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            days = 31;
        else if (m == 4 || m == 6 || m == 9 || m == 11)
            days = 30;
        else if (m == 2)
            days = 28;
        else
            days = -1;

        if (days == -1)
            Console.WriteLine("Invalid month number.");
        else
            Console.WriteLine($"Days in Month: {days}");
        #endregion
    }
}

