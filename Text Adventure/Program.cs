namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "welcome to purgatory";
            int error = 0;
            int nameOfVariable = 3, helloworld = 6; //
            float distanceToStore, howcoolDerekis = 10.5f; // numbers with a dot
            double inflation = 10.5863; //alot of numbers, 8 max
            string myword = "you are handcuffed"; //a whole sentence
            char myCharacterOrletter = 'A'; //only a word
            bool vgd = true;
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

            //Console.WriteLine(thatscrazyagain);
            //Console.ReadKey(); this is for only one letter/number

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(myname);
            string name = Console.ReadLine();
            Console.WriteLine("second name");
            string sename = Console.ReadLine();
            Console.WriteLine("hello " + name + " " + sename);
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
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "knife")
                {
                    Console.WriteLine("you grab the knife, as you do that you hear heavy steps ecoioing the halls, you cant see but its definately here, you are still handcuffed ");
                    Knife = false;
                    break;
                }
                else if (input == "key")
                {
                    Console.WriteLine("you use to uncoff yourself, as you do that you hear heavy steps ecoioing the halls, you cant see but its definately here ");
                    break;
                    Handcuff = false;
                    PrisonDoor = false;
                }
                else if (input == "light")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you use the light so see your surroundings,as you do that,you hear a terrifying growl ecoioing the halls, you use the light to check and you see, you see a human,nut he dosent seem friendly, he is holding a huge sword that has whires on it,you definately dont want to get hit, its face is expresionless and his simple glance sends you shivers, after some timee looking at him, you notice his face is actually a mask of a human face. everything in your body tells you one thing.   RUN");
                    Console.Beep(100, 1000);
                    break;
                }
                else
                {
                    Console.WriteLine("thats not a option");
                    input = Console.ReadLine();
                }
            }
            Console.ResetColor();
            Console.WriteLine(name + " what you wanna do?");

            if (Handcuff == true)
            {
                Console.WriteLine("you are still handcuffed");
            }
            if (PrisonDoor == true)
            {
                Console.WriteLine("the door is locked");
            }
            while (true)
            {
                if (key || light)
                {
                    Console.WriteLine("key || light");
                }
                else if (Knife || light)
                {
                    Console.WriteLine("light || knife");
                }
                else if (Knife || key)
                {
                    Console.WriteLine("Knife || key");
                }
                input = Console.ReadLine();
                
                if (input == "light" || Knife)
                {
                    Console.WriteLine("you grab the light and now you can see the room, when you turn to the key you realize the key dissapeared, seems like you will have to find another way to uncoff yourself");
                }

                Console.Beep(1000, 100);
            }
        }
    }
}
