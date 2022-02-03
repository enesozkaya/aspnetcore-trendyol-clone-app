using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.Clone.Entities.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [ForeignKey("ParentCategory")]
        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }
    }
}
