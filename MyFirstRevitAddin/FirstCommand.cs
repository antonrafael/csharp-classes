using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Reflection.Emit;

namespace MyFirstRevitAddin
{
	[Transaction(TransactionMode.Manual)]
	public class FirstCommand : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			try
			{
				UIDocument uidoc = commandData.Application.ActiveUIDocument;
				Document doc = uidoc.Document;

				Reference refObj = uidoc.Selection.PickObject(ObjectType.Element,"Selecione um elemento");

				ElementId id = refObj.ElementId;

				Element element = uidoc.Document.GetElement(id);

				Wall wall = element as Wall;

				if (wall == null)
				{
					TaskDialog.Show("NewPlugin","Você precisa selecionar uma parede");
					return Result.Failed;
				}

				TaskDialog.Show("NewPlugin", wall.Name);

				using Transaction t = new Transaction(doc, "Movimentar parede Passo 1");
				t.Start();

				XYZ xyz = new XYZ(3, 3, 3);
				ElementTransformUtils.MoveElement(doc, wall.Id, xyz);

				t.Commit();				

				List<Wall> walls = new FilteredElementCollector(doc)
					.OfClass(typeof(Wall))
					.WhereElementIsNotElementType()
					.Cast<Wall>()
					//.Where(w => w.Len )
					.ToList();

				using Transaction t2 = new Transaction(doc, "Movimentar parede Passo 2");
				t2.Start();

				foreach (Wall w in walls)
				{
					ElementTransformUtils.MoveElement(doc, w.Id, xyz);
				}

				t2.Commit();				

				return Result.Succeeded;
			}
			catch(Exception ex)
			{
				TaskDialog.Show("NewPlugin", ex.Message);
				return Result.Failed;
			}
		}
	}
}
