using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace MyFirstRevitAddin
{
	[Transaction(TransactionMode.Manual)]
	public class FirstCommand : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			TaskDialog.Show("Hello", "Olá Mundo!");

			return Result.Succeeded;
		}
	}
}
