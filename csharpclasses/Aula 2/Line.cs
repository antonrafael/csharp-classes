namespace csharpclasses.Aula_2
{
	internal class Line : Geometry, IGeometry
	{
		PointXYZ StartPoint {  get; set; }
		PointXYZ EndPoint { get; set; }
		public string Name { get ; set; }

		public Line(PointXYZ startPoint, PointXYZ endPoint)
		{
			StartPoint = startPoint;
			EndPoint = endPoint;
		}

		public double GetLenght()
		{
			return StartPoint.GetDistance(EndPoint);
		}

		public string GetName()
		{
			throw new NotImplementedException();
		}
	}
}
