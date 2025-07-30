namespace csharpclasses.Aula_2
{
	internal class Program
	{
		public static void Main()
		{
			// o cast (conversão) ocorre de forma implícita
			Geometry geometry = new PointXYZ(0, 0, 0);

			PointXYZ point = new PointXYZ(0, 0, 0);

			// o cast é explícito
			geometry = point as Geometry;
		}



		private void CreateLineAula2e3()
		{
			PointXYZ point1 = new PointXYZ(2, 2, 2);

			PointXYZ point2 = new PointXYZ(4, 4, 4);

			point1.Id = 1;

			Line line = new Line(point1, point2);

			double distance = line.GetLenght();

			Console.WriteLine($"A distância entre os pontos é de: {distance} .");
		}
	}
}
