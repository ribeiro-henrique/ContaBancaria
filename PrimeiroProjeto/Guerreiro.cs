

using System.Security.AccessControl;

namespace PrimeiroProjeto {
    internal class Guerreiro {

        public string Nome { get; set; }
        public double Vida { get; set; }
        public double Armadura { get; set; }
        public double Forca { get; set; }
        public double Intelecto { get; set; }
        public string Style { get; set; }

        public Guerreiro(string nome, double vida, double armadura, double forca, double intelecto, string style) {
            Nome = nome;
            Armadura = armadura;
            Forca = forca;
            Intelecto = intelecto;
            Vida = vida;
            Style = style;
        }

        public double SecondWind() {
            return Vida + 10;
        }

        public override string ToString() {
            string ficha = $"Nome: {Nome}\n" +
                           $"Vida: {Vida}\n" +
                           $"Armadura: {Armadura}\n" +
                           $"Força: {Forca}\n" +
                           $"Intelecto: {Intelecto}\n" +
                           $"Estilo de Luta: {Style}\n";

            return ficha;
        }
    }
}
