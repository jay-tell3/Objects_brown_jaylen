namespace Objects_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Computer object
            Computer myComputer = new Computer("Aplle", "All-in-one", true);

            // assigns my Computer to IBootUp interface
            IBootUp myBootUp = myComputer;

            // Check if Computer and IBootUp are equal
            Console.WriteLine(myComputer.Equals(myBootUp)); 

            // Create another Computer object with the same properties
            Computer myOtherComputer = new Computer("Aplle", "All-in-one", true);

            // Checks if the first and second computer objects are equal
            Console.WriteLine(myComputer.Equals(myOtherComputer)); 

            // Sets string to myComputer in two variables
            string myString = myComputer.ToString();
            // myOtherString references the same string
            string myOtherString = myString;

            // Changes myString
            myString = "hi"; 
            // prints hi
            Console.WriteLine(myString);        
            // prints myComputers value
            Console.WriteLine(myOtherString);    

            // Compares myString to string 
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString()); 

            // Output the runtime type of myComputer and myBootUp
            Console.WriteLine(myComputer.GetType());    
            Console.WriteLine(myBootUp.GetType());

            // Calls the method PowerOnOff
            myOtherComputer.PowerOnOff(); 

            // Compares it again after power toggle
            Console.WriteLine(myString == myOtherComputer.ToString());  
            Console.WriteLine(myString);                               
            //changes Tostring
            Console.WriteLine(myOtherComputer.ToString());              

            // Check if myString has the character 'i'
            Console.WriteLine(myString.Contains('i'));   

            // Output uppercase version of myString
            Console.WriteLine(myString.ToUpper());      
        }
    }

}
