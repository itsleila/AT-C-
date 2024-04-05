using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InfnetMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayName("Data de Nascimento")]
        public string DataNascimento { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento? Departamento { get; set; }
    }
}