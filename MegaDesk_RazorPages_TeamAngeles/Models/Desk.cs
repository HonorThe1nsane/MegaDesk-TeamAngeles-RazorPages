using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MegaDesk_RazorPages_TeamAngeles.Models
{
    public class Desk
    {
        public int ID { get; set; }
        [Range(24, 96)]

        [Display(Name = "Width")]
        public float DeskWidth { get; set; }
        [Range(12, 48)]

        [Display(Name = "Depth")]
        public float DeskDepth { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        public int NumDrawers { get; set; }

        
        [Display(Name = "Desk Material")]
        [Required]
        public string DeskMaterial { get; set; }


        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 28;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;

        [Display(Name = "Name")]
        [Required]
        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTime QuoteDate { get; set; } = DateTime.Now;
        
        [Display(Name = "Express Shipping")]
        public float RushDays { get; set; }

        [Display(Name = "Drawer Cost")]
        [DataType(DataType.Currency)]
        public float DrawerCost { get; set; }

        [Display(Name = "Shipping Cost")]
        [DataType(DataType.Currency)]
        public float RushCost { get; set; }

        [Display(Name = "Quote Total")]
        [DataType(DataType.Currency)]
        public float QuotePrice { get; set; }


        public float MaterialCost;
        public float SurfaceArea;
        public float SizeCost;

        private const int BASE_PRICE = 200;
        private const int SIZE_TRESHHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;


        public float CalcMaterialCost(string material)
        {
            DeskMaterial = material;

            switch (DeskMaterial)
            {
                case "Oak":
                    MaterialCost = 200;
                    break;

                case "Laminate":
                    MaterialCost = 100;
                    break;

                case "Pine":
                    MaterialCost = 50;
                    break;

                case "Rosewood":
                    MaterialCost = 300;
                    break;

                case "Veneer":
                    MaterialCost = 125;
                    break;
            }
            return MaterialCost;
        }


        public float CalcSurfaceArea(float width, float depth)
        {
            DeskWidth = width;
            DeskDepth = depth;
            SurfaceArea = DeskWidth * DeskDepth;
            return SurfaceArea;
        }




        public float CalcSurfaceAreaCost(float SurfaceArea)
        {
            if (SurfaceArea <= 1000)
            {
                SizeCost = BASE_PRICE;
            }
            else
            {
                SizeCost = BASE_PRICE + (SurfaceArea - SIZE_TRESHHOLD);
            }

            return SizeCost;
        }


        public float CalcRushOrderCost(float RushDays, float SurfaceArea)
        {
            if (SurfaceArea<1000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 60;
                        break;
                    case 5:
                        RushCost = 40;
                        break;
                    case 7:
                        RushCost = 30;
                        break;
                }
            }
            else if (SurfaceArea < 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 70;
                        break;
                    case 5:
                        RushCost = 50;
                        break;
                    case 7:
                        RushCost = 35;
                        break;
                }
            }
            else if (SurfaceArea > 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 80;
                        break;
                    case 5:
                        RushCost = 60;
                        break;
                    case 7:
                        RushCost = 40;
                        break;
                }
            }
            return RushCost;
        }
        public float CalcDrawerCost()
        {
            DrawerCost = NumDrawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        public float CalcTotalCost(float MaterialCost, float DrawerCost, float RushCost)
        {
            QuotePrice = SizeCost + MaterialCost + DrawerCost + RushCost;
            return QuotePrice;
        }


        public float deskQuote()
        {

            DrawerCost = NumDrawers * PRICE_PER_DRAWER;

            QuotePrice = BASE_PRICE + SizeCost + DrawerCost + MaterialCost + RushCost;
            return QuotePrice;
        }
    }
}
