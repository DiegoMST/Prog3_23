
// Operadores Unários
int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++;
x++; x = x + 1;

Console.WriteLine( $"Posfixado: {incrementoPosfixado}" 
);
Console.WriteLine(
    $"Prefixado: {incrementoPosfixado}"
);

// Como obter o tipo de uma variável
Type tipodeInteiro = typeof(int);
Type tipodex = x.GetType();
// Como obter o nome de uma variável
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine(
    "Nome da var: " + nomeDaVariavel 
);

//Operadores de atricuição
int p = 6;
p += 3; //equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -= 3; //equivalente a p = p - 3;
Console.WriteLine($"-={p}");
p *= 3; //equivalente a p = p * 3;
Console.WriteLine($"*={p}");
p /= 3; //equivalente a p = p / 3;
Console.WriteLine($"/={p}");


// OPERADORES LÓGICOS 

bool a = true;
bool b = false;
WriteLine($"AND  |a   |b   ");
WriteLine($"a    |{a & a, -5} | {a & b, -5}");
WriteLine($"b    |{b & a, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR   | a     |b    ");
WriteLine($"a    |{a   | a, -5} | {a | b, -5}");
WriteLine($"b    |{b   | a, -5} | {a | b, -5}");
WriteLine();
WriteLine($"XOR  | a    | b    ");
WriteLine($"a    |{a ^ a, -5}  | {a ^ b, -5}");
WriteLine($"a    |{b ^ a, -5}  | {a ^ b, -5}");