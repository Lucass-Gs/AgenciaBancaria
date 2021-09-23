using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.app
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Endereco endereco = new Endereco("RUA TESTE", "134565", "PERDERNEIRAS", "SP");
                Cliente cliente = new Cliente("Carla", "12345646", "11111", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " +conta.Situacao + ": "  + conta.NumeroConta + "-" + 
                    conta.DigitoVerificador);
                string senha = "abc123456";
                conta.Abrir(senha);
                

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo:" + conta.Saldo);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
