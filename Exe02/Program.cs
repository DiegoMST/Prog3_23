Console.WriteLine("olá, seja bem-vindo!");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine($"olá {name} prazer conhece-lo");


// Declarar sem inicializar / primitivo
string message1;
// Declarar inicializar / abstrato
String messege2 = "Seu Nome Completo";
// Declarar String vazia
string message3 = String.Empty;
string message4 = ""; 

//Declaração com tipo implícito
var message5 = "Mensagem aleatória";

message1 = "Rogério Ceni;Pelé";
var palavras = message1.Split(';');
foreach(var word in palavras)
{
    //variável de escopo lical do
    //laço de repetição foreach
    int a = 10;
    Console.WriteLine(word); 
}




