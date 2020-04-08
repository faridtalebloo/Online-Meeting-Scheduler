using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler
{
    public class Invitation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int MeetingID { get; set; }

        [ForeignKey("MeetingID")]
        public virtual Meeting Meeting { get; set; }

        public virtual ICollection<Invitee> Participants { get; set; }
    }
}
