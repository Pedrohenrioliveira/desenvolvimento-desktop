using MultApps.Models.Entidades;
using MultApps.Models.Entities.Abstract;

namespace MultApps.Models.Entities
{
    public class Produto : EntidadeBase
    {
        public string Url { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}
