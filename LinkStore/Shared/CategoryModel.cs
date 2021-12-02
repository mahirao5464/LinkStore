
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LinkStore.Shared
{
  

    public class CategoryModel: BaseClass
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Category Name Is Required")]
        public string? CategoryName { get; set; }        
        [Required]
        public string? Description { get; set; }
        
    }
}
