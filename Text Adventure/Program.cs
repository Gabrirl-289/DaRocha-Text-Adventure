namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameOfVariable = 3, helloworld = 6;
            float distanceToStore, howcoolDerekis = 10.5f;
            double inflation = 10.5f;
            string myword = "you are handcuffed";
            char myCharacterOrletter = 'A';
            bool vgd = true;
            nameOfVariable = 10;
            nameOfVariable = 16;
            myword = "good morning";
            Console.WriteLine(nameOfVariable);

            //Console.ReadKey();
            Console.WriteLine("you are locked in what looks like a prison, its too dark, your hands are handcuffed,");
            Console.WriteLine("there is a knife on the table, a key on the ground and a light on the bed");
            Console.WriteLine("knife|key|light");


            Console.ReadLine();

            string input = Console.ReadLine();
            if (input == "knife")
            {
                Console.WriteLine("you brab the knife, as you do that you hear a terrifying growl ecoioing the halls, you cant see but its definately here ");

            }
            else if (input == "key")
            {
                Console.WriteLine("you use to uncoff yourself and unlock the cell, as you do that you hear a terrifying growl ecoioing the halls, you cant see but its definately here ");
            }
            else if (input == "light")
            {
                Console.WriteLine("you use the light so see your surroundings,as you do that,you hear a terrifying growl ecoioing the halls, you use the light to check and you see, a strange creature, its face is expresionless and his simple glance sends you shivers.");

            }
        }
    }
}
