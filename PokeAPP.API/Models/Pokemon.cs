using System;
namespace PokeAPP.API.Models
{
	public class Pokemon
	{
        public int id_pokemon { get; set; }
        public string nombre { get; set; }
        public float estatura { get; set; }
        public float estaturaM2 => this.estatura / 100;
        public float peso { get; set; }
        public float pesoKg => this.peso / 1000;
        public string urlImage { get; set; }
          
        public bool isShiny { get; set; }

        public Tipo tipo { get; set; }
        public Tipo tipo2 { get; set; }

        public Sexualida sexo { get; set; }

        public IList<Ataque> ataques { get; set; }

        public Pokemon()
		{
            this.id_pokemon = new int();
            this.nombre = string.Empty;
            this.estatura = new float();
            this.peso = new float();
            this.isShiny = new bool();
            this.urlImage = string.Empty;

            this.tipo = new Tipo();
            this.tipo2 = new Tipo();

            this.sexo = Sexualida.SinIndicar;

            this.ataques = new List<Ataque>();
        }
	}
}