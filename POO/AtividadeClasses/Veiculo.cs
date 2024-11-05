

namespace AtividadeClasses
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public string cor;
        public float potencia;
        public int qntdPortas;

        public void Acelerar(string Acelerar = "vrum vrum")
        {
            Console.WriteLine($"O veiculo esta acelerando. ");

        }
        public void Ligar(string ligar = "tick tick")
        {
            Console.WriteLine($"O veiculo esta ligado. ");
        }
        public void Desligar(string Desligar = "Truu")
        {
            Console.WriteLine($"O veluiculo desligou. ");
        }
        public void Freiar(string Freiar = "Shiiii")
        {
            Console.WriteLine($"O veiculo esta freiando");
        }
    }
}