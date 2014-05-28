namespace DimensionlessImages
{
  using System;
  using HtmlAgilityPack;

  public class HtmlUtil
  {
    public static string StripDimensions(string text)
    {
      if (string.IsNullOrWhiteSpace(text))
      {
        return text;
      }
      string outText = text;
      try
      {
        var doc = new HtmlDocument();
        doc.LoadHtml(outText);

        StripAttribute(doc, "width");
        StripAttribute(doc, "height");

        outText = doc.DocumentNode.WriteContentTo();
      }
      catch (Exception)
      {}
      return outText;
    }

    private static void StripAttribute(HtmlDocument doc, string attribute)
    {
      // For reasons surpassing all understanding, HtmeAgilityPack returns null instead of an empty collection
      // when the query finds no results.
      HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(String.Format("//img[@{0}]", attribute));
      if (nodes == null || nodes.Count.Equals(0))
      {
        return;
      }
      foreach (HtmlNode node in nodes)
      {
        node.Attributes[attribute].Remove();
      }

    }
  }
}
