using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Diaconu_Andreea_Pro_.Data;
using Diaconu_Andreea_Pro_.Models;

namespace Diaconu_Andreea_Pro_.Pages.Bags
{
    public class EditModel : PageModel
    {
        private readonly Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context _context;

        public EditModel(Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context context)
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

            var bag =  await _context.Bag.FirstOrDefaultAsync(m => m.Id == id);
            if (bag == null)
            {
                return NotFound();
            }
            Bag = bag;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BagExists(Bag.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BagExists(int id)
        {
            return _context.Bag.Any(e => e.Id == id);
        }
    }
}
