using System;

namespace EFCore.Persistance.Model
{
    public class TeamMember : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TitleType Title { get; set; }
        public Guid? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
