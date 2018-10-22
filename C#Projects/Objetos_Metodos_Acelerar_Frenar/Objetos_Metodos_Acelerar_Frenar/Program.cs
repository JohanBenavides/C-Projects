using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Objetos_Metodos_Acelerar_Frenar
{
    class Program
    {
        static int tiempo = 300;
        static int velocidadmaxima = 60;
        static int velocidadmax = 40;
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
            public void acelerar(int maxvelocidad)
            {
                int i = 2;//aumento progresivo de velocidad de 2 en 2
                Console.WriteLine("La bicicleta empezara a acelerar\nSu velocidad es: ");
                for (; i <= maxvelocidad; i += 2)
                {//ciclo de aumento de velocidad hasta llevar a la velocidad estandar
                    Thread.Sleep(tiempo);//retardo de tiempo en la impresión en consola
                    Console.WriteLine("\t\t" + i + " km/h");
                }
                Console.WriteLine("La bicicleta alcanzo una velocidad de " + (i - 2) + " km/h");
            }
            public void girar()
            {
                Console.WriteLine("La bicicleta esta girando");
            }
            public void picar(int maxvelocidad, int velocidadestandar)
            {
                int i = velocidadestandar;//velocidad estantar
                Console.WriteLine("La bicicleta empezara a picar\nSu velocidad es: ");
                for (; i <= maxvelocidad; i++)
                {//ciclo de aumento de velocidad desde la velocidadestandar hasta la velocidad maxima
                    Thread.Sleep(tiempo);//retardo de tiempo en la impresión en consola
                    Console.WriteLine("\t\t" + i + " km/h");
                }
                Console.WriteLine("La bicicleta alcanzo una velocidad de " + (i - 1) + " km/h");
            }
            public void frenar(int maxvelocidad)
            {
                int i = maxvelocidad;
                Console.WriteLine("La bicicleta empezara a frenar\nSu velocidad es: ");
                for (; i >= 0; i -= 2)
                {//ciclo para reducir el contador de la velocidad maxima hasta 0
                    Thread.Sleep(tiempo);//retardo de tiempo en la impresión en consola
                    Console.WriteLine("\t\t" + i + " km/h");
                }
                Console.WriteLine("La bicicleta a frenado totalmente");
            }

        }
        static void Main(string[] args)
        {
            Bicicleta Bici1 = new Bicicleta();//objeto #1
            Bici1.imprimircaracteristicas("Fixie", "Aventador", "2018", "Bullhorn", "Shimano", "Santafixie", 2);//Caracteristicas objeto enviadas como parametro a la función imprimir caracteristicas
            Bici1.acelerar(velocidadmax);//llamdo de metodo de acelerar enviando como parametro la velocidad maxima
            Bici1.girar();//llamado del metodo de girar
            Bici1.picar(velocidadmaxima,velocidadmax);//llamado del emtodo picar, recive como parametro la velocidad estandar alcanzada y la velocidad maxima a alcanzar
            Bici1.frenar(velocidadmaxima);//llamado del metodo de frenar recibe como parametro la velocidad maxima alcanzada
        }

    }
}
