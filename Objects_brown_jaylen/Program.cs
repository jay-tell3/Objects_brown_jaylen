namespace Objects_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Aplle","All-in-one",true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));
        }
    }
}