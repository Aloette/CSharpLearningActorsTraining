namespace MyErp.PrintService
{
    public class PrintingService
    {
        public void Print<T>(T input)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            Console.WriteLine(json);
        }
    }
}