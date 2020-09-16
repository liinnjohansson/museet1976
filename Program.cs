using System;

namespace museum1976
{
    class Program
    {
        static void Main(string[] args)
        {
            // Steg 1
            // Ni har besökt muséet och pratat med er uppdragsgivare. Ni har fått med er en karta över
            // muséet och en kort förteckning över konstverken som finns i varje rum.
            // 1. Rita en enkel karta över byggnaden, den ska ha minst sju rum.
            // 2. Skriv ner vilka konstverk som finns i vilket rum. Rum kan vara tomma.
            // 3. Gör ett flödesdiagram över er tänkta lösning. Tänkt till och diskutera kring vilken kod
            // som måste implementeras för varje del av diagrammet
            // När ni är klara med er plan för projektet behöver ni stämma av programmets struktur med
            // den seniora C# utvecklaren i bolaget, innan ni kan börja utveckla programmet!

            // Steg 2
            // Implementera programmet. P.g.a. att detta program ska gå att användas på så många
            // användares olika datorer som möjligt får vi inte använda för avancerad programkod!
            // Ni kan bara använda följande c# statements och variabeltyper:
            // if, else, else if
            // while, do while, switch
            // const, int, bool, float, double, string, char
            // Enbart följande inbyggda funktioner och objekt finns tillgängliga:
            // Console.* (Allt i Console-modulen)
            // Random()
            // Math()
            // Döp er projektmapp till "museum1976". Börja med att att använda `dotnet new console`.

            // Steg 3
            // Varje gång ett rum besöks ska det med 1 chans på 10 börja brinna i rummet. Användaren
            // måste då navigera tillbaka till lobbyn (eller första rummet på museet). När användaren
            // kommit dit ska hen få en poäng på hur många rum som passerades igenom från att det
            // började brinna till utgången nåddes (Alternativt hur långt tid det tog). I slutet får användaren
            // frågan om den vill testa igen, eller avsluta programmet.
            // Tänk på att vid brand gäller inga rundtursregler, utan det är snabbast ut som gäller. Tänk
            // också på att det är en simulering av en person och hur den kommer agera skall inte styras av
            // programmet utan valet är fritt vilket håll personen kommer gå åt.
            // Programmet kommer nu köras på museets kraftiga dator, så vill ni använda andra funktioner
            // i C# eller .NET för att omstrukturera ert program kan ni göra det!

            bool mainLoop = true; //styr den yttersta loopen
            bool innerLoops = true; //styr dem inre looparna

            //Om något rum brinner
            bool thisRoomIsBurning1 = false;
            bool thisRoomIsBurning2 = false;
            bool thisRoomIsBurning3 = false;
            bool thisRoomIsBurning4 = false;
            bool thisRoomIsBurning5 = false;
            bool thisRoomIsBurning6 = false;
            bool thisRoomIsBurning7 = false;
            bool thisRoomIsBurning8 = false;

            Random tal1 = new Random(); //slumpgenerator
            const int chanceOfBurning = 4; //indikatior på när det börjar brinna
            bool burning = false; //avgör om det brinner eller inte
            int roomsPassed = 0; //Räknare som håller koll på hur många rum som passerats under tiden det brinner
            int timeSpent = 0; //hur många sekunder som gått under utrymmningen

            int inputAnswerFromUser = 0; //läser in användarens svar på menyer
            //START
            //ENTRÈ
            while (mainLoop) //yttersta loop, ittererar hela programmet
            {
                innerLoops = true;

                if (burning == false) //det brinner inte
                {
                    //HUVUDMENY
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine("---Välkommen till muséet!-------------");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("---Gör ett val i menyn----------------");
                    Console.WriteLine("---[1] Gå till första utställningen---");
                    Console.WriteLine("---[9] Lämna muséet-------------------");
                    Console.WriteLine("--------------------------------------\n");

                    try //felhantering för inmatning
                    {
                        inputAnswerFromUser = int.Parse(Console.ReadLine());
                    }

                    catch //exception
                    {
                        Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                    }

                    if (inputAnswerFromUser == 1) //Går in i rum 1
                    {
                        int intRandom = tal1.Next(0, 11); //slumpar tal

                        //HÄR BÖRJAR RUM 1
                        while (innerLoops)
                        {
                            if (intRandom == chanceOfBurning || thisRoomIsBurning2 == true) //när slumpgeneratorn träffar av indikator för brand
                            {
                                burning = true; //det brinner
                                thisRoomIsBurning1 = true; //indikerar att det här rummet brinner
                                roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                //MENY VID BRAND
                                Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 1, ta dig ut till entrén\n");
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                Console.WriteLine("-------------------------------------------\n");

                                try //felhantering för inmatning
                                {
                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                }

                                catch //exception
                                {
                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                }
                            }

                            else //om det inte brinner
                            {

                                //UNDERMENY RUM 1
                                Console.WriteLine("\n---Välkommen till Bildgalleriet!------------------------");
                                Console.WriteLine("--------------------------------------------------------");
                                Console.WriteLine("---[1] Gå vidare till nästa rum-------------------------");
                                Console.WriteLine("---[2] Gå tillbaka till föregående rum------------------");
                                Console.WriteLine("---[3] Ta en närmare titt på Sorgen---------------------");
                                Console.WriteLine("---[4] Ta en närmare titt på Solnedgången i Bredskär----");
                                Console.WriteLine("---[5] Ta en närmare titt på Ingemansland---------------");
                                Console.WriteLine("--------------------------------------------------------\n");

                                try //felhantering för inmatning
                                {
                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                }

                                catch //exception
                                {
                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                }
                            }

                            //HÄR BÖRJAR RUM 2
                            if (inputAnswerFromUser == 1) //menyval 1
                            {
                                int intRandom2 = tal1.Next(0, 11); //slumpar tal

                                while (innerLoops)
                                {
                                    if (intRandom2 == chanceOfBurning || thisRoomIsBurning1 == true || thisRoomIsBurning3 == true) //när slumpgeneratorn träffar av indikator för brand
                                    {
                                        burning = true; //det brinner
                                        thisRoomIsBurning2 = true; //indikerar att det här rummet brinner
                                        roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                        //MENY VID BRAND
                                        Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 2, ta dig ut till entrén\n");
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                        Console.WriteLine("-------------------------------------------\n");

                                        try //felhantering för inmatning
                                        {
                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                        }

                                        catch //exception
                                        {
                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                        }
                                    }

                                    else //om det inte brinner
                                    {

                                        //UNDERMENY RUM 2
                                        Console.WriteLine("\n---Välkommen till Textilgalleriet!------------");
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("---[1] Gå vidare till nästa rum---------------");
                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                        Console.WriteLine("---[3] Ta en närmare titt på Untitled---------");
                                        Console.WriteLine("----------------------------------------------\n");

                                        try //felhantering för inmatning
                                        {
                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                        }

                                        catch //exception
                                        {
                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                        }
                                    }

                                    //HÄR BÖRJAR RUM 3
                                    if (inputAnswerFromUser == 1) //menyval 1
                                    {
                                        int intRandom3 = tal1.Next(0, 11); //slumpar tal

                                        while (innerLoops)
                                        {
                                            if (intRandom3 == chanceOfBurning || thisRoomIsBurning2 == true || thisRoomIsBurning4 == true) //när slumpgeneratorn träffar av indikator för brand
                                            {
                                                burning = true; //det brinner
                                                thisRoomIsBurning3 = true; //indikerar att det här rummet brinner
                                                roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                //MENY VID BRAND
                                                Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 3, ta dig ut till entrén\n");
                                                Console.WriteLine("-------------------------------------------");
                                                Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                                Console.WriteLine("-------------------------------------------\n");

                                                try //felhantering för inmatning
                                                {
                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                }

                                                catch //exception
                                                {
                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                }
                                            }

                                            else //om det inte brinner
                                            {

                                                //UNDERMENY RUM 3
                                                Console.WriteLine("\n---Välkommen till Fotogalleriet!--------------");
                                                Console.WriteLine("----------------------------------------------");
                                                Console.WriteLine("---[1] Gå vidare till nästa rum---------------");
                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                                Console.WriteLine("---[3] Ta en närmare titt på Monkey-----------");
                                                Console.WriteLine("---[4] Ta en närmare titt på Stockholm 1989---");
                                                Console.WriteLine("---[5] Ta en närmare titt på The Café---------");
                                                Console.WriteLine("----------------------------------------------\n");

                                                try //felhantering för inmatning
                                                {
                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                }

                                                catch //exception
                                                {
                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                }
                                            }

                                            //HÄR BÖRJAR RUM 4
                                            if (inputAnswerFromUser == 1) //menyval 1
                                            {
                                                int intRandom4 = tal1.Next(0, 11); //slumpar tal

                                                while (innerLoops)
                                                {
                                                    if (intRandom4 == chanceOfBurning || thisRoomIsBurning3 == true || thisRoomIsBurning5 == true) //när slumpgeneratorn träffar av indikator för brand
                                                    {
                                                        burning = true; //det brinner
                                                        thisRoomIsBurning4 = true; //indikerar att det här rummet brinner
                                                        roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                        //MENY VID BRAND
                                                        Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 4, ta dig ut till entrén\n");
                                                        Console.WriteLine("-------------------------------------------");
                                                        Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                                        Console.WriteLine("-------------------------------------------\n");

                                                        try //felhantering för inmatning
                                                        {
                                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                        }

                                                        catch //exception
                                                        {
                                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                        }
                                                    }

                                                    else //om det inte brinner
                                                    {

                                                        //UNDERMENY RUM 4
                                                        Console.WriteLine("\n---Välkommen till Performancegalleriet!-------");
                                                        Console.WriteLine("----------------------------------------------");
                                                        Console.WriteLine("---[1] Gå vidare till nästa rum---------------");
                                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                                        Console.WriteLine("---[3] Ta en närmare titt på Tystnad----------");
                                                        Console.WriteLine("----------------------------------------------\n");

                                                        try //felhantering för inmatning
                                                        {
                                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                        }

                                                        catch //exception
                                                        {
                                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                        }
                                                    }

                                                    //HÄR BÖRJAR RUM 5
                                                    if (inputAnswerFromUser == 1) //menyval 1
                                                    {
                                                        int intRandom5 = tal1.Next(0, 11); //slumpar tal

                                                        while (innerLoops)
                                                        {
                                                            if (intRandom5 == chanceOfBurning || thisRoomIsBurning4 == true || thisRoomIsBurning6 == true) //när slumpgeneratorn träffar av indikator för brand
                                                            {
                                                                burning = true; //det brinner
                                                                thisRoomIsBurning5 = true; //indikerar att det här rummet brinner
                                                                roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                                //MENY VID BRAND
                                                                Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 5, ta dig ut till entrén\n");
                                                                Console.WriteLine("-------------------------------------------");
                                                                Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                                                Console.WriteLine("-------------------------------------------\n");

                                                                try //felhantering för inmatning
                                                                {
                                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                }

                                                                catch //exception
                                                                {
                                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                }
                                                            }

                                                            else //om det inte brinner
                                                            {

                                                                //UNDERMENY RUM 5
                                                                Console.WriteLine("\n---Hoppsan! Du hamnade i ett tomt galleri!----");
                                                                Console.WriteLine("----------------------------------------------");
                                                                Console.WriteLine("---[1] Gå vidare till nästa rum---------------");
                                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                                                Console.WriteLine("----------------------------------------------\n");

                                                                try //felhantering för inmatning
                                                                {
                                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                }

                                                                catch //exception
                                                                {
                                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                }
                                                            }

                                                            //HÄR BÖRJAR RUM 6
                                                            if (inputAnswerFromUser == 1) //menyval 1
                                                            {
                                                                int intRandom6 = tal1.Next(0, 11); //slumpar tal

                                                                while (innerLoops)
                                                                {
                                                                    if (intRandom6 == chanceOfBurning || thisRoomIsBurning5 == true || thisRoomIsBurning7 == true) //när slumpgeneratorn träffar av indikator för brand
                                                                    {
                                                                        burning = true; //det brinner
                                                                        thisRoomIsBurning6 = true; //indikerar att det här rummet brinner
                                                                        roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                                        //MENY VID BRAND
                                                                        Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 6, ta dig ut till entrén\n");
                                                                        Console.WriteLine("-------------------------------------------");
                                                                        Console.WriteLine("---[1] Gå vidare till nästa rum------------");
                                                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                                                        Console.WriteLine("-------------------------------------------\n");

                                                                        try //felhantering för inmatning
                                                                        {
                                                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                        }

                                                                        catch //exception
                                                                        {
                                                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                        }
                                                                    }

                                                                    else //om det inte brinner
                                                                    {

                                                                        //UNDERMENY RUM 6
                                                                        Console.WriteLine("\n---Det här rummet är under konstruktion-------");
                                                                        Console.WriteLine("----------------------------------------------");
                                                                        Console.WriteLine("---[1] Gå vidare till nästa rum---------------");
                                                                        Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                                                        Console.WriteLine("----------------------------------------------\n");

                                                                        try //felhantering för inmatning
                                                                        {
                                                                            inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                        }

                                                                        catch //exception
                                                                        {
                                                                            Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                        }
                                                                    }

                                                                    //HÄR BÖRJAR RUM 7
                                                                    if (inputAnswerFromUser == 1) //menyval 1
                                                                    {
                                                                        int intRandom7 = tal1.Next(0, 11); //slumpar tal

                                                                        while (innerLoops)
                                                                        {
                                                                            if (intRandom7 == chanceOfBurning || thisRoomIsBurning6 == true || thisRoomIsBurning8 == true) //när slumpgeneratorn träffar av indikator för brand
                                                                            {
                                                                                burning = true; //det brinner
                                                                                thisRoomIsBurning7 = true; //indikerar att det här rummet brinner
                                                                                roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                                                //MENY VID BRAND
                                                                                Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i rum 7, ta dig ut till entrén\n");
                                                                                Console.WriteLine("-------------------------------------------");
                                                                                Console.WriteLine("---[1] Gå till entrén----------------------");
                                                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum-----");
                                                                                Console.WriteLine("-------------------------------------------\n");

                                                                                try //felhantering för inmatning
                                                                                {
                                                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                                }

                                                                                catch //exception
                                                                                {
                                                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                                }
                                                                            }

                                                                            else //om det inte brinner
                                                                            {

                                                                                //UNDERMENY RUM 7
                                                                                Console.WriteLine("\n---Välkommen till Skulpturgalleriet!----------");
                                                                                Console.WriteLine("----------------------------------------------");
                                                                                Console.WriteLine("---[1] Gå till entrén-------------------------");
                                                                                Console.WriteLine("---[2] Gå tillbaka till föregående rum--------");
                                                                                Console.WriteLine("---[3] Ta del av en hemlighet-----------------");
                                                                                Console.WriteLine("---[4] Ta en närmare titt på Balloon Dog------");
                                                                                Console.WriteLine("----------------------------------------------\n");

                                                                                try //felhantering för inmatning
                                                                                {
                                                                                    inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                                }

                                                                                catch //exception
                                                                                {
                                                                                    Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                                }

                                                                            }

                                                                            if (inputAnswerFromUser == 1) //menyval 1
                                                                            {
                                                                                innerLoops = false; //går tillbaka till början av program
                                                                            }

                                                                            else if (inputAnswerFromUser == 2) //menyval 2
                                                                            {
                                                                                if (thisRoomIsBurning6 == true) //stoppar användaren för att gå till rum som brinner
                                                                                {
                                                                                    Console.WriteLine("Det här rummet brinner! Du kan inte gå in i det!");
                                                                                }

                                                                                else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                                                                {
                                                                                    break;
                                                                                }
                                                                            }

                                                                            else if (inputAnswerFromUser == 3) //menyval 3
                                                                            {

                                                                                if (thisRoomIsBurning7 == true) //stoppar användaren för att gå till hemligt rum vid brand
                                                                                {
                                                                                    Console.WriteLine("Det brinner i byggnaden! Du kan inte därför inte gå in det hemliga rummet!");
                                                                                }

                                                                                //HÄR BÖRJAR RUM 8

                                                                                else
                                                                                {
                                                                                    int intRandom8 = tal1.Next(0, 11); //slumpar tal

                                                                                    while (innerLoops)
                                                                                    {
                                                                                        if (intRandom8 == chanceOfBurning) //när slumpgeneratorn träffar av indikator för brand
                                                                                        {
                                                                                            burning = true; //det brinner
                                                                                            thisRoomIsBurning8 = true; //indikerar att det här rummet brinner
                                                                                            roomsPassed++; //här ökar antalet poäng med ett per rum passerat

                                                                                            //MENY VID BRAND
                                                                                            Console.WriteLine("\nVARNING: Brandlarmet har gått! Du är i det hemliga rummet, ta dig ut till entrén\n");
                                                                                            Console.WriteLine("-------------------------------------------");
                                                                                            Console.WriteLine("---[1] Gå tillbaka till föregående rum-----");
                                                                                            Console.WriteLine("-------------------------------------------\n");

                                                                                            try //felhantering för inmatning
                                                                                            {
                                                                                                inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                                            }

                                                                                            catch //exception
                                                                                            {
                                                                                                Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                                            }
                                                                                        }

                                                                                        else //om det inte brinner
                                                                                        {

                                                                                            //UNDERMENY RUM 8
                                                                                            Console.WriteLine("\n---WOW! Här visas ju Mona Lisa!!--------------");
                                                                                            Console.WriteLine("----------------------------------------------");
                                                                                            Console.WriteLine("---[1] Gå tillbaka till föregående rum--------");
                                                                                            Console.WriteLine("----------------------------------------------\n");


                                                                                            try //felhantering för inmatning
                                                                                            {
                                                                                                inputAnswerFromUser = int.Parse(Console.ReadLine());
                                                                                            }

                                                                                            catch //exception
                                                                                            {
                                                                                                Console.WriteLine("\nVänligen skriv in ett giltigt val från menyn!\n");
                                                                                            }

                                                                                        }

                                                                                        if (inputAnswerFromUser == 1)
                                                                                        {
                                                                                            break;
                                                                                        }

                                                                                    }

                                                                                    //HÄR SLUTAR RUM 8
                                                                                }
                                                                            }

                                                                            else if (inputAnswerFromUser == 4) //menyval 4
                                                                            {
                                                                                Console.WriteLine("\nBalloon Dog, Jeff Koons, 1994\n");
                                                                                Console.WriteLine("Jeff Koons är en amerikansk konstnär inom populärkulturen. " +
                                                                                                  "'Ballon Dog' finns i fem stycken unika exemplar i olika färger. " +
                                                                                                  "I gigantiskt format och gjorda av rostfritt stål är de riktiga showstoppers. " +
                                                                                                  "Exemplaret du kan se här är den blåa.\n");
                                                                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                                                                Console.ReadKey();
                                                                            }
                                                                        }
                                                                    }
                                                                    //HÄR SLUTAR RUM 7

                                                                    else if (inputAnswerFromUser == 2) //menyval 2
                                                                    {
                                                                        if (thisRoomIsBurning5 == true) //stoppar användaren för att gå till rum som brinner
                                                                        {
                                                                            Console.WriteLine("Det här rummet brinner! Du kan inte gå in!");
                                                                        }

                                                                        else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            //HÄR SLUTAR RUM 6

                                                            else if (inputAnswerFromUser == 2) //menyval 2
                                                            {
                                                                if (thisRoomIsBurning4 == true) //stoppar användaren för att gå till rum som brinner
                                                                {
                                                                    Console.WriteLine("Det här rummet brinner! Du kan inte gå in!");
                                                                }

                                                                else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    //HÄR SLUTAR RUM 5

                                                    else if (inputAnswerFromUser == 2) //menyval 2
                                                    {
                                                        if (thisRoomIsBurning3 == true) //stoppar användaren för att gå till rum som brinner
                                                        {
                                                            Console.WriteLine("Det här rummet brinner! Du kan inte gå in!");
                                                        }

                                                        else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                                        {
                                                            break;
                                                        }
                                                    }

                                                    else if (inputAnswerFromUser == 3) //menyval 3
                                                    {
                                                        Console.WriteLine("\nTystnad, Sissela Dahlberg\n");
                                                        Console.WriteLine("Det här konstverket är ett performance i realtid. " +
                                                                          "Sissela sitter på en stol i ett tomt rum och ska sitta där i en vecka. " +
                                                                          "\nI total tystnad.\n");
                                                        Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                                        Console.ReadKey();
                                                    }

                                                }
                                            }
                                            //HÄR SLUTAR RUM 4

                                            else if (inputAnswerFromUser == 2) //menyval 2
                                            {
                                                if (thisRoomIsBurning2 == true) //stoppar användaren för att gå till rum som brinner
                                                {
                                                    Console.WriteLine("Det här rummet brinner! Du kan inte gå in!");
                                                }

                                                else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                                {
                                                    break;
                                                }
                                            }

                                            else if (inputAnswerFromUser == 3) //menyval 3
                                            {
                                                Console.WriteLine("\nMonkey, Olle Otto Ollson, 2015\n");
                                                Console.WriteLine("Tillsammans med spännande ögonblicksbilder och revolutionernade bildredigering, " +
                                                                  "skapar Olle Otto prisbelönta mästerverk. " +
                                                                  "Det här fotot på en apa som gör en kullerbytta är en av dem.\n");
                                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                                Console.ReadKey();
                                            }

                                            else if (inputAnswerFromUser == 4) //menyval 4
                                            {
                                                Console.WriteLine("\nStockholm 1989, Sture Johansson, 1989\n");
                                                Console.WriteLine("Året är 1989. Från ett lägenhetstak på Södermalm, med blicken mot Gamla stan, " +
                                                                  "förevigar Sture när meteorregnet 'Cosmo' singlar ned från skyn. " +
                                                                  "Fotot har visats på några av de största fotoutställningarna i världen.\n");
                                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                                Console.ReadKey();
                                            }

                                            else if (inputAnswerFromUser == 5) //menyval 5
                                            {
                                                Console.WriteLine("\nThe Café, Sarah Gordon, 1978\n");
                                                Console.WriteLine("Sarah Gordon bor sedan hösten 1950 i New York. Hon har sina rötter i Göteborg " +
                                                                  "men tycker, trots sin ålder, att vimlet i New York är oslagbart. " +
                                                                  "'The Café' är ett av Sarahs tidigaste verk och därmed också hennes käraste ägodel.\n");
                                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    //HÄR SLUTAR RUM 3

                                    else if (inputAnswerFromUser == 2) //menyval 2
                                    {
                                        if (thisRoomIsBurning1 == true) //stoppar användaren för att gå till rum som brinner
                                        {
                                            Console.WriteLine("Det här rummet brinner! Du kan inte gå in!");
                                        }

                                        else //om det inte brinner kan användaren gå tillbaka till föregående rum
                                        {
                                            break;
                                        }
                                    }

                                    else if (inputAnswerFromUser == 3) //menyval 3
                                    {
                                        Console.WriteLine("\nUntitled, Kristina Krantz, 2020\n");
                                        Console.WriteLine("Så länge hon kan minnas har Kristina varit intresserad av garn. " +
                                                          "Hon fascineras av möjligheten att fingervirka långa remsor, " +
                                                          "vilket kan ses i det här verket. " +
                                                          "'Untitled' består av ca 10 000 meter garn.\n");
                                        Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            //HÄR SLUTAR RUM 2

                            else if (inputAnswerFromUser == 2) //menyval 2
                            {
                                break;
                            }

                            else if (inputAnswerFromUser == 3) //menyval 3
                            {
                                Console.WriteLine("\nSorgen, Margareta Kilberg, 2005\n");
                                Console.WriteLine("'Sorgen' är ett av Margaretas mest folkkära porträtt. " +
                                                  "Hon föddes som tvilling, men tvillingsystern dog kort efter förlossningen. " +
                                                  "I sina memoarer skriver Margareta att hon kan känna att en del av henne saknas, " +
                                                  "trots att hon aldrig fick träffa sin syster. " +
                                                  "Något som Margareta alltid blir påmind om när hon ser sig själv i spegeln.\n");
                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                Console.ReadKey();
                            }

                            else if (inputAnswerFromUser == 4) //menyval 4
                            {
                                Console.WriteLine("\nSolnedgången i Bredskär, Carl Sundby, 2019\n");
                                Console.WriteLine("'Solnedgången' i Bredskär illustrerar hur havet lyser upp när solen närmar sig horisonten. " +
                                                  "Med varma färger och djärva penseldrag " +
                                                  "skapar Carl en känsla av lugn i ett stormigt hav. " +
                                                  "Hur han har förmågan att göra det är till " +
                                                  "och med okänt för konstnären själv. " +
                                                  "Med sina rötter i de djupa skogarna i " +
                                                  "Norrlands inland längtade Carl ut till havet. " +
                                                  "På Bredskärs klippor har Carl suttit och målat sedan hösten 1999.\n");
                                Console.WriteLine("Tryck på valfri tangent för att sluta läsa.\n");
                                Console.ReadKey();
                            }

                            else if (inputAnswerFromUser == 5) //menyval 5
                            {
                                Console.WriteLine("\nIngemansland, Anna Von Dyberg, 1992\n");
                                Console.WriteLine("UNKNOwN\n");
                                Console.ReadKey();
                            }
                        }
                        //HÄR SLUTAR RUM 1
                    }
                    else if (inputAnswerFromUser == 9) //när användaren valt menyval 9 vid huvudmeny
                    {
                        Console.WriteLine("\nDu har nu lämnat muséet!\n");
                        Console.WriteLine("Vill du besöka muséet igen? [J] / [N]\n");

                        while (true)
                        {
                            string again = Console.ReadLine().ToUpper();

                            if (again == "J") //går tillbaka till START
                            {
                                mainLoop = true;
                                break;
                            }

                            else if (again == "N") //avslutar program
                            {
                                mainLoop = false;
                                Console.WriteLine("\nProgrammet avslutades. Tack för ditt besök!\n");
                                break;
                            }

                            else //felhantering för inmatning
                            {
                                Console.WriteLine("\nAnge antingen J eller N!\n");
                            }
                        }
                    }
                }

                else //det brinner
                {
                    timeSpent = roomsPassed * 10; //räknar ut hur många sekunder som gått under utrymningen
                    Console.WriteLine($"\nDu tog dig ut ur muséet oskadd! Det tog {timeSpent} sekunder för dig att ta dig ut. Bra jobbat!\n");
                    Console.WriteLine("\nVill du besöka muséet igen? J / N\n");

                    string again = Console.ReadLine().ToUpper();

                    if (again == "J") //går tillbaka till START
                    {
                        mainLoop = true;
                        burning = false;
                    }

                    else if (again == "N") //avslutar program
                    {
                        mainLoop = false;
                        Console.WriteLine("Programmet avslutades");
                    }

                    else //felhantering för inmatning
                    {
                        Console.WriteLine("Ange antingen J eller N");
                    }
                }
            }
            //STOPP
        }
    }
}
