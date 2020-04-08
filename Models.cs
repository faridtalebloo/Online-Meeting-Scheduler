using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler.Models
{
    class OMS_Context : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Invitee> Invitees { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
