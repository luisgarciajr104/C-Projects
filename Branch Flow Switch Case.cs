/*//Initial declaration of int employeeLevel variable and string employeeName variable
int employeeLevel = 201;
string employeeName = "Howard Hancock";
//Null initial declaration of title variable
string title = "";

//switch-case statement based on employeeLevel variable
//You must use the "break;" or "return;" keyword between each switch section
//to avoid errors
switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");*/


/*//Modify a switch section to include multiple lables
int employeeLevel = 100;
string employeeName = "Howard Hancock";
//Null initial declaration of title variable
string title = "";

switch (employeeLevel)
{
    /*You can enter one case after 
    another to assign multiple cases to one label
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");*/

//Complete challange activity using switch statements
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{ 
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;  
    case "L":
        size = "Large";
        break;
    default:
        size = "One size fits all";
        break;
}



Console.WriteLine($"Product: {size} {color} {type}");