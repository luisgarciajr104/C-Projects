/* These ////Console.Writelines use the equality operator to evaluate the boolean state of the operations,
the output would be either True or False*/
//////Console.WriteLine ("a" == "a");
////Console.WriteLine ("a" == "A");
////Console.WriteLine(1 == 2);

//string myValue = "a";
////Console.WriteLine(myValue == "a");

//This line of code will return false as the space is a character that is evaluated
////Console.WriteLine("a" == "a ");

/*You can use functions included on the equality comparison to "massage" the data or reformat the data
to ingnore letter cases, punctuation, and spaces between characters*/

/* This example uses the functions "ToLower" and "Trim" to ingnore case and spaces*/
//tring value1 = " a";
//string value2 = "A ";
////Console.WriteLine($"\n{value1.Trim().ToLower() == value2.Trim().ToLower()}");

//Using the Inequality Operation
////Console.WriteLine("a" != "a");
////Console.WriteLine("a" != "A");
////Console.WriteLine(1 != 2);

////Console.WriteLine(myValue != "a");

//Using Comparison Operators
//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//Methods that return a boolean
//Some string methods have a boolean return type
//Examples of these include:
//Contains, StartsWith, EndsWith, and IndexOf
//The Contains method returns true if the string contains the specified value
//string pangram = "The quick brown fox jumps over the lazy dog";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//Logical Negation
//The logical negation operator is used to reverse the value of a boolean
//The logical negation operator is represented by the exclamation mark
//The logical negation operator is used to reverse the value of a boolean
//These two lines of code will both return false
//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));


//Inequality Operator vs Logical Negation
//The inequality operator is used to compare two values
//The inequality operator is represented by the exclamation mark
//The inequality operator is used to compare two values
//int a = 7;
//int b = 6;
//Console.WriteLine(a != b); //Output: True
//string s1 = "Hello";
//string s2 = "Hello";
//Console.WriteLine(s1 != s2); //Output: False

//Conditional Operator
//The conditional operator is used to evaluate a boolean expression
//The conditional operator is represented by the question mark
//The format of the conditional operator is as follows:
//<evaluate this condition> ? <value_if_true, return this value> : <value_if_false, return this value>
//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Your discount for this total sale amount of {saleAmount} is: {discount}");

//You can compact the conditional operator to a single line of code
//This line of code will return the same result as the previous example
//The variable discount gets converted to the value of the conditional operator
//Console.WriteLine($"Your discount for this total sale amount of {saleAmount} is: {(saleAmount > 1000 ? 100 : 50)}");

//Challange activity using the conditional operator
//The following code will randomly generate a number between 0 and 1
//The number will be used to simulate a coin flip
//The result of the coin flip will be either heads or tails
//The code uses the conditional operator to determine the result of the coin flip
//If the variable flip is 0, the result is heads, if the variable flip is 1, the result is tails
//Random coinFlip = new Random();
//int flip = coinFlip.Next(0, 2);
//Console.WriteLine($"The result of the coin flip is: {(flip == 0 ? "Heads" : "Tails")}");

//This is a challange activity using all the concepts learned in this section
//This challange will implement business logic to determine access to a system based on the user's role and career level
string permission = "User";
int careerLevel = 19;
string message = "";
//The following code will use the permission variable and the careerLevel variable to determine the output message
//The code will use the Contains() method to check if the permission variable contains the string "Admin"
//The code will use the logical operators to check if the careerLevel variable is greater than, equal to or less than 55
if (permission.Contains("Admin") && careerLevel > 55)
{
    message = "Welcome, Super Admin user.";
}
else if (permission.Contains("Admin") && careerLevel <= 55)
{
    message = "Welcome, Admin user.";
}
else if (permission.Contains("Manager") && careerLevel >= 20)
{
    message = "Contact an Admin for access to the system.";
}
else if (permission.Contains("Manager") && careerLevel < 20)
{
    message = "You do not have sufficient privileges.";
}
else
{
    message = "You do not have access to the system";
}
//The following code will use the message variable to display the output message
Console.WriteLine(message);