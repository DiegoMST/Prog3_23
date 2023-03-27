
using Exe04;

Console.WriteLine("***************************");
Console.WriteLine("Escrever número por extenso");
Console.WriteLine("***************************");

Console.WriteLine("Informe um número inteiro:");
string numero = Console.ReadLine();

int nro;
try{
    nro = Convert.ToInt32(numero);
} 
catch
{
    Console.WriteLine("O numero não é válido.");
    return;
}
string retorno = "";
switch(numero.Length)
{
    case 1:
        Exe04.Unidade unidade = new Unidade();
        retorno =
        unidade.UnidadePorExtenso(nro);
    break;

    case 2:
        Dezena dezena = new Dezena();
        retorno= dezena.DezenaPorExtenso(nro); 
    break;
}
Console.WriteLine(retorno);
