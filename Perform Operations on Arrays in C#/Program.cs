/*string[] pallets = ["B14", "A12", "C10", "B11", "A13", "C11", "B12", "A14", "C12", "B13"];

Console.WriteLine("Sorted Pallets:");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--> {pallet}");     
}   


// Sort the pallets in reverse order
Console.WriteLine("\nSorted Pallets in Reverse Order:");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--> {pallet}");     
}*/


/*Clear and Resize
string [] pallets = {"PLT14", "PLT2", "PLT63", "PLT84", "PLT35", "PLT106", "PLT97", "PLT28", "PLT49", "PLT50"};
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"$: Cleared 2 pallets:... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--> {pallet}");     
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ...... count: {pallets.Length}");

pallets[4] = "PLT218";
pallets[5] = "PLT219";
foreach (var pallet in pallets)
{
    Console.WriteLine($"--> {pallet}");     
}

//Resize Array to Reduce the size
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ...... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"--> {pallet}");     
}*/

/*Split data type's Array methods
//Using ToCharArray() method to convert a string to a char array
string value = "abc1233";
char[] valueArray = value.ToCharArray();
//Now we will reverse the char array and then combine it back to a new string
Array.Reverse(valueArray);
string reversedValue = new string(valueArray);
Console.WriteLine(reversedValue);
//We can also use the Join() method to join the char array back to a string separated by a comma
string joinedValue = string.Join(",", valueArray);
Console.WriteLine(joinedValue);
//Then we can use the Split() method to split the string back to a char array
string[] items = joinedValue.Split(',');
foreach (var item in items)
{
    Console.WriteLine(item);
}*/

/*Complete a challenge to reverse words in a sentence
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
string[] reversedWords = new string[words.Length];
for (int i = 0; i < words.Length; i++)
{
    char[] wordArray = words[i].ToCharArray();
    Array.Reverse(wordArray);
    reversedWords[i] = new string(wordArray);
}

string reversedPangram = string.Join(" ", reversedWords);
Console.WriteLine(reversedPangram);*/

//Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
//We have to parse the individual orders from the string, sort them in ascending order, 
//and label the orders that are not exactly 4 characters long as "Error". (Example: "B123" is valid, "C15" is invalid)

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);
foreach (var order in orders)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order}\t\t- Error");
    }
    else
    {
        Console.WriteLine($"{order}");
    }
}