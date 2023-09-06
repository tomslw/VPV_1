// See https://aka.ms/new-console-template for more information
String turp = "";
do
{

    Console.WriteLine("Ievadiet skaitli");
    String sk_str = Console.ReadLine();
    if (sk_str == null)
    {
        turp = "J";
        continue;
    }

    try
    {
        int sk_int = Int32.Parse(sk_str);
        Console.WriteLine("Ievadiet operaciju, kuru velaties izpildit ievaditajam skaitlim:\nAtrast kvadratu - 1\nKvadratsakne - 2\nLogaritms - 3\nFaktorialis - 4");
        String izvele_str = Console.ReadLine();
        // should do null check but will ignore for now
        int izvele = Int32.Parse(izvele_str);

        switch (izvele)
        {
            case 1:
                Console.WriteLine("kvadrats = " + sk_int * sk_int);
                break;
            case 2:
                Console.WriteLine(((sk_int >= 0) ? ("kvadratsakne = " + Math.Sqrt((double)sk_int)) : ("kvadratsanke neeksiste!")));
                break;
            case 3:
                Console.WriteLine(((sk_int > 0) ? ("log = " + Math.Log((double)sk_int)) : ("log neeksiste!")));
                break;
            case 4:
                int fac = 1;
                for (int i = 1; i <= sk_int; i++)
                {
                    fac *= i;
                }
                Console.WriteLine(((sk_int >= 0) ? ("faktorials = " + fac) : ("faktorials neeksiste?!?")));
                break;
            default:
                Console.WriteLine("Nav sadas darbibas");
                break;

        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Jus ievadijat nepareizus datus:\n" + e.Message);
    }

    Console.WriteLine("Vai velaties turpinat so aizraujoso programminu ([J]a/[N]e)");
    turp = Console.ReadLine().ToUpper();
} while (turp[0] == 'J');
