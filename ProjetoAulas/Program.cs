// Console.WriteLine("Primeiro programa");

// int idade = 19;
// Console.WriteLine(idade);
// string nomePessoa = "Ray";
// Console.WriteLine(nomePessoa);
// decimal valor = 200.99m;
// Console.WriteLine(valor);
// double valorDouble = 200.99;
// Console.WriteLine(valorDouble);
// float valorFloat = 200.99f;
// Console.WriteLine(valorFloat);
// var idadeNova = 20;
// char flag = 'Y';
// Console.WriteLine(flag);
// bool ativo = false;
// ativo = true;
// Console.WriteLine(ativo);


// const string descricao = "Curso C#";

// Console.WriteLine(descricao);

// int numero1 = 1;
// var numero2 = 2;

// int soma = numero1 + numero2;
// Console.WriteLine(soma);

// int subtracao = numero2 - numero1;
// Console.WriteLine(subtracao);

// int multiplicacao = (numero2 * numero1) * 10;
// Console.WriteLine(multiplicacao);

// int divisao = numero2 / numero1;
// Console.WriteLine(divisao);

// bool igual = numero1 == numero2;
// Console.WriteLine(igual);

// bool maior = numero2 > numero1;
// Console.WriteLine(maior);

// bool menor = numero2 < numero1;
// Console.WriteLine(menor);

// bool menorOuIgual = numero2 <= numero1;
// Console.WriteLine(menorOuIgual);

// bool maiorOuIgual = numero2 >= numero1;
// Console.WriteLine(maiorOuIgual);

// bool diferente = numero2 != numero1;
// Console.WriteLine(diferente);


int numero1 = 1;
var numero2 = 2;

/* && */
// bool valido = numero2 > numero1 && 6 > 7;
// Console.WriteLine(valido);
// /* && é verdadeiro se ambos forem verdadeiros */

// /* || */
// bool valido2 = numero2 > numero1 || 6 > 7;
// Console.WriteLine(valido2);
// /* || é verdadeiro se um dos critérios forem verdadeiros */

// /* ! */
// bool valido3 = !(numero2 > 3);
// Console.WriteLine(valido3);
/* ! é verdadeiro se um dos critérios forem verdadeiros */

bool ativo = true;
string status = !ativo ? "Cadastro ativo" : "Cadastro inativo";
Console.WriteLine(status);