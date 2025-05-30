using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.Models
{
    public class Android : Smartphone
    {
    public Android(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
    {
    }

    public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Android.");
        }
    }
}