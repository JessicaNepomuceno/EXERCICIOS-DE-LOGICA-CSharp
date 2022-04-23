Console.WriteLine("Informe o valor percentual do reajuste e pressione Enter:");
double reajuste = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do salario atual e pressione Enter:");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O novo salario com o reajuste: {Math.Round(salario + Convert.ToDouble((salario * reajuste)/100), 2)}");

Console.WriteLine("Fim");
