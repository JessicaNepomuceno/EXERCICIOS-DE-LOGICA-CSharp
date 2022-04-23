Console.WriteLine("Informe sua idade e pressione Enter:");
int idadeEmAnos = Convert.ToInt16(Console.ReadLine());
int idadeEmDias = idadeEmAnos * 365;
int idadeEmMes = idadeEmAnos * 12;
Console.WriteLine($"A sua idade: {idadeEmAnos} anos, é equivalente: {idadeEmDias} dias ou {idadeEmMes} meses");
Console.WriteLine("Fim");
