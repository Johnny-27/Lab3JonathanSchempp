//while loop

while (true)
{
Console.WriteLine ("User, pick a number between 10 and 99. To leave this loop, please type exit.");
string userinput = Console.ReadLine();
if (userinput == "exit")
{
    Console.WriteLine ("Thank you for playing! Now moving to part 2...");
    break;
}

int usernumber = Convert.ToInt32 (userinput);
if (usernumber > 99 || usernumber < 10)
{
    Console.WriteLine("User's choice is an invalid number. Number must be between 10 and 99");
        continue;
}
if (usernumber % 23 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green; 
        Console.Clear();
        continue;   
    }
else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        continue;
    }
} 

//Do While Loop

do 
{
Console.WriteLine ("Welcome to part 2");
Console.WriteLine ("User, pick a number between 10 and 99. To leave this loop, please type exit.");
string userinput = Console.ReadLine();
if (userinput == "exit")
{
    Console.WriteLine ("Thank you for playing! Now moving to part 3...");
    break;
}

int usernumber = Convert.ToInt32 (userinput);
if (usernumber > 99 || usernumber < 10)
{
    Console.WriteLine("User's choice is an invalid number. Number must be between 10 and 99");
        continue;
}
if (usernumber % 34 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green; 
        Console.Clear();
        continue;   
    }
else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        continue;
    }
} while (true);

//For loop

for (bool loop = true; loop == true;)
{
Console.WriteLine ("Welcome to part 3");
Console.WriteLine ("User, pick a number between 10 and 99. To leave this loop, please type exit.");
string userinput = Console.ReadLine();
if (userinput == "exit")
{
    Console.WriteLine ("Thank you for playing! You have completed this guessing game.");
    break;
}

int usernumber = Convert.ToInt32 (userinput);
if (usernumber > 99 || usernumber < 10)
{
    Console.WriteLine("User's choice is an invalid number. Number must be between 10 and 99");
        continue;
}
if (usernumber % 33 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green; 
        Console.Clear();
        continue;   
    }
else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        continue;
    }
}






