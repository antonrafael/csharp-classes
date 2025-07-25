namespace csharpclasses.Aula_2
{
	internal class Program
	{
		public static void Main()
		{
			PointXYZ point1 = new PointXYZ(2, 2, 2);

			PointXYZ point2 = new PointXYZ(4, 4, 4);

			double distance = point1.GetDistance(point2);

			Console.WriteLine( $"A distância entre os pontos é de: {distance} ." );

		}
	}
}
