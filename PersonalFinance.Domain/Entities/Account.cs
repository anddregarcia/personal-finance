using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PersonalFinance.Domain.Enumerators;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinance.Domain.Entities
{
    [Table("Accounts")]
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O campo é obrigatório")]
        [StringLength(100, ErrorMessage="O campo deve ter no máximo 100 caracteres")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Display(Name = "Tipo de conta")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public virtual EAccountType AccountType { get; set; }

        [Display(Name = "Limite da conta")]
        [DataType(DataType.Currency)]
        public double Limit { get; set; }

        [Display(Name = "Taxa de juros")]
        public double InterestRate { get; set; }

        [Display(Name = "Dia de vencimento")]
        [DataType(DataType.Date)]
        public DateTime DueDay { get; set; }

        [Display(Name = "Dia de vencimento")]
        [DataType(DataType.Date)]
        public DateTime ClosureDay { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Saldo inicial")]
        [DataType(DataType.Currency)]
        public double InitialBalance { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Saldo Atual")]
        [DataType(DataType.Currency)]
        public double Balance { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Considerar saldo atual na totalização?")]
        public bool UseInGlobalBalance { get; set; }

    }
}
