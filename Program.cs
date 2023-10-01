//***** Menu *****

DisplayLogo();
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
    System.Console.WriteLine("Welcome to the ASPS's Parks application!\n1: Compass\n2: Park Fees\n3: Exit");
}

static void Route(string userChoice){
    if(userChoice == "1"){
        DisplayCompass();
    } else {
        if(userChoice == "2"){
        DisplayParkFees();
        } else{
            DisplayError();
        }
    }
}
 static void DisplayLogo(){
    System.Console.WriteLine(@"          /\
         /**\
        /****\   /\
       /      \ /**\
      /  /\    /    \        /\    /\  /\      /\            /\/\/\  /\
     /  /  \  /      \      /  \/\/  \/  \  /\/  \/\  /\  /\/ / /  \/  \
    /  /    \/ /\     \    /    \ \  /    \/ /   /  \/  \/  \  /    \   \
   /  /      \/  \/\   \  /      \    /   /    \
__/__/_______/___/__\___\__________________________________________________");
 }

// Compass

static void DisplayCompass(){
    int degreesTurned = 0;

    CompassLogo();

    System.Console.WriteLine("Welcome to the Compass! Let's retrace your steps.");
    //Priming Read
    string userInput = EnterDirection();

    //Must enter CANCEL to exit, cannot distiguish upper and lowercase
    while(userInput != "CANCEL"){
        if(userInput == "right" || userInput == "Right" || userInput == "RIGHT"){
            degreesTurned += 90;
        } else if (userInput == "left" || userInput == "Left" || userInput == "LEFT"){
            degreesTurned = degreesTurned - 90;
        } else {
            DisplayError();
        }
        //Update Read
        userInput = EnterDirection();
    }

    if(degreesTurned == 90 || degreesTurned == -270){
        EastLogo();
        System.Console.WriteLine("You are facing East.");
    } else if (degreesTurned == 180 || degreesTurned == -180){
        SouthLogo();
        System.Console.WriteLine("You are facing South.");
    } else if (degreesTurned == 270 || degreesTurned == -90){
        WestLogo();
        System.Console.WriteLine("You are facing West.");
    } else if (degreesTurned == 360 || degreesTurned == 0){
        NorthLogo();
        System.Console.WriteLine("You are facing North.");
    } 
    Pause();
}

static string EnterDirection(){
    System.Console.WriteLine("Did you turn right or left? Enter CANCEL to stop.");
    return Console.ReadLine();
}

