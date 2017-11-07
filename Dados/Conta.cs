using System;

namespace Dados{
    public class Conta{
        public string Id { get; set; }
        public string Agencia { get; set; }
        public double Saldo { get; protected set; }
    public Conta(){}
    public Conta(string id, string agencia, double saldo){
        Id = id;
        Agencia = agencia;
        Saldo = saldo;
    }
    string msg = "";

    /// <summary>
    /// O método Sacar subtrai o valor passado do Saldo da conta
    /// </summary>
    /// <param name="Valor">Passe Valor como double</param>
    /// <returns></returns>
    public virtual string Sacar(double Valor){
        msg = "";
        try{
        Saldo-=Valor;
        msg = "Saque realizado!";
        }
        catch(Exception ex){
        msg = "Erro\n"+ex.Message;
        }
        return msg;
    }
    /// <summary>
    /// O método Depositar adiciona o valor passado ao Saldo da conta
    /// </summary>
    /// <param name="Valor">Passe Valor como double</param>
    /// <returns></returns>
    public virtual string Depositar(double Valor){
        msg = "";
        try{
        Saldo+=Valor;
        msg = "Deposito realizado!";
        }
        catch(Exception ex){
        msg = "Erro\n"+ex.Message;
        }
        return msg;
    }
}
}