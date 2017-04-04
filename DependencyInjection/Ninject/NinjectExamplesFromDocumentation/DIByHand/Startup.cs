namespace DIByHand
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var firstWarrior = new Samurai(new Shuriken());
            var secondWarrior = new Samurai(new Sword());
            firstWarrior.Attack("the joker");
            secondWarrior.Attack("batman");
        }
    }
}
