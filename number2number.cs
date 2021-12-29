namespace N2N 
{
    class Program 
    {
        public static int cijfer; // zonder static kan deze integer niet gelezen worden
        static void Main() 
        {
            Console.Write("Vul een nummer in (in tekst): ");
            string input = Console.ReadLine();//console.read() zorgt voor meer problemen dan oplossingen

            if (input != null && !int.TryParse(input, out int value)) //tryparse kijkt ofdat het een integer is.
            {
                textConverter(input);
                Console.WriteLine("Je cijfer: " + cijfer);
            }
            else 
            {
                Console.WriteLine("Foutieve input");
            }
        }
        static void textConverter(string input)
        {
            switch (input)
            {
                case "één":
                    cijfer = 1;
                    break;
                    
                case "twee":
                    cijfer = 2;
                    break;
                    
                case "drie":
                    cijfer = 3;
                    break;
                    
                case "vier":
                    cijfer = 4;
                    break;
                    
                case "vijf":
                    cijfer = 5;
                    break;
                    
                case "zes":
                    cijfer = 6;
                    break;
                    
                case "zeven":
                    cijfer = 7;
                    break;
                    
                case "acht":
                    cijfer = 8;
                    break;
                    
                case "negen":
                    cijfer = 9;
                    break;
                    
                case "tien":
                    cijfer = 10;
                    break;

            }
        }
    }
}