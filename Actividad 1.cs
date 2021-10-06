using System;

namespace Array{
    public class main{
        public static void Main(){
            int[] valores = new int[5] {20,30,40,60,80};
            float promedio = 0;
            int longitud = valores.Length;

            for(int i = 0; i < longitud; i++) {
                promedio += valores[i];
            }

            promedio = promedio/longitud;
            Console.WriteLine("el promedio es: " + promedio);
        }
    }
}