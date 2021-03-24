using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_net_inlamning.Data;
using asp_net_inlamning.Models;

namespace asp_net_inlamning.Pages
{
    public class EventsModel : PageModel
    {
        private readonly asp_net_inlamning.Data.EventDbContext _context;

        public EventsModel(asp_net_inlamning.Data.EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events.ToListAsync();
        }
    }
}
