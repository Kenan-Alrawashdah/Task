using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
