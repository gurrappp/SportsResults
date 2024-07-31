using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsResults
{
    public class WebScraper
    {

        public List<Result> GetResults(string url)
        {

            List<Result> results = new List<Result>();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            
            var nodes = document.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[3]/div");
            foreach (var node in nodes)
            {
                Result result = new Result
                {
                    WinningTeam = node.SelectSingleNode("table[1]/tbody/tr[1]/td[1]").InnerText,
                    LosingTeam = node.SelectSingleNode("table[1]/tbody/tr[2]/td[1]").InnerText,
                    WinningTeamPoints = int.Parse(node.SelectSingleNode("table[1]/tbody/tr[1]/td[2]").InnerText),
                    LosingTeamPoints = int.Parse(node.SelectSingleNode("table[1]/tbody/tr[2]/td[2]").InnerText),
                };

                results.Add(result);
            }
            
            
            Console.ReadLine();

            return results;
        }
    }
}
