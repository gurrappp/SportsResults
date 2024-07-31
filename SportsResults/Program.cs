using HtmlAgilityPack;



namespace SportsResults
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //two games were played may 19th 2024
            WebScraper scraper = new WebScraper();
            //scraper.GetResult("https://www.basketball-reference.com/boxscores/");
            var results = scraper.GetResults("https://www.basketball-reference.com/boxscores/?month=5&day=19&year=2024");



        }
    }
}




