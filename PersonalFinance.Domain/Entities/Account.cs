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


        public virtual EAccountType AccountType { get; set; }

        public double Limit { get; set; }

        public double InterestRate { get; set; }

        public DateTime DueDay { get; set; }

        public DateTime ClosureDay { get; set; }

        public double InitialBalance { get; set; }

        public double Balance { get; set; }

        public bool UseInGlobalBalance { get; set; }

    }
}
