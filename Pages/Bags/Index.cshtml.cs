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
    public class IndexModel : PageModel
    {
        private readonly Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context _context;

        public IndexModel(Diaconu_Andreea_Pro_.Data.Diaconu_Andreea_Pro_Context context)
        {
            _context = context;
        }

        public IList<Bag> Bag { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Bag = await _context.Bag.ToListAsync();
        }
    }
}
