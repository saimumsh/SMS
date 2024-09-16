using System.ComponentModel.DataAnnotations;

namespace SMS.core.Models
{
    public class BaseEntiry
    {
        public int ID { get; set; }
        bool IsDeleted { get; set; }
        public BaseEntiry()
        {
            IsDeleted = false;
        }

    }
}
