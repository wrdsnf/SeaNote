using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaNote.Models
{
    public class Message
    {
        public long MessageId { get; set; }
        public long SenderId { get; set; }
        public string ReceiverRole { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
    }
}
