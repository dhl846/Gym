# NeoGym Website Integration in ASP.NET Core 8.0

This project integrates the NeoGym website template, downloaded from [Free CSS](https://www.free-css.com/free-css-templates/page296/neogym), with ASP.NET Core 8.0.

## Project Structure

The project has been organized to separate frontend and backend logic, with ASP.NET Core 8.0 handling the backend API, routing, and any server-side processing, while the NeoGym HTML template manages the frontend UI.

### Folder Structure:
- **/wwwroot** - Contains static assets (CSS, JS, images) from the NeoGym template.
- **/Views** - Contains Razor pages and layout files integrated with the NeoGym HTML template.
- **/Controllers** - Contains ASP.NET Core MVC controllers.
- **/Models** - Contains data models used in the application.

## Getting Started

### Prerequisites
- [.NET Core 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or any IDE that supports .NET Core development

### Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
