namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone 
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
       Numero = numero;
       Modelo = modelo;
       Imei = imei;
       Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
              Console.WriteLine($"Aplicativo {nomeApp} sendo instalado no Nokia....");
        }

    }
}