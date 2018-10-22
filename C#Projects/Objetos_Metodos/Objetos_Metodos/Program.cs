using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_Metodos
{
    class Program
    {
        class Bicicleta//Esta clase Bicicleta contiene los atributos de los objetos
        {
            public void imprimircaracteristicas(String estilo, String marco, String modelo, String manubrio, String grupo, String sillin, int ruedas)//metodo para imprimir las caracteristicas
            {
                Console.WriteLine();
                //Estilo, marco, modelo, manubrio, grupo, sillin, ruedas.

                Console.WriteLine("La bicicleta tiene los sigueintes datos: \n");
                //impresión de cada una de las caracteristicas       
                Console.WriteLine("Estilo: " + estilo);
                Console.WriteLine("Marco: " + marco);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Manubrio: " + manubrio);
                Console.WriteLine("Grupo: " + grupo);
                Console.WriteLine("Sillin: " + sillin);
                Console.WriteLine("Ruedas: " + ruedas + "\n");
            }
            public void acelerar()
            {
                Console.WriteLine("La bicicleta esta acelerando");
            }
            public void girar()
            {
                Console.WriteLine("La bicicleta esta girando");
            }
            public void picar()
            {
                Console.WriteLine("La bicicleta esta picando");
            }
            public void frenar()
            {
                Console.WriteLine("La bicicleta ha frenado");
            }

        }
        static void Main(string[] args)
        {
            Bicicleta Bici1 = new Bicicleta();//objeto #1
            Bici1.imprimircaracteristicas("Fixie", "Aventador", "2018", "Bullhorn", "Shimano", "Santafixie", 2);//Caracteristicas objeto #1 enviadas como parametro a la función imprimir caracteristicas
            Bici1.acelerar();
            Bici1.girar();
            Bici1.picar();
            Bici1.frenar();
        }

    }
}