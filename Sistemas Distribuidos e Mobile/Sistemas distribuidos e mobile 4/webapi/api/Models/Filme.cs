using System.ComponentModel.DataAnnotations;

namespace api.Models{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [MinLength(1, ErrorMessage = "O título do filme deve conter pelomenos um caracter!")]
        [MaxLength(80, ErrorMessage = "O título do filme deve conter até 80 caracteres!")]
        [Required(ErrorMessage = "O título do filme é obregatorio!")]
        public string Titulo { get; set; }

        [MinLength(10, ErrorMessage = "A descrição do filme deve conter pelomenos 10 caracteres!")]
        [MaxLength(100, ErrorMessage = "A descrição do filme deve conter até 100 caracteres!")]
        [Required(ErrorMessage = "A descrição do filme é obregatorio!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Classificação obrigatoria!")]
        public string Classificacao { get; set; }

        [Required(ErrorMessage = "Genero obrigatoria!")]
        public string Genero { get; set; }

    }
}
