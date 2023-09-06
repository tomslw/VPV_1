namespace Strals_Uzd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("Audi", "A4", 200.0, 1.9);
            Auto a2 = new Auto("Audi", "A6", 250.0, 2.0);
            Auto a3 = new Auto("Audi", "A8", 300.0, 3.0);
            Auto[] autos = new Auto[] {a1, a2, a3};

            Console.WriteLine();

            string input = "";
            int chosenIndex = 0;
            int chosenAction = 0;
            int speed = 0;

            do
            {
                PrintAutos(autos);
                Console.WriteLine("Ar kuru auto vēlaties veikt darbības? (izvēlaties Nr.)");
                input = Console.ReadLine();
                try
                {
                    chosenIndex = Int32.Parse(input);
                } catch (Exception ex)
                {
                    Console.WriteLine("Ievadiet veselu skaitli!");
                    input = "J";
                    continue;
                }

                if (chosenIndex < 0 || chosenIndex >= autos.Length)
                {
                    Console.WriteLine("Tāda auto Nr. nav sarakstā!");
                    input = "J";
                    continue;
                }

                Console.WriteLine("Izvēlētais auto:");
                autos[chosenIndex].PrintIt();
                Console.WriteLine("Kādu darbību veiksiet? 1 - JaudaHP; 2 - VidPatēriņš; 3 - Bremzēšanas ceļš");
                input = Console.ReadLine();
                try
                {
                    chosenAction = Int32.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ievadiet veselu skaitli!");
                    input = "J";
                    continue;
                }

                switch(chosenAction) 
                {
                    case 1: 
                        Console.WriteLine("JaudaHP: " + autos[chosenIndex].JaudaHP());
                        break;
                    case 2:
                        Console.WriteLine("Vidējais patēriņš uz 100: " + autos[chosenIndex].VidPaterins());
                        break;
                    case 3:
                        Console.WriteLine("Ar kādu ātrumu tiek braukts? (pozitīvs vesels skaitlis)");
                        input = Console.ReadLine();
                        try
                        {
                            speed = Int32.Parse(input);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ievadiet veselu skaitli!");
                            input = "J";
                            continue;
                        }
                        if (speed < 0)
                        {
                            Console.WriteLine("Ātrumam jābūt pozitīvam skaitlim!");
                            break;
                        }
                        Console.WriteLine("Bremzēšanas ceļš: " + autos[chosenIndex].BremzeshanasCelsh(speed));
                        break;
                    default:
                        Console.WriteLine("Tādas darbības nepastāv!");
                        break;
                }

                Console.WriteLine("Turpināsiet darbu? J/N");
                input = Console.ReadLine().ToUpper();
            } while (input.Equals("J"));

        }

        static void PrintAutos(Auto[] autos)
        {
            for (int i = 0; i < autos.Length; i++)
            {
                Console.Write("Nr."+ i + " ");
                autos[i].PrintIt();
            }
        }
    }
}