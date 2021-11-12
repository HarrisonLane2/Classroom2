using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom2.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Sender { get; set; }
        public string Body { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
