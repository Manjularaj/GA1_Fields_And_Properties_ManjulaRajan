namespace GA1_Fields_And_Properties_ManjulaRajan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "John Doe";// Testing setter with validation
            Console.WriteLine(person.Name); // Testing getter

            
            Console.WriteLine(person.ReadOnlyName); //Testing read only property

            //person.WriteOnlyName = "Jane Doe";


        }//End Main


    }//class


}//namespace