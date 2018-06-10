namespace Modelos
{
    public class Categoria
    {
        public Categoria()
        {
            Ativo = true;
        }

        public int CategoriaID { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}
