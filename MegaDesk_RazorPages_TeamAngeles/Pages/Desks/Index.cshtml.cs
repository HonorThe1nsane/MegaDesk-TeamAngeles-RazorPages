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

        public IList<Desk> Desk { get;set; }

        public async Task OnGetAsync()
        {
            Desk = await _context.Desk.ToListAsync();
        }
    }
}
