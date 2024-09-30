namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Random random = new Random();
            int hemligtnummer = random.Next(1, 101);
            bool Rätt = false;
            Console.WriteLine("Välkomen till mitt spel");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("Jag har valt ut ett nummer mellan 1-100 och du ska gissa dig fram");

            

            while (!Rätt)
            {
                int gissanummret = Convert.ToInt32(Console.ReadLine());
                score++;
                if (gissanummret == hemligtnummer)
                {
                    Console.WriteLine("Rätt");
                    Rätt = true;
                    
                }

                else if (gissanummret < hemligtnummer)

                {
                    Console.WriteLine("Du gissade för lågt");
                    //score++;
                }

                else
                {
                    Console.WriteLine("Du gissade för högt");
                    //score++;
                }

            }
            Console.WriteLine($"{hemligtnummer} var svaret Det tog {score}st gissningar att lista ut mitt nummer!");
           

        }

        



    }
}
