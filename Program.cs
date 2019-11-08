using InvestTool.Processing;


namespace InvestTool
{
    class Program
    {
        private static void Main()
        {
            Input input = new Input();
            TotalModel model= new TotalModel(input);
            Output output = new Output(model);

            //const string tickers = "AAPL,GOOG,GOOGL,YHOO,TSLA,INTC,AMZN,BIDU,ORCL,MSFT,ORCL,ATVI,NVDA,GME,LNKD,NFLX";

            //string json;

            //using (var web = new WebClient())
            //{
            //    var url = $"http://finance.google.com/finance/info?client=ig&amp;amp;q=NASDAQ%3A{tickers}";
            //    json = web.DownloadString(url);
            //}

            ////Google adds a comment before the json for some unknown reason, so we need to remove it
            //json = json.Replace("//", "");

            //var v = JArray.Parse(json);

            //foreach (var i in v)
            //{
            //    var ticker = i.SelectToken("t");
            //    var price = (decimal)i.SelectToken("l");

            //    Console.WriteLine($"{ticker} : {price}");
            //}

            //Console.WriteLine("Press any key to exit");
            //Console.Read();
        }
    }
}
