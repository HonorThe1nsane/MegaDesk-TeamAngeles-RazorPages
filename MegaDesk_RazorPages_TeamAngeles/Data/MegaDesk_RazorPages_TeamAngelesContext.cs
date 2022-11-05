using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_RazorPages_TeamAngeles.Models;

namespace MegaDesk_RazorPages_TeamAngeles.Data
{
    public class MegaDesk_RazorPages_TeamAngelesContext : DbContext
    {
        public MegaDesk_RazorPages_TeamAngelesContext (DbContextOptions<MegaDesk_RazorPages_TeamAngelesContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_RazorPages_TeamAngeles.Models.Desk> Desk { get; set; }
    }
}
