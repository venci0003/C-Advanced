namespace ChristmasPastryShop
{
    using ChristmasPastryShop.Core;
    using ChristmasPastryShop.Core.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Don't forget to comment out the commented code lines in the Engine class!
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
