using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalendarEvent.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base()
        { }
        
        public DbSet<Event> Events { get; set; }
    }
}