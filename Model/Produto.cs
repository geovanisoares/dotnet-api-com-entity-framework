using System.ComponentModel.DataAnnotations;
using System.Web.Http.OData;

namespace dotnet_api_com_entity_framework.Model
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Nome do produto deve conter ao menos 3 caracteres.")]
        [MaxLength(60, ErrorMessage = "Nome do produto deve conter no máximo 60 caracteres.")]
        public string NomeProduto { get; set;}

        public float ValorProduto { get; set; }

        
    }
}
