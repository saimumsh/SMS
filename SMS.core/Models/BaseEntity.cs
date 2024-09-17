using System.ComponentModel.DataAnnotations;

namespace SMS.core.Models
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        bool IsDeleted { get; set; }
        public BaseEntity()
        {
            IsDeleted = false;
        }

    }
}
