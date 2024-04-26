Console.WriteLine("## Construtor estático##\n");

// Invocar o construtor parametrizado e estático
Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

// Invocar somente o construtor parametrizado, pois o estático só é inicializado uma única vez
Pessoa p2 = new(20, "Manoel");
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

Console.ReadKey();
