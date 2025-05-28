# 📘 GuidesFromScratch

A modular, educational Blazor WebAssembly app for creating and browsing interactive, local-first guides — with built-in support for versioning, component reuse, and client-side persistence.

> 🔗 **Live Demo**: https://faktis.github.io/GuidesFromScratch/

---

## ✨ Features

- ✅ **Blazor WebAssembly (WASM)** — Fully static, C# in the browser
- 💾 **Blazored.LocalStorage** — Persistent data storage in the browser
- 🧩 **Component-based design** — Reusable editors, viewers, and layouts
- 🚀 **CI/CD with GitHub Actions** — Auto-deploys to GitHub Pages on push
- 🛠️ **Offline-ready** — Runs entirely client-side, no backend needed
- 🔐 **Main branch protection** (recommended)

---

## 📂 Project Structure

GuidesFromScratch/
│
├── wwwroot/                 # Static files (index.html, favicon, etc.)
├── Pages/                  # Tutorial walkthroughs (Chapter1, Chapter2, ...)
├── Components/             # Reusable UI components (TextBlockEditor, ...)
├── Models/                 # Core data structures (Chapter, TextBlock)
├── Services/               # Data access & logic (localStorage service)
├── .github/workflows/      # GitHub Actions for deployment
└── Program.cs              # App entry and DI setup

---

## 🚀 Getting Started

### Prerequisites

- .NET 8 SDK (https://dotnet.microsoft.com/en-us/download)
- Git
- (Optional) Visual Studio / VS Code

### Clone the Repo

git clone https://github.com/faktis/GuidesFromScratch.git
cd GuidesFromScratch

---

## 🔨 Development Workflow

### Run the App Locally

dotnet run

Visit: http://localhost:5000

### Publish Locally (for GitHub Pages testing)

dotnet publish -c Release -o release

Then open: release/wwwroot/index.html in a browser.

---

## 📦 Deployment: GitHub Pages

This app is deployed automatically via GitHub Actions.

> 🛠 On every `main` branch push:
> - The app is built using `dotnet publish`
> - Output is deployed to the `gh-pages` branch using `peaceiris/actions-gh-pages`

### Requirements

- The base path in wwwroot/index.html must be:

<base href="/GuidesFromScratch/" />

### GitHub Pages Settings

1. Go to Repository Settings → Pages
2. Select Source: GitHub Actions

---

## 🔐 Branch Protection (Recommended)

To protect your main branch:

1. Go to Settings → Branches
2. Add a rule for `main`
3. Enable:
   - ✅ Require pull request
   - ✅ Include administrators

---

## 📚 Chapter Overview

| Chapter | Focus                            |
|--------:|----------------------------------|
| 1       | Project Setup, GitHub Pages CI/CD |
| 2       | App Architecture & Models        |
| 3       | Component System & Reuse Strategy |
| 4       | Building the TextBlock Editor    |
| 5       | Data Persistence with localStorage |

---

## ✍ Authoring Tutorials

Each guide lives in a `.razor` page:

Pages/ChapterX_Tutorial.razor

Each includes:
- Walkthroughs of code & architecture
- Code blocks and diagrams
- Interactive UI for readers

---

## 🤝 Contributing

Coming soon: Contribution guidelines and roadmap.

---

## 📄 License

MIT License — free to use, modify, and share.

---

## 📬 Contact

Maintained by @faktis (https://github.com/faktis)  
Open an issue to suggest features or fixes:
https://github.com/faktis/GuidesFromScratch/issues
