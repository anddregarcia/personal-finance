using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Domain.Entities
{
    [Table("Transactions")]
    public class Transactions
    {
        public int Id { get; set; }

        public virtual Account Account { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public DateTime TransactionDate { get; set;}
        public DateTime DueDate { get; set; }

        public double Value { get; set; }
        public int Parcel { get; set; }
        public int TotalParcel { get; set; }
        public Boolean Status { get; set; }
        public DateTime PayDate { get; set; }
        public double PayedValue { get; set; }
        public String DocumentNumber { get; set; }

    }
}
