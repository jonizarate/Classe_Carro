using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Carro
{
    public class Carro
    {
        public string modelo { get; set; }
        public string marca { get; set; }
        public int anio { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public double cilindrada { get; set; }
        public int numeroDeSerie { get; set; }
        public int canEjes { get; set; }
        public bool  andando {get;set;}
        public bool bocina { get; set; }

        public  Carro()
        {
            modelo ="";
            marca = "";
            anio =0;
            tipo = "";
            color = "";
            cilindrada = 0;
            numeroDeSerie=0;
            canEjes =0;
            andando =false;
            bocina = false;
        }

        public Carro(string modelo, string marca, int anio, string tipo, string color, double cilindrada, int numeroDeSerie, int canEjes, bool andando,bool bocina)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.anio = anio;
            this.tipo = tipo;
            this.color = color;
            this.cilindrada = cilindrada;
            this.numeroDeSerie = numeroDeSerie;
            this.canEjes = canEjes;
            this.andando = andando;
            this.bocina = bocina;

        }

        public bool EstaAndando()
        {
            return andando;
        }

        public bool EmitirSonidoBocina()
        {
            return bocina;
        }
        public bool TieneEjes(int ejes)
        {
            return ejes == 4;
            //return ejes == canEjes;
        }
    }
}
