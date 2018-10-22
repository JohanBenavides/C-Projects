using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_Atributos
{
    class Program
    {
        class Bicicleta//Esta clase Bicicleta contiene los atributos de los objetos
        {
            public void imprimircaracteristicas ( int numero_objeto,String estilo, String marco, String modelo, String manubrio, String grupo, String sillin, int ruedas)//metodo para imprimir las caracteristicas
            {
                Console.WriteLine();
                //Estilo, marco, modelo, manubrio, grupo, sillin, ruedas.

                Console.WriteLine("La bicicleta "+numero_objeto+" tiene los sigueintes datos: \n");
                //impresión de cada una de las caracteristicas       
                Console.WriteLine("Estilo: " + estilo);
                Console.WriteLine("Marco: " + marco);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Manubrio: " + manubrio);
                Console.WriteLine("Grupo: " + grupo);
                Console.WriteLine("Sillin: " + sillin);
                Console.WriteLine("Ruedas: " + ruedas + "\n");
            }
            
        }
        static void Main(string[] args)
        {           
            Bicicleta Bici1 = new Bicicleta();//objeto #1
            Bici1.imprimircaracteristicas(1,"Fixie", "Aventador", "2018", "Bullhorn", "Shimano", "Santafixie", 2);//Caracteristicas objeto #1 enviadas como parametro a la función imprimir caracteristicas

            Bicicleta Bici2 = new Bicicleta();//objeto #2  
            Bici2.imprimircaracteristicas(2,"Mountain bike", "GW", "2018", "De montaña", "Sram", "antiprostatico", 2);//Caracteristicas objeto #2 enviadas como parametro a la función imprimir caracteristicas 

            Bicicleta Bici3 = new Bicicleta();//objeto #3
            Bici3.imprimircaracteristicas(3,"Bmx", "Trek", "2010", "Gorilla", "Alu", "odysseey bmx", 2);//Caracteristicas objeto #3 enviadas como parametro a la función imprimir caracteristicas 

            Bicicleta Bici4 = new Bicicleta();//objeto #4  
            Bici4.imprimircaracteristicas(4,"Carretera", "GW", "2016", "Cinelli ruta", "Shimano", "Carbono ruta", 2);//Caracteristicas objeto #4 enviadas como parametro a la función imprimir caracteristicas 

            Bicicleta Bici5 = new Bicicleta();//objeto #5 
            Bici5.imprimircaracteristicas(5,"Monareta", "Feo", "1980", "Ancho", "Pollito", "Alargado y con espaldar", 2);//Caracteristicas objeto #5 enviadas como parametro a la función imprimir caracteristicas
        }
        
    }
}
