//Is it possible that attempting to change the data type of a value would cause an error?

//Let's say that we try to add a string to an integer. This would cause an error because the two data types are not compatible.
//In this case, we would need to convert the string to an integer before we can add it to the other integer.
//int first = 2;
//string second = "4";
//int result = first + second; // This will cause an error because we are trying to add an integer to a string
//Console.WriteLine(result); // This line will not be executed because of the error above

//But why can't we just convert the string to an integer automatically?
//For example, you can do the opposite and concatenate a number to a string without any issues.
//int first = 2;
//string second = "4";
//string result = first + second; // This will work because we are concatenating an integer to a string
//Console.WriteLine(result); // This will print "24" because the integer is converted to a string and concatenated with the other string

//So why can't the C# compiler just do the same thing in the first case?
//The reason is that the C# compiler is designed to be strict about data types and conversions.
//This is to prevent errors and ensure that the code behaves as expected.
//If the compiler allowed automatic conversions between incompatible data types, it could lead to unexpected behavior and bugs in the code.

//If you need to change a value from original data type to another, you must perform a data type conversion explicitly.
//There are several ways to do this in C#:
//1. Using a helper method on the data type itself (e.g. int.Parse, double.Parse, etc.)
//2. Using a helper method on the variable (e.g. ToString, ToInt32, etc.)
//3. Using the Convert class (e.g. Convert.ToInt32, Convert.ToDouble, etc.)

//Is it possible that attempting to change the data type of a value would result in a loss of information?
//Yes, it is possible that attempting to change the data type of a value could result in a loss of information.
/*int myInt = 3;
Console.WriteLine($"myInt: {myInt}"); // This will print 3
int myDecimal = myInt;
Console.WriteLine($"myDecimal: {myDecimal}");*/
//With the above code, we are converting an integer to a decimal. This is a safe conversion because there is no loss of information.
//This is called a widening conversion because we are converting a smaller data type (int) to a larger data type (decimal).
//In this case, the value of myInt is 3 and the value of myDecimal is also 3. There is no loss of information because both data types can represent the same value.
//Also, when you perform a widening conversion, the compiler will do an implicit conversion for you. 
//This means that you don't have to do anything special to convert the value from one data type to another. 
//The compiler will take care of it for you.

//To do the opposite, you need to perform a narrowing conversion.
//This is when you convert a larger data type (decimal) to a smaller data type (int).
//In this case, there is a possibility of loss of information because the decimal data type can represent values that are not whole numbers (e.g. 3.14, 2.5, etc.).
//If you try to convert a decimal value that is not a whole number to an int, the compiler will give you an error because it cannot guarantee that the conversion will be safe.
//In such cases, you need to use a helper method to perform the conversion explicitly, such a casting the value to the desired data type.
/*decimal myDecimal = 3.14m;
Console.WriteLine($"myDecimal: {myDecimal}"); // This will print 3.14
int myInt = (int)myDecimal; // This will cause a loss of information because we are converting a decimal to an int
Console.WriteLine($"myInt: {myInt}");*/

//In the example below, you will see that casting from decimal to float is a narrowing conversion, with loss of precision
//decimal myDecimal = 1.23456789m;
//float myFloat = (float)myDecimal;

//Console.WriteLine($"Decimal: {myDecimal}");
//Console.WriteLine($"Float: {myFloat}");

//Using the ToString() method to convert a number to a string.
//On most data types, you can use the ToString() method to convert a number to a string.
//It is a widening conversion because the string data type can represent any value, including numbers, characters, and symbols.

//int first = 5;
//int second = 10;
//string message = first.ToString() + second.ToString(); // This will concatenate the two integers as strings
//Console.WriteLine(message); // This will print "510" because the two integers are concatenated as strings

//Converting a string to an integer using the int.Parse() method.
//This is a narrowing conversion because the string data type can represent any value, including numbers, characters, and symbols.
//If the string cannot be converted to an integer, the int.Parse() method will throw an exception.
//string firstNumber = "5";
//string secondNumber = "7";
//int sum = int.Parse(firstNumber) + int.Parse(secondNumber);
//Console.WriteLine(sum);

//What if the string cannot be converted to an integer?
//In this case, the int.Parse() method will throw an exception. You can use the int.TryParse() method to safely convert a string to an integer without throwing an exception.
//string value1 = "5";
//string value2 = "7";
//int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//Console.WriteLine(result);

//When should use the Convert class as opposed to the int.Parse() method?
//The Convert class is a more general-purpose class that can be used to convert between different data types.
//It is more flexible than the int.Parse() method because it can handle a wider range of data types and conversions.
//The int.Parse() method is specifically designed to convert strings to integers, so it is more efficient for that purpose.
//If you are only converting strings to integers, it is better to use the int.Parse() method because it is faster and more efficient.
//If you are converting between different data types, it is better to use the Convert class because it is more flexible and can handle a wider range of conversions.
//The Convert class also has methods for converting between other data types, such as double, float, and decimal.


//int value = (int)1.5m;//casting truncates
//Console.WriteLine(value);

//int value2 = Convert.ToInt32(1.5m); //converting rounds up
//Console.WriteLine(value2);

//Examine the TryParse() method
//Using int.Parse can cause runtime errors if a string cannot be converted
//string name = "Bob";
//Console.WriteLine(int.Parse(name));

//Using TryParse() method does certain things at the same time
//1) It attempts to parse a string into a given numeric type
//2) If it is successful, it stores the converted value in an out parameter
//3) It returns a bool to indicate whether the action succeeded or failed
//When calling TryParse(), you must provide an out parameter to store the converted value
/*string valueNew = "bad";
int resultNew = 0;
if (int.TryParse(valueNew, out resultNew))
{
    Console.WriteLine($"Measurement: {resultNew}");
}
else
{
    Console.WriteLine($"Unable to report the measurement: {valueNew} is not a number.");
}
if (resultNew > 0)
{
    Console.WriteLine($"Measurement (w/offset): {resultNew + 10}");
}*/


//Exercise - Complete a challenge to combine string array values as strings and as integers
/*string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal total = 0;
string message = "";
foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal result))
    {
        total += result;
    }
    else
    {
        message += value; 
    }
}
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Message: {message}");*/

//Exercise - Complete a challenge to output math operations as specific number types
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Your code here to set result1
//Hint: You need to round the result to the nearest whole number (not just truncate it)
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2:, display the result as an int: {result1}");

//Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

