using System.Collections.Generic;

namespace EFCore.Persistance.Model
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<TeamMember> Members { get; set; }
    }
}
