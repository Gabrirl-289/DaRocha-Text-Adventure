using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using System.Security.AccessControl;

namespace Text_Adventure
{
    enum illuminationType
    {
        light,
        flashlight,
        illumination,

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
            Console.Title = "welcome to purgatory";
            int hp = 100;
            int nameOfVariable = 3, helloworld = 6; //
            float distanceToStore, howcoolDerekis = 10.5f; // numbers with a dot
            double inflation = 10.5863; //alot of numbers, 8 max
            string myword = "you are handcuffed"; //a whole sentence
            char myCharacterOrletter = 'A'; //only a word
            bool vgd = true;
            bool singer = true;
            nameOfVariable = 10;
            nameOfVariable = 16;
            float lessinflation = (float)inflation;
            float thatscrazy = System.Convert.ToSingle(inflation);
            int thatscrazyagain = Convert.ToInt32(inflation);
            string myname = "what is your name?";
            bool Handcuff = true;
            bool PrisonDoor = true;
            bool Knife = true;
            bool light = true;
            bool key = true;
            string currentItem = "";
            bool doorknowledge = true;

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
            Console.WriteLine("hello " + name + " " + sename);
            PlayerData player1 = new()
            {
                Pname = name + " " + sename,
                isAlive = true,
                health = 100,

            };
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
                    Console.ForegroundColor= ConsoleColor.Red;
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
          
            Console.Title = "we just started";
            listItems(currentItem);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (light == false)
            {
                Console.WriteLine("you see the human passing thought the corredor ignoring you and going elsewhere");
            }
            else {
                Console.WriteLine("you hears steps towards your cell but them the you hear the step leaving, you might be alone now");
            }
            // void to check player items
            static void listItems(string itemName)
            {
                Console.WriteLine("current items: " + itemName);
            }

            Console.ResetColor();
            Console.Beep(1000,1000);
            Console.Beep(2114,100);
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
                    break ;
                }
            }
            if (input == "sing")
            {
                Console.WriteLine("you are a terrible singer");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("dont do again");
                Console.ResetColor();
            }
            Console.WriteLine("you leave the room");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("press anything to continues");
            Console.ResetColor();
            Console.ReadKey();
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
                if (input == "up")
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
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input == "sing" && light)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("dont do again");
                            Console.ResetColor();
                        }
                        else if (input == "sing" && !light)
                        {
                            Console.WriteLine("i warned you");
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
                            Console.WriteLine("");
                            doorknowledge = false;

                        }
                        else if (input == " Look closer at the door")
                        {
                            Console.WriteLine("you look closer at the door, you see a  digit password code");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            
                        }
                        
                        else
                        {
                            Console.WriteLine("not a option");
                        }

                    }

                }
                else if (input == "down" )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you decided to go down");
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
                
                else
                {
                    Console.WriteLine("not a option");
                }

                if (hp <= 0)
                {
                    Console.Title = "end";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you died, you couldt scape. there is no turning back now. preass anything to end game");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                
            

            }
        
        }
    }
}
