﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_inlamning.Models
{
  public class Organizer
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Event> Events { get; set; }
  }
}
