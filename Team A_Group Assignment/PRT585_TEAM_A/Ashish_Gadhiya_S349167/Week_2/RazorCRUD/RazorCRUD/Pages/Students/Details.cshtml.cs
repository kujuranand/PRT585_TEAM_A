using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCRUD.Data;
using RazorCRUD.Model;

namespace RazorCRUD.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCRUD.Data.RazorCRUDContext _context;

        public DetailsModel(RazorCRUD.Data.RazorCRUDContext context)
        {
            _context = context;
        }

      public student student { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.student == null)
            {
                return NotFound();
            }

            var student = await _context.student.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                student = student;
            }
            return Page();
        }
    }
}
