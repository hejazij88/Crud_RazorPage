using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_RazorPage.Model;

namespace Crud_RazorPage.Pages
{
    public class StudentIndexModel : PageModel
    {
        private readonly Crud_RazorPage.Model.DatabaseContext _context;

        public StudentIndexModel(Crud_RazorPage.Model.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
