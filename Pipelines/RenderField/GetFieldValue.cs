namespace DimensionlessImages.Pipelines.RenderField
{
  using Sitecore.Pipelines.RenderField;

  public class GetFieldValue : Sitecore.Pipelines.RenderField.GetFieldValue
  {
    public new void Process(RenderFieldArgs args)
    {
      base.Process(args);
      if (args.FieldTypeKey == "rich text")
      {
        Sitecore.Diagnostics.Profiler.StartOperation("Stripping image tags from field: " + args.FieldName);
        args.Result.FirstPart = HtmlUtil.StripDimensions(args.Result.FirstPart);
        Sitecore.Diagnostics.Profiler.EndOperation();
      }
    }

  }
}
