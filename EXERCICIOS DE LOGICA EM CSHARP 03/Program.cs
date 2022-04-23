Console.WriteLine("Informe o NOME DO MUNICIPIO e depois pressione Enter:");
var nomeDoMunicipio = Console.ReadLine();

string[] texto = new string[] { "ELEITORES", "VOTOS BRANCOS", "VOTOS NULOS", "VOTOS VALIDOS" };
int[] infosEleitorais = new int[4];
var ctd = 0;

foreach (var item in texto)
{
    Console.WriteLine($"Informe a QUANTIDADE DE {item} do municipio e depois pressione Enter:");
    infosEleitorais[ctd] = Convert.ToInt32(Console.ReadLine());
    ctd++;
}

ctd = 0;
foreach (var item in infosEleitorais)
{
    Console.WriteLine($"A quantidade de {texto[ctd]} corresponde a: {(100 * item)/infosEleitorais[0]} %");
    ctd++;
}

Console.WriteLine("Fim ");
