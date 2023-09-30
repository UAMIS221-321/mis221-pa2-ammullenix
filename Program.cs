//***** Menu *****

DisplayMenu();

// Priming Read
string userChoice = Console.ReadLine();

while (userChoice != "3"){
    Route(userChoice);

    // Update Read
    DisplayMenu();
    userChoice = Console.ReadLine();
}

// **** End Menu ****

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


// Compass

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
    }
    userInput = EnterDirection();
}

if(degreesTurned == 90 || degreesTurned == -270){
    System.Console.WriteLine("You are facing East.");
} else if (degreesTurned == 180 || degreesTurned == -180){
    System.Console.WriteLine("You are facing South.");
} else if (degreesTurned == 270 || degreesTurned == -90){
    System.Console.WriteLine("You are facing West.");
} else if (degreesTurned == 360 || degreesTurned == 0){
    System.Console.WriteLine("You are facing North.");
} 
    Pause();
}

static string EnterDirection(){
    System.Console.WriteLine("Did you turn right or left? Enter CANCEL to stop.");
    return Console.ReadLine();
}

// End Compass

//Visitor's Fees

static void DisplayVisitorFees(){
    const double CHILD_DISCOUNT = 0.8;
    const double STATE_TAX = 5;
    const double FED_TAX = 1.09;
    const int TICKET = 12;

    int childrenNumber = 0;
    int vehicleFee = 0;

    double amountDue = 0;

    System.Console.WriteLine("Welcome to Park Fees!");
    System.Console.WriteLine("Please enter the amount of attendees.");
    int attendeeNumber = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Do you have any children in your party?\n1. Yes\n2. No");
    string userInput = Console.ReadLine();
    if(userInput == "1"){
        System.Console.WriteLine("Please enter the amount of children attending.");
        childrenNumber += int.Parse(Console.ReadLine());
    } else if (userInput == "2"){
        childrenNumber += 0;
    } else {
        DisplayError();
        Pause();
    }

    System.Console.WriteLine("Did you arrive in an RV or other vehicle?\n1. RV\n2. Other Vehicle");
    string userChoice = Console.ReadLine();
    if(userChoice == "1"){
        vehicleFee += 20;
    } else if (userChoice == "2"){
        vehicleFee += 10;
    } else{
        DisplayError();
    }

    double totalFees = ((attendeeNumber * TICKET - ((childrenNumber*TICKET)*CHILD_DISCOUNT)) + vehicleFee);

    double feeFedTax = totalFees * FED_TAX;

    if(attendeeNumber >= 6){
        amountDue += feeFedTax + STATE_TAX;
        System.Console.WriteLine("The amount due is " + amountDue);
    } else if (attendeeNumber < 6){
        amountDue += feeFedTax;
        System.Console.WriteLine("The amount due is " + amountDue);
    }

    System.Console.WriteLine("Please enter the amount you are paying.");
    double amountPaid = double.Parse(Console.ReadLine());

    if(amountPaid < amountDue){
        System.Console.WriteLine("Transaction cancelled due to insufficient funds. Please try again.");
    } else if (amountPaid == amountDue){
        System.Console.WriteLine("You have paid the amount due. Thank you and enjoy your stay at the state parks!");
    } else if (amountPaid > amountDue){
        System.Console.WriteLine("Transaction cancelled due to oversufficient funds. Please try again and pay only the amount due.");
    }
    Pause();
}

//End Visitor Fees

static void DisplayError(){
    System.Console.WriteLine("Invalid option, please enter a valid menu item");
    Pause();
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
}