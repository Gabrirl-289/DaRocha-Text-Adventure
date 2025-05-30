using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Text_Adventure
{
    enum Lighttype
    {
        light,
        flashlight,
        lightBulb,
        lighter,
        magic,
    }
    struct PlayerData
    {
        public int health;
        public bool isAlive;
        public string Pname;
        public DateTime lastEditedl;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("copy and paste in case your answer is not going. or try all lower case");
            Lighttype lighttype = Lighttype.flashlight;
            Console.Title = "welcome to purgatory";
            int hp = 100;
            int nameOfVariable = 3, helloworld = 6; //
            float distanceToStore, howcoolDerekis = -10.5f; // numbers with a dot
            double inflation = 10.5863; //alot of numbers, 8 max
            string myword = "you are handcuffed"; //a whole sentence
            char myCharacterOrletter = 'A'; //only a word
            bool vgd = true;
            bool singer = true;
            nameOfVariable = 10;
            nameOfVariable = 16;
            float lessinflation = (float)inflation;
            float thatscrazy = System.Convert.ToSingle(inflation);
            double lessinflation2 = Convert.ToDouble(nameOfVariable);
            decimal revenue = 390819.28m; //decimal numbers, 28 max
            
            //for cource  

            int passengerAge = 28 + 1;
            passengerAge += 1;
            double passengerAgeDouble = Convert.ToDouble(passengerAge);
            double passengerAgeDouble2 = (double)passengerAgeDouble;
            string passengerAgeString = Convert.ToString(passengerAge);

            // Your Age
            int userAge = 17;
            // Length of years on Jupiter (in Earth years)

            double jupiterYears = 11.86;
            // Age on Jupiter
            int jupiterAge = Convert.ToInt32(jupiterYears / userAge);

            int steps = 2;
            steps++;
            steps--;

            int students = 18;
            // Number of students in a group
            int groupSize = 3;
            //prints the remaining amount
            Console.WriteLine(students % groupSize);

            //square root
            int numberOne = 12932;
            int numberTwo = -2828472;
            //rounds and square root number one value
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            //abs will remove the negative
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
            //will show the smallest number between the two
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));
            /*Math.Abs() — Finds the absolute value of a number. Example: Math.Abs(-5) returns 5.
            Math.Sqrt() — Finds the square root of a given double. Example: Math.Sqrt(16) returns 4.
            Math.Floor() — Rounds the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
            Math.Ceiling() — The counterpart of Math.Floor(), rounds a given double or decimal up to the nearest whole number. Example: Math.Ceiling(8.65) returns 9.
            Math.Min() — Returns the smaller of two numbers of the same type. Example: Math.Min(39, 12) returns 12.
            Math.Max() — The counterpart of Math.Min(), returns the larger of two numbers of the same type. Example: Math.Max(39, 12) returns 39.
            */

            //string beginning = "hello";
            //string middle = "hey";
            //string end = "bye";
            //// Concatenate the string and the variables
            //string story = beginning + " " + middle + " " + end;




            // for make a new sentence below, \n
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\" ";
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";

            Console.WriteLine(firstSentence);
            Console.WriteLine("\n"); //make an empty line
            Console.WriteLine(firstSpeech);
            //end of \n notes

           //
            string yourFaveMusician = "David Bowie";
            string myFaveMusician = "Solange";
            //allows for not requiring to write dots separately
            Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.");

            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $" {beginning} {middle} {end}";

            //

            //checks the length of the string
            Console.WriteLine(story.Length);
            //Check if the letter ? exists in the string
            int passwordCheck = story.IndexOf("?");
            //
            
            //removes everyword except the ones u told not to
            string plantName = "Cactaceae, Cactus";
            int charPosition = plantName.IndexOf("Cactus"); // Returns 11
            string commonName = plantName.Substring(charPosition); // Returns Cactus
            //
            string startStrand = "ATGCGATGAGCTTAC";
            int tga = startStrand.IndexOf("TGA");
            int startPoint = 0;
            int length = tga + 3;
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna[3]);

            //Substring ends here
            
            //to upper and to lower
            string shouting = "I'm not shouting, you're shouting".ToUpper();
            Console.WriteLine(shouting);
            // Prints I'M NOT SHOUTING, YOU'RE SHOUTING.
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            int charPostion = script.IndexOf("Close");
            int lengh = "Close on".Length;
            string cameraDirections = script.Substring(charPostion, lengh).ToUpper();
            cameraDirections = cameraDirections.ToLower();

            //true and false different methods
            bool answer = (9 < 3) || (100 < 45); // evaluates to false
            bool another = ((3439 > 40) && (1 < 3)) || answer; // evaluates to true
            bool peanutButter = true;
            bool jelly = true;
            bool sandwich = (peanutButter && jelly); // evaluates to true

            //switches! 
            int speed = 100;

            switch (speed)
            {
                case < 25:
                    // Executes if the value of speed is less than 25
                    Console.WriteLine("Going slowly");
                    break;
                case 25:
                    // Executes if the value of speed is equal to 25
                    Console.WriteLine("Going at correct speed");
                    break;
                case < 30: //case is basically if statement
                    // Executes if the value of speed is between 25 and 30
                    Console.WriteLine("Going slightly too fast");
                    break;
                default: //default is basically else for if statement
                    // The speed must be over 30 due to the above conditions
                    Console.WriteLine("Going much too fast");
                    break;
            }
            double ph = 4.5;
            switch (ph)
            {
                case <= 3:
                    Console.WriteLine("Very Acidic");
                    break;
                case < 7:
                    Console.WriteLine("Acidic");
                    break;
                case >= 11:
                    Console.WriteLine("Very Basic");
                    break;
                case > 7:
                    Console.WriteLine("Basic");
                    break;
                default:
                    Console.WriteLine("Neutral");
                    break;
            }
            //if-else statement
            string color = "green";
            string movement = (color == "green") ? "go" : "stop";
            Console.WriteLine(movement);

            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);

            //Array studies!!!
            // These arrays store ints, strings, and doubles, respectively
            int[] x;
            string[] s;
            double[] d;

            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            summerStrut[7] = "Chris";
            Console.WriteLine($"You rated the song{summerStrut[1]} {ratings[1]} stars");
            //IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!).
            int threeRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");
            //Array.Reverse() method returns the array with the original elements in reverse order.
            Array.Reverse(summerStrut);
            string newFirst = summerStrut[0];
            string newLast = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {newFirst}.");
            Console.WriteLine($"The last song in the playlist is now {newLast}.");

            //sorts an array. If it is an array of integer values, it will sort them into ascending values (lowest to highest). 
            Array.Sort(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            Console.WriteLine($"The last song in the playlist is now {lastSong}.");


            // Game hasn't started
            bool startGame = false;

            do
            {
                // do this at least once 
                // continue as long as the player hasn't started the game
                //ShowStartScreen();
            } while (!startGame);
            // example of happening once

                bool buttonClick = true;

                do
                {
                    Console.WriteLine("Alarm Ringing");
                    buttonClick = true;
                } while (!buttonClick);

                Console.WriteLine("Time for a five minute break");
            // now For loops
            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine($"Week {i}");
                Console.WriteLine("Announcements: \n \n \n ");
                Console.WriteLine("Report Backs: \n \n \n");
                Console.WriteLine("Discussion Items: \n \n \n");
            }
            // basically it prints every phrase in the todo and will stop printing when theres none else to print in the foreach list
                string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

                foreach (string task in todo)
                {
                    Console.WriteLine($"[] {task}");
                }
                //it will print every word on the array list 
            string[] websites = { "twitter", "facebook", "gmail" };
            int counter = 0;

            while (counter < websites.Length)
            {
                Console.WriteLine(websites[counter]);
                counter++;
            }


                //for cource

                int thatscrazyagain = Convert.ToInt32(inflation);
            string myname = "what is your name?";
            bool Handcuff = true;
            bool PrisonDoor = true;
            bool Knife = true;
            bool light = true;
            bool key = true;
            string[] somelight;
            somelight = new string[] { "lights", "Light", "light", "flashlight" };
            string currentItem = "";
            bool doorknowledge = true;
            bool lifeline = true;
            bool TrueEnding = true;
            Lighttype lights = Lighttype.light;
            if (lights == Lighttype.flashlight)
            {
                Console.WriteLine("gave me points");
            }

            ///   Notes only     \\\
            //Console.WriteLine(thatscrazyagain);
            //Console.ReadKey(); this is for only one letter/number

            // operators (+,-,/,*)
            // operands  what you doing the operations on (basically numbers)

            //char letter = Console.ReadKey().KeyChar;
            //switch (letter)
            //{
            //    case 'a':
            //        break;
            //}
            // in case oyu remove the break. the code will go thought the case and in the next case until it breaks


            //Arithmetic operators +,-,*,/
            //+=, -=, *=, /=
            //++,--

            // &&, ||, !

            ///     end of notes area        \\\

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(myname);
            string name = Console.ReadLine();
            Console.WriteLine("second name");
            string sename = Console.ReadLine();
            Console.WriteLine("hello ");
            PlayerData player1 = new()
            {
                Pname = name + " " + sename,
                isAlive = true,
                health = 100,

            };
            Console.WriteLine(player1.Pname);
            try
            {
                Console.WriteLine("how old are you?");
                int playerAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(playerAge + ", you are old");
            }
            catch (Exception)
            {
                Console.WriteLine("thats not a age but ok");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you are locked in what looks like a prison, it's too dark, your hands are cuffed,");
            Console.WriteLine("there is a knife on the table, a key on the ground and a light on the bed");
            Console.WriteLine("knife|key|light");


            //   Console.ReadLine(); for multiple numbers or letter
            //where code starts, part one
            string input = Console.ReadLine();
            while (true)
            {

                if (input == "Knife" || input == "knife")
                {
                    Console.WriteLine("you grab the knife, as you do that you hear heavy steps echoing the halls, you cant see but its definately here, you are still handcuffed ");
                    Knife = false;
                    currentItem = currentItem + "knife |";
                    break;
                }
                else if (input == "key")
                {
                    Console.WriteLine("you use to uncoff yourself, as you do that you hear heavy steps echoing the halls, you cant see but its definately here ");
                    Handcuff = false;
                    key = false;
                    currentItem = currentItem + "key |";
                    break;
                }
                else if (input == "light")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you use the Flashlight so see your surroundings,as you do that,you hear a terrifying growl ecoioing the halls, you use the light to check and you see, you see a human,nut he dosent seem friendly, he is holding a huge sword that has whires on it,you definately dont want to get hit, its face is expresionless and his simple glance sends you shivers, after some timee looking at him, you notice his face is actually a mask of a human face. everything in your body tells you one thing.");
                    Console.WriteLine("RUN");
                    Console.ResetColor();
                    Console.WriteLine("for your luck, your cell is locked, he cant come in");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("yet");
                    light = false;
                    Console.Beep(125, 3000);
                    currentItem = currentItem + "Flashlight |";

                    break;
                }
                else
                {
                    Console.WriteLine("thats not a option");
                    input = Console.ReadLine();
                }
            }
            //while loop ends
            Console.ResetColor();
            Console.WriteLine(name + " what you wanna do?");
            //if conditions of the player
            if (Handcuff)
            {
                Console.WriteLine("you are still handcuffed");
            }
            if (PrisonDoor == true)
            {
                Console.WriteLine("the door is locked");
            }
            //other loop started
            while (true)
            {
                if (input == "knife" && key)
                {
                    Console.WriteLine("key || light");
                }
                else if (input == "key")
                {
                    Console.WriteLine("light || knife");
                }
                else if (input == "light")
                {
                    Console.WriteLine("Knife || key");
                }
                input = Console.ReadLine();
                //player second choices of item
                if (input == "light" && light && Knife)
                {
                    Console.WriteLine("you grab the Flashlight and now you can see the room, when you turn to the knife, you realize the knife dissapeared, seems like you wont be able to protect yourself");
                    Console.WriteLine(" you use the light to check outside the cell, you see a human,but he dosent seem friendly, he is holding a huge sword that has whires on it,you definately dont want to get hit, its face is expresionless and his simple glance sends you shivers, after some timee looking at him, you notice his face is actually a mask of a human face.");
                    light = false;
                    currentItem = currentItem + " light";
                    break;
                }
                else if (input == "light" && light && key)
                {
                    Console.WriteLine("you grab the flashlight, when you turn to the key you realize the key dissapered,seems like you will stay coffed for a time");
                    Console.WriteLine("you use the light to check outside the cell, you see a human, but he dosent seem friendly, he is holding a huge sword that has whires on it, you definately dont want to get hit, its face is expresionless and his simple glance sends you shivers, after some timee looking at him, you notice his face is actually a mask of a human face.");


                    light = false;
                    currentItem = currentItem + " light";
                    break;
                }
                else if (input == "key" && key && light)
                {
                    Console.WriteLine("you grab the key, when you turn to the light, you realize the light dissapered,seems like you will have difficulties to seem your surroundings");
                    key = false;
                    currentItem = currentItem + " key";
                    break;
                }
                else if (input == "key" && key && Knife)
                {
                    Console.WriteLine("you grab the key, when you turn to the knife you realize the knife dissapered,seems like you wont be able to protect yourself ");
                    key = false;
                    currentItem = currentItem + " key";
                    break;
                }
                else if (input == "knife" && Knife && key)
                {
                    Console.WriteLine("you grab the Knife, when you turn to the key you realize the key dissapered,seems like you will stay coffed for a time");
                    Knife = false;
                    currentItem = currentItem + " knife";
                    break;
                }
                else if (input == "knife" && Knife && light)
                {
                    Console.WriteLine("you grab the Knife, when you turn to the light you realize the light dissapered,seems like you will have difficulties to seem your surroundings");
                    Knife = false;
                    currentItem = currentItem + " knife";
                    break;
                }
                else
                {
                    Console.WriteLine("please choose one of the options");
                }
                Console.Beep(1000, 100);
            }
            //note the title changing + shows curent item
            Console.Title = "we just started";
            listItems(currentItem);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (light == false)
            {
                Console.WriteLine("you see the human passing thought the corredor ignoring you and going elsewhere");
            }
            else
            {
                Console.WriteLine("you hears steps towards your cell but them the you hear the step leaving, you might be alone now");
            }
            // void to check player items
            static void listItems(string itemName)
            {
                Console.WriteLine("current items: " + itemName);
            }
            //some beep sounds and reset collor function
            Console.ResetColor();
            Console.Beep(1000, 1000);
            Console.Beep(2114, 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            //part 2 begins (i will make the game 3 parts only)
            Console.WriteLine("you can check your items anytime");
            Console.ResetColor();
            Console.WriteLine(player1.Pname);
            Console.WriteLine("what you wanna do?");
            Console.WriteLine("options: punch the door  || sing || wait || check items");
            Console.Beep(14026, 1000);
            Console.Beep(700, 1000);
            Console.Beep(2114, 100);
            while (true)
            {
                input = Console.ReadLine();
                if (input == "punch the door")
                {
                    hp = hp - 1;
                    Console.WriteLine("you hurt yourself, dummy, -1 hp");
                    Console.WriteLine("current hp: " + hp);
                    Console.WriteLine("the door magically opens");
                    break;
                }
                else if (input == "check items")
                {
                    Console.WriteLine(currentItem);
                    Console.Beep(1000, 100);
                    continue;
                }
                else
                {
                    Console.WriteLine("anyways,door magically opens");
                    break;
                }
            }
            if (input == "sing")
            {
                Console.WriteLine("you are a terrible singer");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("dont do again");
                Console.ResetColor();
            }
            Console.WriteLine("you leave the room");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("press anything to continues");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Beep(1000, 100);
            //this is where phase 2 starts
            Console.Clear();
            Console.Title = "part 2";
            Console.WriteLine("you left the cell, you are now walking thought dark corridors,there are alot of cells just like yours, definately this is a jail");
            if (light == false)
            {
                Console.WriteLine("you use the Flashlight to see, everything is more clear for you now");
            }
            Console.WriteLine("");
            Console.WriteLine("you found stairs, up and down");
            Console.WriteLine("what you wanna do? ");
            Console.WriteLine("Up || down || sing || check items");
            //2 places that will gave an ending
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Up")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you decided to go up");
                    Console.ResetColor();
                    Console.WriteLine("after reaching the next floor, when you look back, what was once the stairs hade become a simple wall");

                    if (light == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("the place is dark but luckly you have a flashlight");
                        Console.WriteLine("the walls are white, there are some wheelchairs and medical equipaments scattered around");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("the place is dark, its hard to understand where you are, you stumble in some wheelchairs");
                        Console.ResetColor();

                    }
                    Console.WriteLine("press anything to continue");
                    Console.ReadKey();
                    Console.Clear();
                    //part 2 final begin
                    Console.Title = "part 2 up";
                    Console.WriteLine("you keep walking thought this misterious place");
                    Console.WriteLine("you find a door locked, it requires a pass code");
                    Console.WriteLine("what you wanna do?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Check nearby rooms || sing || Look closer at the door");
                    //start of the up part
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input == "sing" && singer == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("dont do again");
                            Console.ResetColor();
                        }
                        else if (input == "sing" && singer == false)
                        {
                            Console.WriteLine("i warned you");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("sudently the ground started to shake and everything falls");
                            hp = 0;
                            break;
                        }
                        else if (input == "Check nearby rooms")
                        {
                            Console.WriteLine("you enter the nearby rooms, you notice some things scatered and a paper");
                            Console.WriteLine("when you look at the paper there is a message:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("this place, has no sense, its like a combination of everything, theres so many floors, each with different settings,");
                            Console.WriteLine("code: 5 - - 0,the lasts 2 digits are on the scariest room down the stairs");
                            Console.ResetColor();
                            Console.WriteLine("press anything to continue");
                            Console.ReadKey(true);
                            Console.WriteLine("when you come back to the hall with the door code you realize the stairs are back");
                            Thread.Sleep(1000);
                            doorknowledge = false;
                            break;

                        }
                        else if (input == "Look closer at the door")
                        {
                            Console.WriteLine("you look closer at the door, you see a 4 digit password code");
                            Console.WriteLine("wanna check nearby rooms now?");
                            // Thread.Sleep(1000);

                        }

                        else
                        {
                            Console.WriteLine("not a option");
                        }

                    }
                    //end of the up part
                    switch (true) //for grades
                    {
                        case false: // the case will never appear in the game because its a false statment over a switch stated to be true, its just a easter egg
                            Console.WriteLine("derek will gave me extra points");
                            break;
                    }
                }
                //begining of the down part
                else if (input == "down" || doorknowledge == false)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you decided to go down");
                    Console.ResetColor();
                    Console.WriteLine("as you go all the way down. you realize the stairs dissapeared, there is no turning back now");
                    Thread.Sleep(1000);
                    Console.WriteLine("you find yourself in a room filled with boxes and dust, its like a armazenament room, but it is huge");
                    Console.WriteLine("after some time walking, you hear steps...something is definately here");
                    Thread.Sleep(1000);
                    Console.WriteLine("what you wanna do?");
                    //Console.WriteLine("hide|keep walking");
                    // if (light == false)
                    // {
                    //    Console.WriteLine("use flashlight");
                    //  }
                    while (true) //currently working on it 
                    {
                        Console.WriteLine("hide|keep walking");
                        if (light == false)
                        {
                            Console.WriteLine("use flashlight");
                        }
                        input = Console.ReadLine();
                        if (input == "hide") //WORNK ON THIS FIRST
                        {
                            Console.WriteLine("you decided to hide");
                            Console.WriteLine("press anything to continue");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("you hide inside one of the boxes, as you keep hidden, you notice a shadow passing thought your hiding spot.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("something definately is near");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.WriteLine("what you wanna do?");
                            Console.WriteLine("leave hideout || keep hidden");
                            if (light == false)
                            {
                                Console.WriteLine("use flashlight");
                            }
                            while (vgd == true)
                            {
                                input = Console.ReadLine();
                                if (input == "leave hideout")
                                {
                                    input = "keep walking";
                                    Console.WriteLine("you left your hideout");
                                    break;
                                }
                                else if (input == "keep hidden")
                                {
                                    Console.WriteLine("nothing happens, you just stay hidden");
                                    Console.WriteLine("what you wanna do now?");
                                    Console.WriteLine("leave hideout || keep hidden");

                                    if (light == false)
                                    {
                                        Console.WriteLine("use flashlight");
                                    }
                                    input = Console.ReadLine();
                                    if (input == "leave hideout")
                                    {
                                        input = "keep walking";
                                        Console.WriteLine("you left hideout");
                                        Console.WriteLine("what you wannda do?");
                                        Console.WriteLine("hide || keep walking");
                                        if (light = false)
                                        {
                                            Console.WriteLine("use flashlight");
                                        }
                                        break;
                                    }
                                }
                                else if (input == "use flashlight" && light == false)
                                {
                                    input = "flashlight";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("not a option");
                                }
                            }
                        }
                        else if (input == "keep walking")
                        {
                            Console.WriteLine("you decided to keep walking");
                            Console.WriteLine("press anything to continue");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("you keep exploring the place suddently you hear the quick steps behind you");
                            Console.WriteLine("when you look back you see a human with a sword in wires");
                            Console.WriteLine("he charges an attack on you and he hits");
                            //hp = hp - 33;
                            hp -= 33;
                            Console.WriteLine("current hp: " + hp);
                            Console.WriteLine("you begin running for your life");
                            Thread.Sleep(1000);
                            Console.WriteLine("what you wanna do?");
                            Console.WriteLine("keep running || hide");
                            if (key == false)
                            {
                                Console.WriteLine("throw some boxes");
                            }
                            while (true)
                            {
                                input = Console.ReadLine();
                                if (input == "keep running")
                                {
                                    Console.WriteLine("he reaches you");

                                    if (Knife == true)
                                    {
                                        Console.WriteLine("he hits you");
                                        hp -= 33;
                                        Console.WriteLine("curret hp = " + hp);
                                        Console.WriteLine("lucklily you find a door and you enter immediately and the door autom");
                                        if (hp <= 0)
                                        {
                                            lifeline = false;
                                            break;
                                        }

                                    }
                                    else if (Knife == false)
                                    {
                                        Console.WriteLine("you knife the guy allowing yourself to scape, but you lost your knife");
                                        Knife = true;
                                    }
                                    Console.WriteLine("lucklily you find a door and you enter immediately and the door automatically closes behind you");
                                    Console.WriteLine("press anything to continue");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    input = "applepie";
                                    break;
                                }
                                else if (input == "hide")
                                {
                                    break;
                                }
                                else if (input == "throw some boxes")
                                {
                                    Console.WriteLine("he wasant able to reach you");
                                    Console.WriteLine("lucklily you find a door and you enter immediately and the door automatically closes behind you");
                                    Console.WriteLine("press anything to continue");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    input = "applepie";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("not an option");
                                }
                                if (lifeline = false)
                                {
                                    break;
                                }

                            }
                            if (input == "applepie")
                            {
                                break;
                            }
                        }
                        else if (input == "flashlight" && light == false)
                        {
                            Console.WriteLine("you use the flashlight to see your surroundings");
                            Console.WriteLine("press anything to continue");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("you see that same person again, still holding the sword with wires he began running towards you");
                            Console.WriteLine(player1.Pname + ", what you wanna do?");
                        }
                        else
                        {
                            Console.WriteLine("not an option");
                        }
                    }
                    if (input == "applepie")
                    {
                        break;
                    }
                    //end of down part
                }
                else if (input == "sing" && singer == false)
                {
                    hp = 0;
                    Console.WriteLine("i warned you");
                }

                else if (input == "sing")
                {
                    //this is for a secret ending
                    Console.WriteLine("if you sing again you will suffer consequences...");
                    singer = false;
                    Console.Beep(400, 1000);
                }
                else if (input == "check items")
                {
                    Console.WriteLine(currentItem);
                }
                //this is for the UP and down option
                else
                {
                    Console.WriteLine("not a option");
                }
                //ded
                if (hp <= 0)
                {
                    Console.Title = "end";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you died, you couldt scape. there is no turning back now. preass anything to end game");
                    Console.ResetColor();
                    Console.ReadKey(true);
                    Console.Clear();
                    trueending(player1.Pname);
                    break;
                }
                static void trueending(string named)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("you reached the end " + named);
                }

            }
            if (input == "applepie")
            {
                Console.WriteLine("you are tired and hurt, somehow you scaped");
                Console.WriteLine("");
            }
            Thread.BeginCriticalRegion();
            Console.Beep(100, 1000);
            Thread.EndCriticalRegion();
            Thread.SpinWait(1000);
            Thread.Yield();
            Thread.EndThreadAffinity();
            Thread.Sleep(1000);

        }

    }
}



//If you're reading this I am hiding under Dereks desk. I will be untieing his shoes for the rest of his teaching career down here.
//No one will be able to stop me. Every time he wears flip flops I will cut the strings with my scissors. There is no escape Derek.