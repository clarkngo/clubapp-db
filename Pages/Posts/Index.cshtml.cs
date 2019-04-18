using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPost.Models;

namespace clubapp_db.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPost.Models.RazorPagesPostContext _context;

        public IndexModel(RazorPagesPost.Models.RazorPagesPostContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
