using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinance.Domain.Entities
{
    [Table("Transactions")]
    public class Transactions
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Conta")]
        public virtual Account Account { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Tipo de transação")]
        public virtual TransactionType TransactionType { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Categoria")]
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "O campo é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data do lançamento")]
        public DateTime TransactionDate { get; set;}

        //[Required(ErrorMessage = "O campo é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data do vencimento")]
        public DateTime DueDate { get; set; }

        //[Required(ErrorMessage = "O campo é obrigatório")]
        [DataType(DataType.Currency)]
        [Display(Name = "Valor")]
        public double Value { get; set; }

        //[Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Parcela")]
        public int Parcel { get; set; }

        [Display(Name = "Total de parcelas")]
        public int TotalParcel { get; set; }

        [Display(Name = "Situação")]
        public Boolean Status { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data do pagamento")]
        public DateTime PayDate { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Valor pago")]
        public double PayedValue { get; set; }

        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        [Display(Name = "Identificação do documento")]
        public String DocumentNumber { get; set; }

    }
}
