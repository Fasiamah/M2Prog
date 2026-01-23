namespace _01_function;

    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //een string variabelen genaamd program samen met de variabelen defenition program
            program.run(); //gebruiken van de function run
        }
    internal void run() {
       string antwoord = Vraag1();
       Console.WriteLine(antwoord);
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();
        Vraag7();
        Vraag8();
        Vraag9();
        Vraag10();
    }

    

    internal string Vraag1()
    {
        Console.WriteLine("How long do you think you will survive a zombie appocalypse?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
    internal string Vraag2()
    {
        Console.WriteLine(" What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag3()
    {
        Console.WriteLine(" If you can still remember, what are your funniest childhood memories? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag4()
    {
        Console.WriteLine(" What would you do if you won a million dollars? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag5()
    {
        Console.WriteLine(" What is the worst game you played but that you liked anyway? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag6()
    {
        Console.WriteLine(" Why do round pizzas come in square boxes? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag7()
    {
        Console.WriteLine(" Has someone caught you dancing in front of the mirror? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag8()
    {
        Console.WriteLine(" Have you ever tried talking to a animal? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag9()
    {
        Console.WriteLine(" What would you call a male ladybug? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
     internal void Vraag10()
    {
        Console.WriteLine(" Which species would be the rudest if all animals could talk? ");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);

        return antwoord;
    }
    
    }
