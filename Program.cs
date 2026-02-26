// Simula's Soup

using System.Globalization;

// Initialisation
string userFlavourInput = "Invalid";
bool validUserFlavourChoice = false;

string userIngredientInput = "Invalid";
bool validUserIngredientChoice = false;

string userDishInput = "Invalid";
bool validUserDishChoice = false;

(string Flavour, string Ingredient, string Dish) mealTuple = ("","","");


// User Introduction
Console.WriteLine("Welcome dear traveller.  You look hungry, allow me to cook for you.  ");
Console.WriteLine();
Console.WriteLine("Please choose a flavour for your meal, the options are: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Array powders = Enum.GetValues(typeof(Powder));
foreach (Powder powder in powders)
{
    Console.WriteLine(powder);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;


// Get Flavour choice
while (!validUserFlavourChoice)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Flavour: ");
    userFlavourInput = Console.ReadLine() ?? "";
    Console.ForegroundColor = ConsoleColor.Cyan;
    // Convert input to Title case
    TextInfo myTI = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture.
    string userFlavourChoice = myTI.ToTitleCase(userFlavourInput);

    // Check if user input is an allowed value
    validUserFlavourChoice = Enum.IsDefined(typeof(Powder), userFlavourChoice);

    // Handle invalid input
    if (!validUserFlavourChoice)
    {
        Console.WriteLine($"Unfortunately, {userFlavourChoice} is not a valid option - these are your choices: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (Powder powder in powders)
        {
            Console.WriteLine(powder);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    mealTuple.Flavour = userFlavourChoice;

}

Console.WriteLine();
Console.WriteLine("Please choose a main ingredient for your meal, the options are: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Array ingredients = Enum.GetValues(typeof(MainIngredient));
foreach (MainIngredient ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;

// Get Main ingredient choice
while (!validUserIngredientChoice)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Main Ingredient: ");
    userIngredientInput = Console.ReadLine() ?? "";
    Console.ForegroundColor = ConsoleColor.Cyan;

    // Convert input to Title case
    TextInfo myTI = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture.
    string userIngredientChoice = myTI.ToTitleCase(userIngredientInput);

    // Check if user input is an allowed value
    validUserIngredientChoice = Enum.IsDefined(typeof(MainIngredient), userIngredientChoice);

    // Handle invalid input
    if (!validUserIngredientChoice)
    {
        Console.WriteLine();
        Console.WriteLine($"Unfortunately, {userIngredientChoice} is not a valid option - these are your choices: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (MainIngredient ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    mealTuple.Ingredient = userIngredientChoice;
}

Console.WriteLine();
Console.WriteLine("Please choose a type of dish, the options are: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Array dishes = Enum.GetValues(typeof(FoodType));
foreach (FoodType dish in dishes)
{
    Console.WriteLine(dish);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;

// Get dish choice
while (!validUserDishChoice)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Dish: ");
    userDishInput = Console.ReadLine() ?? "";
    Console.ForegroundColor = ConsoleColor.Cyan;

    // Convert input to Title case
    TextInfo myTI = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture.
    string userDishChoice = myTI.ToTitleCase(userDishInput);

    // Check if user input is an allowed value
    validUserDishChoice = Enum.IsDefined(typeof(FoodType), userDishChoice);

    // Handle invalid input
    if (!validUserDishChoice)
    {
        Console.WriteLine();
        Console.WriteLine($"Unfortunately, {userDishChoice} is not a valid option - these are your choices: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (FoodType dish in dishes)
        {
            Console.WriteLine(dish);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    mealTuple.Dish = userDishChoice;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Great choice, I hope that you enjoy your {mealTuple.Flavour} {mealTuple.Ingredient} {mealTuple.Dish}");
Console.ForegroundColor = ConsoleColor.White;


// Type Definitions
enum Powder
{
    Spicy,
    Salty,
    Sweet
};

enum FoodType
{
    Gumbo,
    Soup,
    Stew
};

enum MainIngredient
{
    Chicken,
    Mushroom,
    Carrot,
    Potato
};