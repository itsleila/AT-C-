using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }

        public string Nome { get; set; }

        public string Local { get; set; }
        public List<Funcionario>? Funcionarios { get; set; }
    }
 }
