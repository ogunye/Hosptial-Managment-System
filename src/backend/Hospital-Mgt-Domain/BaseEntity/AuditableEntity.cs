using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Mgt_Domain.BaseEntity
{
    public abstract class AuditableEntity
    {
        [Key]
        public virtual int Id { get; set; }
        [Required(ErrorMessage ="Created By is a required field.")]
        [StringLength(100, ErrorMessage ="Maximum character length is 100.")]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(100, ErrorMessage = "Maximum character length is 100.")]
        public string? ModifiedBy { get; set;}        
        public DateTime? ModifiedDate { get; set;}
    }
}
