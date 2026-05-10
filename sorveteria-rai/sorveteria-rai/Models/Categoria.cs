using System.ComponentModel.DataAnnotations;

namespace sorveteria_rai.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }

        public int StatusCategoria { get; set; }
    }
}
