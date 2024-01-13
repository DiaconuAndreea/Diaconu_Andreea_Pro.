using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Diaconu_Andreea_Pro_.Data;
using Diaconu_Andreea_Pro_.Models;

namespace Diaconu_Andreea_Pro_.Pages.Bags
{
    public class CreateModel : PageModel
    {
        private readonly Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context _context;

        public CreateModel(Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bag Bag { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bag.Add(Bag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
