namespace MySite.Models;

public class TournamentResult
{
    public int Id { get; set; }
    public int Year { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsFeatured { get; set; }
}
