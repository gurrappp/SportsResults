using HtmlAgilityPack;



namespace SportsResults
{
    public class Program
    {

        public static void Main(string[] args)
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.basketball-reference.com/boxscores/");

            var test = document.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").First().InnerText;

            Console.WriteLine(test);

            Console.ReadLine();

        }
    }
}




