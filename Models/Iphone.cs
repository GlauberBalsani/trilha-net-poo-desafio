namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}, no Iphone {Modelo}");
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as Iphone);
        }

        public bool Equals(Iphone other)
        {
            return other != null &&
                    Numero == other.Numero &&
                    Modelo == other.Modelo &&
                    IMEI == other.IMEI &&
                    Memoria == other.Memoria;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numero);
        }
    }
}