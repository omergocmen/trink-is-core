using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        public int category_id { get; set; }
        public string category_name { get; set;}
    }
}
