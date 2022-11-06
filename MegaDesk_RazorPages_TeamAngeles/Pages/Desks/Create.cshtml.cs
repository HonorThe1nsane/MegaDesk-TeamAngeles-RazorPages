using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_RazorPages_TeamAngeles.Data;
using MegaDesk_RazorPages_TeamAngeles.Models;

namespace MegaDesk_RazorPages_TeamAngeles.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_RazorPages_TeamAngeles.Data.MegaDesk_RazorPages_TeamAngelesContext _context;
        public const int SQUAREPRICE = 1;
        public const int DRAWERPRICE = 50;
        public CreateModel(MegaDesk_RazorPages_TeamAngeles.Data.MegaDesk_RazorPages_TeamAngelesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Desk quoteDesk { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            quoteDesk.QuotePrice = CalculateQuoteTotal(quoteDesk);
            /*quoteDesk.RushDays = quoteDesk.*/
            
            _context.Desk.Add(quoteDesk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
        public float CalculateQuoteTotal(Desk quote)
        {
            float calMaterialCost = quote.CalcMaterialCost(quote.DeskMaterial);
            float calShippingCost = quote.CalcRushOrderCost(quote.RushDays, quote.SurfaceArea);
            float drawerCost = quote.CalcDrawerCost();
            float surfaceArea = quote.CalcSurfaceArea(quote.DeskWidth, quote.DeskDepth);
            float surfaceAreaCost = quote.CalcSurfaceAreaCost(quote.SurfaceArea);
            float totalCost = calMaterialCost + calShippingCost + drawerCost + surfaceAreaCost;


            return totalCost;
        }

  /*        public float RushDays(DeskQuote)
        {

        }*/
    }
    }

