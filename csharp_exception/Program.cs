using csharp_exception.Titular;
using csharp_exception.Contas;
using System.Reflection.Metadata;
using csharp_exception;


LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"); //colocando na variavel leitor
try
{
   
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Fechar();
}


/*
try
{
   ContaCorrente conta1 = new ContaCorrente(0, "1234-X");

   conta1.Sacar(50);
   Console.WriteLine(conta1.GetSaldo());
   conta1.Sacar(150);rdddddr
   Console.WriteLine(conta1.GetSaldo());

}
catch(ArgumentException ex)
{
   Console.WriteLine("Parametro com erro"+ ex.ParamName);//ParamName pega qual parametro está lançando essa exceções
   Console.WriteLine("Não é possível criar uma conta com o número de agência menor que 0.");
   Console.WriteLine(ex.StackTrace);
   Console.WriteLine(ex.Message); //mostra a msg do throw
}
catch(SaldoInsuficienteException ex)
{
   Console.WriteLine("Operação negada! Saldo insuficiente!");
   Console.WriteLine(ex.Message);
}
*/