public class Program
{
	public static void Aula1(string[] args)
	{
		Console.WriteLine("---------------- ARGS ----------------");

		string number1 = args[0];
		string number2 = args[1];

		int number1AsInt = Convert.ToInt32(number1);
		int number2AsInt = Convert.ToInt32(number2);



		Console.WriteLine(number1);
		Console.WriteLine(number2);

		Console.WriteLine("---------------- TIPOS PRIMITIVOS ----------------");

		// tipos primitivos
		int i = 2_000_000_000;
		long ilong = 100000000;
		string text = "Hello World!";
		DateTime dateTime = DateTime.Now;
		bool flag = true;
		double real = 3.14;

		//Array 
		string[] texts = new string[10];

		// Atribuir valor para o array
		texts[0] = "index0";		

		// Obter valor do array
		string text_index_0 = texts[1];

		//Array 
		string[] texts2 = new string[3] { "10","100","1000" };

		// laço repetição clássico
		for (i = 0; i < texts2.Length; i++)
		{
			Console.WriteLine(texts2[i]);
		}	

		// laço de repetição implícito
		foreach (string txt in texts2)
		{
			Console.WriteLine(txt);
		}

		// List 
		List<int> textsLst = new List<int>();

		textsLst.Add(50);
		textsLst.Add(10);

		//LINQ
		textsLst = textsLst
			.OrderBy(x => x)
			.ToList();

		Console.WriteLine("---------------- WHILE ----------------");

		int j = 0;
		while ( j < 10)
		{
			Console.WriteLine(j);
			j++;
		}
	}
}
