namespace DimensionlessImages.Pipelines.RenderField
{
  using Sitecore.Xml.Xsl;

  public class GetImageFieldValue : Sitecore.Pipelines.RenderField.GetImageFieldValue
  {
    protected override ImageRenderer CreateRenderer()
    {
      return new DimensionlessImages.ImageRenderer();
    } 

  }
}