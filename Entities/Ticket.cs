using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsMNG.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string User { get; set; }

        public DateTime Createdon { get; set; }

        public DateTime Modifiedon { get; set; }

        public String Status { get; set; }

    }
}
