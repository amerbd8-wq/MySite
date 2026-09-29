using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var portfolio = new Portfolio();
        return View(portfolio);
    }

    public IActionResult Results()
    {
        var results = new List<TournamentResult>
        {
            new TournamentResult
            {
                Id = 1,
                Year = 2024,
                Title = "Regional Championship",
                Description = "Finished among the top 3 competitors in a strong field of national-caliber players.",
                IsFeatured = true
            },
            new TournamentResult
            {
                Id = 2,
                Year = 2023,
                Title = "City Open",
                Description = "Recorded 7 wins and 2 draws across the tournament, securing a podium finish.",
                IsFeatured = false
            },
            new TournamentResult
            {
                Id = 3,
                Year = 2022,
                Title = "Fast Chess Masters",
                Description = "Reached the semifinal round in a rapid-play event with a high-rating field.",
                IsFeatured = false
            },
            new TournamentResult
            {
                Id = 4,
                Year = 2021,
                Title = "Club League",
                Description = "Won the top board title with a dominant score and exceptional endgame conversion.",
                IsFeatured = false
            }
        };

        return View(results);
    }

    public IActionResult Approach()
    {
        var approaches = new List<TrainingApproach>
        {
            new TrainingApproach
            {
                Id = 1,
                Icon = "♟️",
                Title = "Opening Preparation",
                Description = "Deep, practical preparation built around understanding structures, plans, and critical ideas."
            },
            new TrainingApproach
            {
                Id = 2,
                Icon = "🧠",
                Title = "Calculation & Tactics",
                Description = "Sharp tactical vision and realistic calculation routines that improve accuracy under pressure."
            },
            new TrainingApproach
            {
                Id = 3,
                Icon = "📈",
                Title = "Endgame Mastery",
                Description = "Strong endgame technique and conversion discipline from practical tournament experience."
            }
        };

        return View(approaches);
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class ErrorViewModel
{
    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
