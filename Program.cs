// Simula's Soup

// Create a program with an enumeration to recreate the locking mechanism
// Open > *close* > Closed > *lock* > Locked
// Locked > *unlock* > Closed > *open* > Open

using System.Globalization;

// Initialise
ChestState currentState = ChestState.Locked;

// User Introduction
Console.WriteLine("Welcome dear traveller.  I see that you have discovered the Great Chest of Flange.");

Console.WriteLine("The chest can be in any one of three states: ");

Array stateOptions = Enum.GetValues(typeof(ChestState));
foreach (ChestState state in stateOptions)
{
    Console.WriteLine(state);
}
Console.WriteLine();


Console.WriteLine("You have four possible actions at any given time: ");
Array userOptions = Enum.GetValues(typeof(UserChoice));
foreach (UserChoice choice in userOptions)
{
    Console.WriteLine(choice);
}
Console.WriteLine();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;


// Main game loop

while (true)
{
    Console.WriteLine($"The chest is currently {currentState}, what would you like to do to it?");
    string userInput = Console.ReadLine() ?? ""; // Null-coalescing operator (??) is to provide a default value in case of null

    // Convert input to Title case
    TextInfo myTI = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture.
    string userAction = myTI.ToTitleCase(userInput);

    // Check if user input is an allowed value (present in UserChoice enum)
    bool validUserChoice = Enum.IsDefined(typeof(UserChoice), userAction);

    // Handle invalid input
    if (!validUserChoice)
    {
        Console.WriteLine($"Unfortunately, {userAction} is not a valid options - these are your choices: ");
        foreach (UserChoice choice in userOptions)
        {
            Console.WriteLine(choice);
        }
        Console.WriteLine();
    }


    else if (currentState == ChestState.Locked)
    {
        if (userAction == "Unlock")
        {
            Console.Write($"The chest was in a {currentState} state, you wished to {userAction} it,  ");
            currentState = ChestState.Closed;
            Console.WriteLine($"it is now {currentState}.");
        }
        else
        {
            Console.Write($"The chest was {currentState} state, you wished to {userAction} it,  ");
            Console.WriteLine($"it is still {currentState}!");
        }

    }
    else if (currentState == ChestState.Closed)
    {
        if (userAction == "Lock")
        {
            Console.Write($"The chest was in a {currentState} state, you wished to {userAction} it,  ");
            currentState = ChestState.Locked;
            Console.WriteLine($"it is now {currentState}.");
        }
        else if (userAction == "Open")
        {
            Console.Write($"The chest was in a {currentState} state, you wished to {userAction} it,  ");
            currentState = ChestState.Open;
            Console.WriteLine($"it is now {currentState}!");
        }
        else
        {
            Console.Write($"The chest was {currentState} state, you wished to {userAction} it,  ");
            Console.WriteLine($"it is still {currentState}!");
        }

    }
    else if (currentState == ChestState.Open)
    {
        if (userAction == "Close")
        {
            Console.Write($"The chest was in a {currentState} state, you wished to {userAction} it,  ");
            currentState = ChestState.Closed;
            Console.WriteLine($"it is now {currentState}.");
        }
        else if (userAction == "Open")
        {
            Console.Write($"The chest was in a {currentState} state, you wished to {userAction} it,  ");
            Console.WriteLine($"it is still {currentState}!");
        }
        else
        {
            Console.Write($"The chest was {currentState} state, you wished to {userAction} it,  ");
            Console.WriteLine($"it is still {currentState}!");
        }

    }


}

// Type Definitions
enum UserChoice
{
    Open,
    Close,
    Unlock,
    Lock
};

enum ChestState
{
    Open,
    Closed,
    Locked
};