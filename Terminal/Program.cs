using System;
using Dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {   
            int op;
            Conta conta = new Conta();
            do{
                Console.WriteLine("\nDigite:\n 1- Deposito\n 2- Sacar\n 3- Verificar Saldo\n 4- Verificar CPF\n 9- Sair");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("Informe o valor.");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(conta.Depositar(valor));
                    break;

                    case 2:
                        System.Console.WriteLine("Informe o Valor");
                        valor = Convert.ToDouble(Console.ReadLine());
                        System.Console.WriteLine(conta.Sacar(valor));
                    break;

                    case 3:
                        System.Console.WriteLine(conta.Saldo);
                    break;

                    case 4:
                        System.Console.WriteLine("Informe o CPF: ");
                        string cpf = Console.ReadLine();

                        if(new Cpf().Val(cpf))
                            System.Console.WriteLine("Cpf válido.");
                            else
                                System.Console.WriteLine("Cpf inválido.");
                    break;

                    case 9:
                    break;

                    default:
                        System.Console.WriteLine("Opção inválida");

                    break;
                }
                

            }while(op != 9);

        }
    }
}
