using System;
using System.Collections.Generic;
using System.Text;
using App2.Classes;
namespace App2
{
    public class SummaryViewModel
    {
        static SummarizeText text = new SummarizeText();
        static string result = String.Join("\n", text.Main().ToArray());
        
        public string FinalSummary = result;
        public string D = "sdfds";
        public SummaryViewModel() {
            SummarizeText text = new SummarizeText();
            var result = String.Join("\n", text.Main().ToArray());
            FinalSummary = result.ToString();
        }
        
    }
}
