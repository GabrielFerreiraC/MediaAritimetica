Console.WriteLine("Média Aritimética de 3 numeros\n");

Console.WriteLine("Digite seu primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite seu segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite seu terceiro número: ");
double numero3 = Convert.ToDouble(Console.ReadLine());

double media = (numero1 + numero2 + numero3) / 3;

Console.WriteLine($"\nMédia; {media:N1}");
 


