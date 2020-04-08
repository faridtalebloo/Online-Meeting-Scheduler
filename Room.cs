using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler
{
    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        [InverseProperty("SelectedRoom")]
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
