using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Nodes;

namespace ChartExample.Pages
{
    public class DrawChartModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost() { 
        List <string> list = new List<string>();
        foreach (string item in System.IO.File.ReadLines(
            @"C:\\Users\\zertx\\source\\repos\\ChartExample\\ChartExample\\Pages\\sample.txt")) {
                string[] values=item.Split(',');
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);
                dynamic eachDataPoint = new JsonObject();
                eachDataPoint.x = x;
                eachDataPoint.y = y;
                list.Add(eachDataPoint); 
            }
        }
    }
}
