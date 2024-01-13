using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diaconu_Andreea_Pro_.Data;
using Diaconu_Andreea_Pro_.Models;

namespace Diaconu_Andreea_Pro_.Pages.Bags
{
    public class DeleteModel : PageModel
    {
        private readonly Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context _context;

        public DeleteModel(Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Bag Bag { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bag = await _context.Bag.FirstOrDefaultAsync(m => m.Id == id);

            if (bag == null)
            {
                return NotFound();
            }
            else
            {
                Bag = bag;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bag = await _context.Bag.FindAsync(id);
            if (bag != null)
            {
                Bag = bag;
                _context.Bag.Remove(Bag);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
