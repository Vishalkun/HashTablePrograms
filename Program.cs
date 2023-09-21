namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MapNode<string, string> hash = new MapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.Get_Frequency("be");

            string hash5 = hash.Get("5");
            Console.WriteLine("fifth index value is : " + hash5);
        }
    }
}