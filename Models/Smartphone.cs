using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string IMEI { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }

        // TODO: Fazer um construtor que recebe os parâmetros necessários para inicializar as propriedades
        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação...");
        }

        public abstract void InstalarApp(string nomeApp);
       
    }
}