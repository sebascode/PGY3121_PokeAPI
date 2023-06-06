namespace PokeAPP.API.Models
{
    public class Ataque
    {
        public int id_ataque { get; set; }
        public string Nombre { get; set; }
        public Tipo tipo { get; set; }
        public int PP { get; set; }
        public int precision { get; set; }
        public int damage { get; set; }
    }
}