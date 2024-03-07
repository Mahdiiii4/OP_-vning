namespace OP
{
    public class Doom : Spel
    {
        public Doom()
        {
            titel = "Doom";
        }
        public override void Kör()
        {
            Console.WriteLine($"{titel} körs!");
        }
    }
}