static void CompassLogo(){
    System.Console.WriteLine(@"|<><><><><><><><><><><><><><><><><><><><><><><>|
|                      *                       |
|   /\~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~/\    |
|  (o )                .                ( o)   |
|   \/               .` `.               \/    |
|   /\             .`     `.             /\    |
|  (             .`         `.             )   |
|   )          .`      N      `.          (    |
|  (         .`   A    |        `.         )   |
|   )      .`     <\> )|(         `.      (    |
|  (     .`         \  |  (         `.     )   |
|   )  .`         )  \ |    (         `.  (    |
|    .`         )     \|      (         `.     |
|  .`     W---)--------O--------(---E     `.   |
|   `.          )      |\     (          .`    |
|   ) `.          )    | \  (          .` (    |
|  (    `.          )  |  \          .`    )   |
|   )     `.          )|( <\>      .`     (    |
|  (        `.         |         .`        )   |
|   )         `.       S       .`         (    |
|  (            `.           .`            )   |
|   \/            `.       .`            \/    |
|   /\              `.   .`              /\    |
|  (o )               `.`               ( o)   |
|   \/~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~\/    |
|                     -|-                   LGB|
|<><><><><><><><><><><><><><><><><><><><><><><>|");
}

static void NorthLogo(){
    System.Console.WriteLine(@"|<><><><><><><><><><><><><><><><><><><><><><><>|
|                      *                       |
|   /\~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~/\    |
|  (o )                .                ( o)   |
|   \/               .` `.               \/    |
|   /\             .`     `.             /\    |
|  (             .`         `.             )   |
|   )          .`      N      `.          (    |
|  (         .`        ^        `.         )   |
|   )      .`         <\>         `.      (    |
|  (     .`            |  (         `.     )   |
|   )  .`         )    |    (         `.  (    |
|    .`         )      |      (         `.     |
|  .`     W---)--------O--------(---E     `.   |
|   `.          )      |      (          .`    |
|   ) `.          )    |    (          .` (    |
|  (    `.          )  |             .`    )   |
|   )     `.          )|(          .`     (    |
|  (        `.         |         .`        )   |
|   )         `.       S       .`         (    |
|  (            `.           .`            )   |
|   \/            `.       .`            \/    |
|   /\              `.   .`              /\    |
|  (o )               `.`               ( o)   |
|   \/~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~\/    |
|                     -|-                   LGB|
|<><><><><><><><><><><><><><><><><><><><><><><>|
");
}

static void EastLogo(){
    System.Console.WriteLine(@"|<><><><><><><><><><><><><><><><><><><><><><><>|
|                      *                       |
|   /\~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~/\    |
|  (o )                .                ( o)   |
|   \/               .` `.               \/    |
|   /\             .`     `.             /\    |
|  (             .`         `.             )   |
|   )          .`      N      `.          (    |
|  (         .`        |        `.         )   |
|   )      .`         )|(         `.      (    |
|  (     .`         )  |  (         `.     )   |
|   )  .`         )    |    (         `.  (    |
|    .`         )      |      (   ^     `.     |
|  .`     W---)--------O--------(-/>E     `.   |
|   `.          )      |      (   v      .`    |
|   ) `.          )    |    (          .` (    |
|  (    `.          )  |  (          .`    )   |
|   )     `.          )|(          .`     (    |
|  (        `.         |         .`        )   |
|   )         `.       S       .`         (    |
|  (            `.           .`            )   |
|   \/            `.       .`            \/    |
|   /\              `.   .`              /\    |
|  (o )               `.`               ( o)   |
|   \/~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~\/    |
|                     -|-                   LGB|
|<><><><><><><><><><><><><><><><><><><><><><><>|
");
}

static void SouthLogo(){
    System.Console.WriteLine(@"|<><><><><><><><><><><><><><><><><><><><><><><>|
|                      *                       |
|   /\~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~/\    |
|  (o )                .                ( o)   |
|   \/               .` `.               \/    |
|   /\             .`     `.             /\    |
|  (             .`         `.             )   |
|   )          .`      N      `.          (    |
|  (         .`        |        `.         )   |
|   )      .`         )|(         `.      (    |
|  (     .`            |  (         `.     )   |
|   )  .`         )    |    (         `.  (    |
|    .`         )      |      (         `.     |
|  .`     W---)--------O--------(---E     `.   |
|   `.          )      |      (          .`    |
|   ) `.          )    |    (          .` (    |
|  (    `.          )  |             .`    )   |
|   )     `.          </>          .`     (    |
|  (        `.         v         .`        )   |
|   )         `.       S       .`         (    |
|  (            `.           .`            )   |
|   \/            `.       .`            \/    |
|   /\              `.   .`              /\    |
|  (o )               `.`               ( o)   |
|   \/~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~\/    |
|                     -|-                   LGB|
|<><><><><><><><><><><><><><><><><><><><><><><>|
");
}

static void WestLogo(){
    System.Console.WriteLine(@"|<><><><><><><><><><><><><><><><><><><><><><><>|
|                      *                       |
|   /\~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~/\    |
|  (o )                .                ( o)   |
|   \/               .` `.               \/    |
|   /\             .`     `.             /\    |
|  (             .`         `.             )   |
|   )          .`      N      `.          (    |
|  (         .`        |        `.         )   |
|   )      .`         )|(         `.      (    |
|  (     .`         )  |  (         `.     )   |
|   )  .`         )    |    (         `.  (    |
|    .`     ^   )      |      (         `.     |
|  .`     W<\-)--------O--------(---E     `.   |
|   `.      v   )      |      (          .`    |
|   ) `.          )    |    (          .` (    |
|  (    `.          )  |  (          .`    )   |
|   )     `.          )|(          .`     (    |
|  (        `.         |         .`        )   |
|   )         `.       S       .`         (    |
|  (            `.           .`            )   |
|   \/            `.       .`            \/    |
|   /\              `.   .`              /\    |
|  (o )               `.`               ( o)   |
|   \/~~~~~~~~~~~~~~~~~|~~~~~~~~~~~~~~~~~\/    |
|                     -|-                   LGB|
|<><><><><><><><><><><><><><><><><><><><><><><>|
");
}

// End Compass

//Visitor's Fees

// A LOT of code ahead, I could not condense into methods for the life of me

static void DisplayParkFees(){
    const double CHILD_DISCOUNT = 0.8;
    const double STATE_TAX = 5;
    const double FED_TAX = 1.09;
    const int TICKET = 12;

    int childrenNumber = 0;
    int vehicleFee = 0;

    double amountDue = 0;

    ParkFeesLogo();
    //Priming read
    string decision = WelcomeParkFees();

    while(decision == "1"){
        System.Console.WriteLine("Please enter the amount of attendees.");
        int attendeeNumber = int.Parse(Console.ReadLine());

        string userInput = IfChildren();
        //Must enter 3 to exit children discount
        while(userInput != "3"){
        if(userInput == "1"){
            System.Console.WriteLine("Please enter the amount of children in your party.");
            childrenNumber += int.Parse(Console.ReadLine());
        } else if (userInput == "2"){
         childrenNumber += 0;
        } else {
            DisplayError();
        }
        userInput = IfChildren();
        }

        string userChoice = VehicleFees();
        //Must enter 3 to exit Vehicle Fees
        while(userChoice != "3"){
            if(userChoice == "1"){
                vehicleFee += 20;
            } else if (userChoice == "2"){
                vehicleFee += 10;
            } else{
                DisplayError();
            }
            userChoice = VehicleFees();
        }

        double totalFees = ((attendeeNumber * TICKET - ((childrenNumber*TICKET)*CHILD_DISCOUNT)) + vehicleFee);

        double feeFedTax = totalFees * FED_TAX;

        if(attendeeNumber >= 6){
            amountDue += feeFedTax + STATE_TAX;
            System.Console.WriteLine("The amount due is " + Math.Round(amountDue, 2));
        } else if (attendeeNumber < 6){
            amountDue += feeFedTax;
            System.Console.WriteLine("The amount due is " + Math.Round(amountDue, 2));
        }

        double amountDueRounded = Math.Round(amountDue, 2);

        System.Console.WriteLine("Please enter the amount you are paying.");
        double amountPaid = double.Parse(Console.ReadLine());

        //Prompts user for amount due, remaining, and change if they overpay
        if(amountPaid > 0){
            if(amountPaid > amountDueRounded){
                double changeAmount = amountPaid - amountDueRounded;
                System.Console.WriteLine($"Your change is {changeAmount}");
            } 
             else if(amountPaid < amountDueRounded){
                while(amountDue > 0.0){
                    double amountRemaining = amountDueRounded - amountPaid;
                    double amountRemainRounded = Math.Round(amountRemaining, 2);
                    System.Console.WriteLine($"Your amount remaining is {amountRemainRounded}\nPlease enter the amount you are paying.");
                    double remainingPaid = double.Parse(Console.ReadLine());
                    if(remainingPaid == amountRemaining){
                        System.Console.WriteLine("You have paid the amount due. Thank you and enjoy your time at the state parks!");
                        amountDue = 0.0;
                    }
                    if (remainingPaid > amountRemaining){
                        double remainingChange = remainingPaid - amountRemaining;
                        System.Console.WriteLine($"Your change is {remainingChange}");
                        amountDue = 0.0;
                    }
                }
            } 
             else if (amountPaid == amountDueRounded){
                System.Console.WriteLine("You have paid the amount due. Thank you and enjoy your time at the state parks!");
            } 
             else {
                DisplayError();
            }
        }
        
        Pause();
        //Update Read
        decision = WelcomeParkFees();
    }
}

static string WelcomeParkFees(){
    System.Console.WriteLine("Welcome to Park Fees! Are you needing to calculate your dues?\n1. Yes\n2. No");
    return Console.ReadLine();
}

static string IfChildren(){
    System.Console.WriteLine("Do you have any children in your party?\n1. Yes\n2. No\n3. Exit");
    return Console.ReadLine();
}

static string VehicleFees(){
    System.Console.WriteLine("Did you arrive in an RV or other vehicle?\n1. RV\n2. Other Vehicle\n3. Exit");
    return Console.ReadLine();
}

static void ParkFeesLogo(){
    System.Console.WriteLine(@"$$$$$$$\                     $$\             $$$$$$$$\                            
$$  __$$\                    $$ |            $$  _____|                           
$$ |  $$ |$$$$$$\   $$$$$$\  $$ |  $$\       $$ |    $$$$$$\   $$$$$$\   $$$$$$$\ 
$$$$$$$  |\____$$\ $$  __$$\ $$ | $$  |      $$$$$\ $$  __$$\ $$  __$$\ $$  _____|
$$  ____/ $$$$$$$ |$$ |  \__|$$$$$$  /       $$  __|$$$$$$$$ |$$$$$$$$ |\$$$$$$\  
$$ |     $$  __$$ |$$ |      $$  _$$<        $$ |   $$   ____|$$   ____| \____$$\ 
$$ |     \$$$$$$$ |$$ |      $$ | \$$\       $$ |   \$$$$$$$\ \$$$$$$$\ $$$$$$$  |
\__|      \_______|\__|      \__|  \__|      \__|    \_______| \_______|\_______/ 
                                                                                  ");
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