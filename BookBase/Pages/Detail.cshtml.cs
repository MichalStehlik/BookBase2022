using BookBase.Data;
using BookBase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace BookBase.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public DetailModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public Author? Author { get; set; }
        //public List<Book> Books { get; set; }

        public ActionResult OnGet(int id)
        {
            Author = _context.Authors.Find(id);
            if (Author == null)
            {
                return NotFound();
            }
            _context.Entry(Author).Collection(a => a.Books).Load();
            return Page();
        }
    }
}
