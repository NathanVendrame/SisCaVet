namespace SisCaVet.Models
{
    public class Veterinario : Pessoa
    {
        public string Especialidade { get; set; }
        public decimal Salario { get; set; }
        public int Crmv { get; set; }
        public string Email {get; set;}
        public string Senha { get; set; }

    }
}