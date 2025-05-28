namespace GuidesFromScratch.Models;

public class Chapter
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public List<TextBlock> Blocks { get; set; } = new();
}
