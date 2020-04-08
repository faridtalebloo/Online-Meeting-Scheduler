using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler
{
    public class Meeting
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime FromDateTime{ get; set; }
        public DateTime ToDateTime { get; set; }
        public int PersonID { get; set; }
        public int RoomID { get; set; }

        [ForeignKey("PersonID")]
        public virtual Person Initiator { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room SelectedRoom { get; set; }

        [ForeignKey("InvitationID")]
        public virtual Invitation Invitation { get; set; }
    }
}
