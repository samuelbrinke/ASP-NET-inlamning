using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_inlamning.Models
{
  public class Event
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int OrganizerId { get; set; }
    public string Description { get; set; }
    public string Place { get; set; }
    public DateTime Date { get; set; }
    public int SpotsAvailable { get; set; }
    public List<Attendee> Attendees { get; set; }
  }
}
