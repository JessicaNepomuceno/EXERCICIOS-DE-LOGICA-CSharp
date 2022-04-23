Console.WriteLine("Informe o valor do salario e pressione Enter:");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidade de carros vendidos e pressione Enter:");
int quantidadeDeCarros = Convert.ToInt32(Console.ReadLine());

double valorBaseDoCarro = 200000;

Console.WriteLine($"O valor do salario será de: {(((valorBaseDoCarro * quantidadeDeCarros)*5)/100) + salario}");

Console.WriteLine("Fim");
