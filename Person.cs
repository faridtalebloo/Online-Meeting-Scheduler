using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Meeting_Scheduler
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }
        public JobCategory Job { get; set; }


        public virtual ICollection<Invitation> Invitations { get; set; }
    }

    public enum JobCategory
    {
        SeniorDeveloper,
        JuniorDeveloper,
        DocumentController,
        ProjectManager
    }
}
