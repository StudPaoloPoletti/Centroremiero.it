using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CentroRemiero.it.Pages
{
        public class IndexModel : PageModel
    {

        public string testo;

        private readonly int _pageIndex;


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            testo = "prova";
        }
    }
}