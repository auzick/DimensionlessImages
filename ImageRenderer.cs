namespace DimensionlessImages
{
  using Sitecore.Data.Fields;
  public class ImageRenderer : Sitecore.Xml.Xsl.ImageRenderer
  {
    protected override void AdjustImageSize(ImageField imageField, float imageScale, int imageMaxWidth, int imageMaxHeight, ref int w, ref int h)
    {
      w = 0;
      h = 0;
    }
  }
}