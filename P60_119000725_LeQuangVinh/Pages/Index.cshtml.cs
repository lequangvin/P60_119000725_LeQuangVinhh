using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace WebApp.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

   private readonly WebAppContext _context;

    public IndexModel(WebAppContext context)
    {
        _context = context;
    }

    public IList<WebApp.Models.News> News { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        
       News = await _context.News.ToListAsync();
       
       return Page();
    }
}
