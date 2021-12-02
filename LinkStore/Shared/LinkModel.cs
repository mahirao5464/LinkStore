using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkStore.Shared
{
    public class LinkModel: BaseClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Uri? ImpLink { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public CategoryModel? Category { get; set; }
        [Required]
        public LinkType LinkType { get; set; }
        [Required]
        public string? Description { get; set; }


    }
    

}
