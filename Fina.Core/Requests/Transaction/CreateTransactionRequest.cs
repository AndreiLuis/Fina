using Fina.Core.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transaction
{
    public class CreateTransactionRequest : Resquest
    {
        [Required(ErrorMessage = "Título inválido")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tipo inválido")]
        public ETransaction Type { get; set; } = ETransaction.Withdraw;
        [Required(ErrorMessage = "Categoria inválida")]
        public long IdCategory { get; set; }
        [Required(ErrorMessage = "Valor inválido")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Data inválida")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
