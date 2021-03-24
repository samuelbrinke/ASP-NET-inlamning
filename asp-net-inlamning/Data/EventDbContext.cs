using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace asp_net_inlamning.Data
{
    public class EventDbContext : DbContext
    {
        public EventDbContext (DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Attendee> Attendees { get; set; }
        public DbSet<Models.Event> Events { get; set; }


        public void Seed()
        {
            this.RemoveRange(this.Events);
            //this.RemoveRange(this.Attendees);
            //var attendee = new Models.Attendee { Name = "Admin" };
            this.Attendees.AddRange(new List<Models.Attendee>()
            {
                new Models.Attendee() {Name = "Admin"},
                new Models.Attendee() {Name = "User"}
            });

            this.Events.AddRange(new List<Models.Event>()
            {
                new Models.Event() { Title = "Project X",
                    Description = "The party you've only dreamed about.",
                    Place = "USA, LA",
                    Date = new DateTime(2021, 6, 10),
                    SpotsAvailable = 5 },
                new Models.Event() { Title = "Fyre",
                    Description = "Fyre Festival was a failed, fraudulently-marketed luxury music festival" +
                    " founded by Billy McFarland, CEO of Fyre Media Inc, and rapper Ja Rule. It was created with" +
                    " the intent of promoting the company's Fyre app for booking music talent. The festival was" +
                    " scheduled to take place on April 28–30 and May 5–7, 2017, on the Bahamian island of Great Exuma." },
                new Models.Event() { Title = "Ultra" },
                new Models.Event() { Title = "Tomorrow Land" },
            });

            //this.Add(attendee);
            this.SaveChanges();
        }
    }
}
