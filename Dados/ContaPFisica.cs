namespace Dados
{
    public class ContaPFisica : Conta
    {
        public string Nome { get; set; }
        public string DataNasc { get; set; }
        public string Cpf { get; set; }

        public ContaPFisica() { }
        public ContaPFisica(string id, string agencia, double saldo, string nome, string datanasc, string cpf)
        {
            base.Id = id;
            base.Agencia = agencia;
            base.Saldo = saldo;
            Nome = nome;
            DataNasc = datanasc;
            Cpf = cpf;
        }
        public string Sacar(){
            return "";
        }




    }
}