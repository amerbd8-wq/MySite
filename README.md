# Amir's Chess Portfolio - ASP.NET Core MVC

A professional chess portfolio website built with ASP.NET Core MVC, showcasing Amir's chess achievements, tournament results, and coaching approach.

## Features

- **Home Page**: Hero section with quick stats and introduction
- **Tournament Results**: Display of competitive achievements
- **Training Approach**: Overview of chess training methodology
- **Contact Page**: Contact form for booking sessions or inquiries
- **Responsive Design**: Works seamlessly on desktop, tablet, and mobile
- **Modern Styling**: Premium dark theme with gold accents

## Project Structure

```
MySite/
├── Controllers/
│   └── HomeController.cs          # Main controller with actions
├── Models/
│   ├── Portfolio.cs              # Portfolio data model
│   ├── TournamentResult.cs       # Tournament result model
│   └── TrainingApproach.cs       # Training approach model
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml          # Home page view
│   │   ├── Results.cshtml        # Tournament results view
│   │   ├── Approach.cshtml       # Training approach view
│   │   ├── Contact.cshtml        # Contact page view
│   │   └── Error.cshtml          # Error page view
│   └── Shared/
│       ├── _Layout.cshtml        # Master layout
│       └── _ViewImports.cshtml   # View imports
├── wwwroot/
│   ├── css/
│   │   └── styles.css            # Main stylesheet
│   └── js/
│       └── script.js             # Client-side scripts
├── Program.cs                     # Application startup
├── MySite.csproj                 # Project file
└── README.md                      # Documentation
```

## Getting Started

### Prerequisites
- .NET 6.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/amerbd8-wq/MySite.git
   cd MySite
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   - Navigate to `https://localhost:7000` (or the port shown in console)

## Usage

### Adding New Tournament Results

Edit `Controllers/HomeController.cs` in the `Results()` action and add new `TournamentResult` objects to the list.

### Customizing Content

- **Portfolio Info**: Modify `Models/Portfolio.cs`
- **Styles**: Edit `wwwroot/css/styles.css`
- **Navigation**: Update `Views/Shared/_Layout.cshtml`

## Routing

- `/` or `/Home/Index` - Home page
- `/Home/Results` - Tournament results
- `/Home/Approach` - Training approach
- `/Home/Contact` - Contact page

## Technologies Used

- **Framework**: ASP.NET Core 6.0 MVC
- **Language**: C#
- **Frontend**: HTML5, CSS3, JavaScript
- **Styling**: Custom CSS with responsive design
- **Fonts**: Google Fonts (Cinzel, Inter)

## Deployment

To deploy to a production server:

```bash
dotnet publish -c Release
```

Upload the contents of the `bin/Release/net6.0/publish` folder to your hosting provider.

## License

This project is open source and available under the MIT License.

## Author

Amir - Master Chess Player & Coach

For more information, visit the website or contact via email.
