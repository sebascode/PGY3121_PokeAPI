namespace PokeAPP.API.Models
{
    public class Tipo
    {
        public int id_tipo { get; set; }
        public string nombreTipo { get; set; }

        public Tipo()
        {
            this.id_tipo = new int();
            this.nombreTipo = string.Empty;
        }
    }
}