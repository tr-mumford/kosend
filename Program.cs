namespace kosend
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing");

            FakeSend sender = new FakeSend();
            sender.FakeSendPrint();

            //Lets just try out some stuff with pulling data from files
            string filePath = "C:\\Users\\tyler\\Documents\\Repos\\kosend\\TestData\\readit.txt";
            NeedData getted = GetData.Read(filePath);
            Console.WriteLine(getted);
        }
    }
}
