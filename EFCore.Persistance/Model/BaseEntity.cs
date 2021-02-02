using System;

namespace EFCore.Persistance.Model
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public BaseEntity()
        {

        }
    }
}
