﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCRUD.Data;
using RazorCRUD.Model;

namespace RazorCRUD.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly RazorCRUD.Data.RazorCRUDContext _context;

        public CreateModel(RazorCRUD.Data.RazorCRUDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public student student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.student == null || student == null)
            {
                return Page();
            }

            _context.student.Add(student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
