//Do While Statements allow you to repeat a block of code while a condition is true.
//A Do While Loop will always execute at least once, even if the condition is false on the first iteration.


/* The following code generates a random number between 1 and 10 until the number 7 is generated.
//The first iteration will always execute, even if the random number is 7.
Random random = new Random();
int currentNumber = 0;
do
{
    currentNumber = random.Next(1, 11); // Generates a random number between 1 and 10
    Console.WriteLine($"The current number is: {currentNumber}");
} while (currentNumber != 7); // Continue until the number 7 is generated
Console.WriteLine("The loop has ended because the number 7 was generated.");*/

/*Write a while statement that iterates only while a random number is greater than 3
Random random = new Random();
int currentNumber = random.Next(1, 11); // Generates a random number between 1 and 10

while (currentNumber >= 3) // Continue while the number is greater than or equal to 3
{
    Console.WriteLine($"The current number is: {currentNumber}");
    currentNumber = random.Next(1, 11); // Generates a new random number between 1 and 10
}
Console.WriteLine($"The current number is {currentNumber}, which is less than 3. The loop has ended.");
//The loop will continue until a number less than 3 is generated.
//The first iteration will only execute if the random number is greater than or equal to 3.*/

/*Using the continue statement to step directly to the Boolean expression of the do while statement.
Random random = new Random();
int currentNumber = random.Next(1, 11); // Generates a random number between 1 and 10
do
{
    currentNumber = random.Next(1, 11); // Generates a new random number between 1 and 10

    if (currentNumber >= 8)
    {
        continue; // Skip the rest of the loop if the number is greater than or equal to 8
    }
    Console.WriteLine($"The current number is: {currentNumber}");
    // The loop will continue until a number less than 8 is generated
}   while (currentNumber != 7); // Continue until the number 7 is generated*/

//Challange activity using do while and while iteration statements
//Role playing game battle challange

/*Random random = new Random();
int heroPoints = 10;
int monsterPoints = 10;
int currentheroAttack = 0;
int currentMonsterAttack = 0;

while (heroPoints > 0 && monsterPoints > 0)
{
    //Hero's turn to attach
    currentheroAttack = random.Next(1, 10); // Generates a random attack value between 1 and 10
    monsterPoints -= currentheroAttack; // Subtract the hero's attack from the monster's points
    Console.WriteLine($"Hero attacked the monster for {currentheroAttack} points. Monster's remaining points: {monsterPoints}");

    //Check if the monster is defeted
    if (monsterPoints <= 0)
    {
        Console.WriteLine("The monster has been defeated! Hero wins!");
        break; // Exit the loop if the monster is defeated
    }

    //Monster's turn to attack
    currentMonsterAttack = random.Next(1, 10); // Generates a random attack value between 1 and 10
    heroPoints -= currentMonsterAttack; // Subtract the monster's attack from the hero's points
    Console.WriteLine($"Monster attacked the hero for {currentMonsterAttack} points. Hero's remaining points: {heroPoints}");

    //Check if the hero is defeated
    if (heroPoints <= 0)
    {
        Console.WriteLine("The hero has been defeated! Monster wins!");
        break; // Exit the loop if the hero is defeated
    }
    
    //Check if the hero and monster are both defeated
    if (heroPoints <= 0 && monsterPoints <= 0)
    {
        Console.WriteLine("Both the hero and monster have been defeated! It's a draw!");
        break; // Exit the loop if both are defeated
    }

    //Check if the hero and monster are both alive
    if (heroPoints > 0 && monsterPoints > 0)
    {
        Console.WriteLine("Both the hero and monster are still alive. The battle continues!");*/


//Examine the difference between the do and while statements
/* This code uses a nullable type string to capture the input, and the will continue to do the activity while the 
string is null*/
/*string? readResult;
bool validEntry = false;
Console.WriteLine("Please enter a string containing at least three characters: ");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your entry is invalid, please try again!");
        }
    }
} while (validEntry == false);*/

//The int.TryParse() can be used to convert a string to an integer and return a boolean to ascertain that it is a valid integer
//It consists of 2 parameters
//The first: the string variable that will be evaluated
//The second: The name of another int variable that will be assigned an int value.

/*string? readResult;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine ("Please type a whole integer number between 5 and 10");

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber == true)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            Console.WriteLine($"Your input value: {numericValue} is valid and has been accepted");
        }
        else
        {
            Console.WriteLine($"You entered {numericValue}, Please enter a number between 5 and 10.");
        }
        
    }
    else
    {
        Console.WriteLine("You entered an invalid number, please try again.");
    }
} while (!(validNumber && numericValue >= 5 && numericValue <= 10));*/


/*Write code that validates a string input
string? readResult;
bool validString = false;
Console.WriteLine("Enter your role name: Administrator, Manager, or User");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Trim().ToLower() == "administrator")
        {
            validString = true;
            Console.WriteLine($"Your input value ({readResult}) has been accepted");
        }
        else if (readResult.Trim().ToLower() == "manager")
        {
            validString = true;
            Console.WriteLine($"Your input value ({readResult}) has been accepted");
        }
        else if (readResult.Trim().ToLower() == "user")
        {
            validString = true;
            Console.WriteLine($"Your input value ({readResult}) has been accepted");
        }
        else
        {
            validString = false;
            Console.WriteLine($"The role name that you entered, {readResult}, is not valid. Reenter your role name (Administrator, Manager, or User)");
        }
    }
} while (validString == false);*/

// Write code that processes the contents of a string array
string [] myStrings = new string[4] {"I like pizza.", "I like roast chicken.", "I like salad.", "I like all three of the menu choices."};
int periodLocation = -1;


foreach (string myString in myStrings) 
{
    
   periodLocation = myString.IndexOf('.');
    while (periodLocation >= 0)
    {
        string mySubstring = myString.Substring(0, periodLocation);
        Console.WriteLine(mySubstring);
        periodLocation = myString.IndexOf('.', periodLocation + 1); // Find the next period in the string
    }
}
Console.WriteLine("The Loop has ended.");



