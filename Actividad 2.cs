using System;	

namespace Cadena
{
    public class Program
    {
       public static void Main(){
			
			string frase;	
			
			Console.WriteLine("Ingrese una frase cualquiera");
			frase = Console.ReadLine();
			Console.Clear();
			
            Console.WriteLine("Las palabras que contiene la frase ingresada son: " + Metodo(frase));
        }
 
        public static string Metodo(string frase){
        	
			char delimitador = ' ';
			string[] palabras = frase.Split(delimitador);
			int longitud = palabras.Length;
			string palabra = "";
			
			for(int i = 0; i < longitud ; i++){palabra += (palabras[i] + " ");}
			return palabra.TrimEnd().Replace(' ', ',');
        }
    }
}