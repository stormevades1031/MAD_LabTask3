# MAD Lab Task 3 – MauiApp2 (.NET MAUI)

A cross-platform .NET MAUI app targeting Android, iOS, macOS, and Windows. It demonstrates a pet profile UI, grid layouts, buttons, and basic interactivity.

## Features
- Profile card for Ashley (breed, age, location)
- Friend section (Blue the Husky) with circular image and date
- Heart toggle button that switches color between light gray and red
- Adoption call-to-action button

## Project Tech
- .NET 9.0 MAUI single-project; assets under `Resources`
- XAML UI in `MainPage.xaml` and code-behind in `MainPage.xaml.cs`
- App bootstrapping in `MauiProgram.cs` and `AppShell.xaml`

## Prerequisites
- .NET SDK 9.0
- Visual Studio 2022 with ".NET Multi-platform App UI development" workload
- Android SDK/emulator for Android; Xcode for iOS/macOS

## Run
- Visual Studio: open `MauiApp2.sln`, choose target platform, press Run
- CLI (Windows):
  - `dotnet build MauiApp2/MauiApp2.csproj`
  - `dotnet run -f net9.0-windows10.0.19041.0 --project MauiApp2/MauiApp2.csproj`

## Structure
- `Resources/Images`: app images (`cat.jpg`, `husky.jpg`, icons)
- `Resources/Fonts`: OpenSans fonts
- `App.xaml`, `AppShell.xaml`: app shell and styles

## Repository
- GitHub: https://github.com/stormevades1031/MAD_LabTask4
