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
    int degreesTurned = 0;

System.Console.WriteLine("Welcome to the Compass! Let's retrace your steps.");
string userInput = EnterDirection();

while(userInput != "CANCEL"){
    if(userInput == "right"){
        degreesTurned += 90;
    } else if (userInput == "left"){
        degreesTurned = degreesTurned - 90;
    } else {
        DisplayError();
        Pause();
    }
    userInput = EnterDirection();

if(degreesTurned == 90 || degreesTurned == -270){
    System.Console.WriteLine("You are facing East.");
} else if (degreesTurned == 180 || degreesTurned == -180){
    System.Console.WriteLine("You are facing South.");
} else if (degreesTurned == 270 || degreesTurned == -90){
    System.Console.WriteLine("You are facing West.");
} else if (degreesTurned == 360 || degreesTurned == 0){
    System.Console.WriteLine("You are facing North.");
} 

}

if(degreesTurned == 90){
    System.Console.WriteLine("You are facing East.");
} else if (degreesTurned == 180){
    System.Console.WriteLine("You are facing South.");
} else if (degreesTurned == 270){
    System.Console.WriteLine("You are facing West.");
} else if (degreesTurned == 360){
    System.Console.WriteLine("You are facing North.");
} 
    Pause();
}

static string EnterDirection(){
    System.Console.WriteLine("Did you turn right or left? Enter CANCEL to stop.");
    return Console.ReadLine();
}

static void DisplayVisitorFees(){
    System.Console.WriteLine("You called Visitor's Fees!");
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