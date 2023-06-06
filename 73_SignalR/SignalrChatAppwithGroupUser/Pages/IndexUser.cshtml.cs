using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SignalrChatAppwithGroupUser.Pages
{
    public class IndexUserModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexUserModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}