namespace ForHealing
{
    internal class Program

    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 4.20}; //als je 3 prijzen hebt en 4 artiekelen, dan werkt het niet, omdat de artiekel en prijs niet samen zijn
            string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "maaltijd" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker",
                Sterren = 5,
            };
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artiekelen[i]);
            }
        }
    }
}
