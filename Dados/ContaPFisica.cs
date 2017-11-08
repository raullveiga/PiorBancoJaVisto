using System;
using NetOffice.ExcelApi;
using System.IO;

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
        
        public string Salvar(){
            FileInfo f = new FileInfo("Pessoas.xls");
            
            Application ex = null;
            ex = new Application();
            ex.Workbooks.Open("Pessoas.xls");
            ex.Range("A1").Select();

            try{
                ex.Cells[1,1].Value = Nome;
                ex.Cells[1,2].Value = DataNasc;
                ex.Cells[1,2].Value = Cpf;

                msg = "Salvo com sucesso!";
            }
            catch(Exception e){
                msg = "Erro "+e.Message;
            }
            finally{
                ex.Quit();
            }
            
            return "";

        }


        string msg = ""; // String em branco para retorno dos métodos.
        public override string Sacar(double Valor)
        {
            msg = "";
            try
            {
                Saldo -= Valor;
                msg = "Saque realizado!";
            }
            catch (Exception ex)
            {
                msg = "Erro\n" + ex.Message;
            }
            return msg;
        }




    }
}