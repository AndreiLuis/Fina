using Fina.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? PaidOrReceivedAt { get; set; }
        public ETransaction Type { get; set; } = ETransaction.Withdraw;
        public decimal Amount { get; set; }
        public long IdCategory { get; set; }
        public Category Category { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;

    }
}
