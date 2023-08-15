using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo do Filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do Filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pdoerá ultrapassar 50 caracteres.")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do Filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração não deve ultrapassar mais de 600 minutos e nem ser menor que 70 minutos.")]
    public int Duracao   { get; set; }

}
