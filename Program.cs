double Nota1, Nota2, Nota3, Nota4, media;
string resultado;
Console.Clear();
Console.WriteLine("Calcular Média Aritmética de sua Nota"); 
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Para calcularmos a média, digite suas notas por favor: ");
Console.WriteLine("Insira a Nota 1: ");


Nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a Nota 2: ");
Nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a nota 3: ");
Nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a nota 4: ");
Nota4 = Convert.ToDouble(Console.ReadLine());


if (Nota1 < 0 || Nota1> 10
||  Nota2 < 0 || Nota2> 10
||  Nota3 < 0 || Nota3> 10
||  Nota4 < 0 || Nota4> 10)
  {
    Console.WriteLine ("Suas notas devem ser digitadas APENAS entre os números 0 e 10.");
  }
  else
  {
    media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

    if (media < 5)
    {
        resultado = "Nota INSUFICIENTE. Você está REPROVADO.";
    }
   
    else if (media > 6)
    {
        resultado = "Parábens, você está APROVADO.";
    }
    else
    {
        resultado = "Você está em RECUPERAÇÃO.";
    }
    Console.WriteLine($"Sua média foi de {media}. {resultado}");
  }
