namespace GuidesFromScratch.Domain;

public class TextBlock
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? LinkUrl { get; set; }
}