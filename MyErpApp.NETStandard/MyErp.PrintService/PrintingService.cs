namespace MyErp.PrintService
{
    public class PrintingService
    {
        public string Print<T>(T input)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(input);
        }
    }
}