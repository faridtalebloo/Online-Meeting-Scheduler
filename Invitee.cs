using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler
{
    public class Invitee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int ResponseID { get; set; }
        public virtual Person InvitedPerson { get; set; }
        public virtual InvitationResponse Response { get; set; }
    }

    public enum InvitationResponse
    {
        Not_Seen,
        Accepted,
        Rejected,
        Tentative
    }
}
