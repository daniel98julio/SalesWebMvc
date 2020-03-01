using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models {
    public class SalesRecord {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Total da Venda")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(1.0, 50000.0, ErrorMessage = "O {0} Mínimo é de R${1}.")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter no Mínimo {2} caracteres.")]
        public Seller Seller { get; set; }

        public SalesRecord() {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
