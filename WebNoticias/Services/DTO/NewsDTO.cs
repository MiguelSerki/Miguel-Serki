using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class NewsDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int UserCreatedId { get; set; }

        public int UserModifiedId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
