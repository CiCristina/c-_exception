using csharp_exception.Titular;
using csharp_exception.Contas;



try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parametro com erro"+ ex.ParamName);//ParamName pega qual parametro está lançando essa exceções
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor que 0.");
    Console.WriteLine(ex.Message); //mostra a msg do throw
}