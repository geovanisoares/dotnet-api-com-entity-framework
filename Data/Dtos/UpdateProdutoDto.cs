using System.ComponentModel.DataAnnotations;

namespace dotnet_api_com_entity_framework.Data.Dtos
{
    public class UpdateProdutoDto
    {

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Nome do produto deve conter ao menos 3 caracteres.")]
        [MaxLength(60, ErrorMessage = "Nome do produto deve conter no máximo 60 caracteres.")]
        public string NomeProduto { get; set; }

        public float ValorProduto { get; set; }
    }
}
