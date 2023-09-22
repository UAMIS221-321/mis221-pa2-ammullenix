//***** Main *****

DisplayMenu();

// Priming Read
string userChoice = Console.ReadLine();

while (userChoice != "3"){
    Route(userChoice);

    // Update Read
    DisplayMenu();
    userChoice = Console.ReadLine();
}

// **** End Main ****

static void DisplayMenu(){
    System.Console.WriteLine("Welcome to the ASLS's Parks website!\n1: Compass\n2: Vistor Fees\n3: Exit");
}

static void Route(string userChoice){
    if(userChoice == "1"){
        DisplayCompass();
    } else {
        if(userChoice == "2"){
        DisplayVisitorFees();
        } else{
            DisplayError();
        }
    }
}

static void DisplayCompass(){
    System.Console.WriteLine("You called the Compass!");
    Pause();
}

static void DisplayVisitorFees(){
    System.Console.WriteLine("You called vistor fees!");
    Pause();
}

static void DisplayError(){
    System.Console.WriteLine("Invalid option, please enter a valid menu item");
    Pause();
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
}