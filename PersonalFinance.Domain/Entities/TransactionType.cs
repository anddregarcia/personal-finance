using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PersonalFinance.Domain.Enumerators;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinance.Domain.Entities
{
    [Table("TransactionType")]
    public class TransactionType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Tipo de conta")]        
        public EAccountType AccountType { get; set; }

    }
}
