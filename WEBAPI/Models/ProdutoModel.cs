using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace WEBAPI.Models
{
    public class ProdutoModel
    {
        public int    ID { get; set; }
        public string Nome { get; set; } = string .Empty;
        public string Descricao { get; set; } = string.Empty;
        public int    Quantidade { get; set; }
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }
}
