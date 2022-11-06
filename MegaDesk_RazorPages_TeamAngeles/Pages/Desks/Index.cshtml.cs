using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_RazorPages_TeamAngeles.Data;
using MegaDesk_RazorPages_TeamAngeles.Models;

namespace MegaDesk_RazorPages_TeamAngeles.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_RazorPages_TeamAngeles.Data.MegaDesk_RazorPages_TeamAngelesContext _context;

        public IndexModel(MegaDesk_RazorPages_TeamAngeles.Data.MegaDesk_RazorPages_TeamAngelesContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";
            DateSort = sortOrder == "Date" ? "DateDesc" : "Date";

            if (_context.Desk != null)
            {
                var entries = from e in _context.Desk
                              select e;

                switch (sortOrder)
                {
                    case "DateSort":
                        entries = entries.OrderBy(n => n.QuoteDate);
                        break;
                    case "DateDesc":
                        entries = entries.OrderByDescending(n => n.QuoteDate);
                        break;
                    case "NameDesc":
                        entries = entries.OrderByDescending(n => n.CustomerName);
                        break;
                    default:
                        entries = entries.OrderBy(n => n.CustomerName);
                        break;
                }

                if (!string.IsNullOrEmpty(SearchString))
                {
                    entries = entries.Where(n => (n.CustomerName.Contains(SearchString)) || (n.CustomerName == SearchString));
                }

                Desk = await entries.AsNoTracking().ToListAsync();
            }
        }
    }
}
