using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models {
    public class Seller {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter no Mínimo {2} caracteres.")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "Insira um E-mail Válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Aniversário")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salário Base")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(1039.0, 50000.0, ErrorMessage = "O {0} Mínimo é de R${1}.")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        [Display(Name = "Departamento")]
        public Department Department { get; set; }
        public int DepartmentId {get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr) {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr) {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(sr => sr.Date >= initial && sr.Date >= final).Sum(sr => sr.Amount);
        }
    }
}
