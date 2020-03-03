using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RegularExpressionServices2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string change { get; internal set; }
        public string pattern { get; internal set; }
        public string result { get; internal set; }

        public void OnGet(string change, string pattern)
        {
            this.change = change;
            this.pattern = pattern;

            if (true &&
                (
                this.change == null ||
                this.pattern == null))
            {
                return;
            }
            var Match = Regex.Match(this.change, this.pattern);

            if (Match.Success == true)
            {
                this.result = this.change;
            }
            else
            {
                this.result = "";
            }
            
        }
    }
}
