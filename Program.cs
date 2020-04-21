using System;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            string opc;
            int n=0;
            while(n < 12){
            Console.WriteLine("Sitema Experto Bancario");
            Console.WriteLine("Edgar Escalona Escalona ");
             
             Console.WriteLine("Tiene cuenta bancaria (si/no)");
             opc = (Console.ReadLine());
             if (opc=="si"){
                   Console.WriteLine("Tiene tarjeta de credito (si/no) ");
                   opc = (Console.ReadLine());
                       if (opc=="si"){
                           Console.WriteLine("Ingresa NIP  (si/no)");
                             opc = (Console.ReadLine());
                            if(opc=="si"){

                                           Console.WriteLine("NIP Correcto (si/no)");
                                           opc = (Console.ReadLine());
                                           if(opc=="si"){
                                                Console.WriteLine("Cajero con saldo (si/no)");
                                                 opc = (Console.ReadLine());
                                                 if (opc=="si"){
                                                         Console.WriteLine("Uso del cajero exelente");
                                                         Console.WriteLine("Gracias por usuarlo");
                                                 }else{

                                                         Console.WriteLine("Error no se cumple las reglas de cajero");
                                                 }
                                           }else{
                                               Console.WriteLine("Error no se cumple las reglas de cajero");
                                           }
                                     
                                             }else {
                                               Console.WriteLine("Error no se cumple las reglas de cajero");
                                              }
                                              }else{
                                              Console.WriteLine("Error no se cumple las reglas de cajero");
                                             }
                 
   
                                             } else{
                Console.WriteLine("Gracias por su comprension");
             }
            }


            

           
            


        }
    }
}
