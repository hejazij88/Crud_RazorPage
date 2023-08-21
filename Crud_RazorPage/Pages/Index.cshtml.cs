using Crud_RazorPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crud_RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DatabaseContext _databaseContext;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students=_databaseContext.Students.ToList();
        }
    }
}