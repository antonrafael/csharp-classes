namespace csharpclasses.Aula_2
{
	internal class PointXYZ : Geometry
	{
		public double X { get; private set; } 
		public double Y { get; private set; }
		public double Z { get; private set; }

		public PointXYZ(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public double GetX()
		{
			return X;
		}
		public void SetX(double x)
		{
			if (x > 100)
			{
				x = 100;
			}

			X = x;			
		}
		public void SetY(double y)
		{
			if (y > 100)
			{
				y = 100;
			}

			Y = y;
		}
		public void SetZ(double z)
		{
			if (z > 100)
			{
				z = 100;
			}

			Z = z;
		}

		//d=√((x_2-x_1)²+(y_2-y_1)²+(z_2 - z_1)²
		public double GetDistance(PointXYZ otherPoint)
		{
			double distx = Math.Pow(X - otherPoint.X, 2);
			double disty = Math.Pow(Y - otherPoint.Y, 2);
			double distz = Math.Pow(Z - otherPoint.Z, 2);

			double sum = distx + disty + distz;

			double distance = Math.Sqrt(sum);

			return distance;
		}
	}
}
