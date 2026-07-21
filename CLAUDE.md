# boxfusion.test

## Project Overview

A Shesha-based application (ASP.NET Boilerplate backend + Next.js admin portal frontend).

- **Backend:** `backend/` — solution `backend/boxfusion.test.sln`, Web.Host at `backend/src/boxfusion.test.Web.Host` (listens on `http://localhost:21021`).
- **Frontend:** `adminportal/` — Shesha admin portal (dev server on port 3000).
- **Database:** SQL Server, catalog `test` (a `test.bacpac` backup is included for restore).

## Build & Run Commands

```bash
# Backend
dotnet build backend/boxfusion.test.sln
ASPNETCORE_URLS=http://localhost:21021 dotnet run --project backend/src/boxfusion.test.Web.Host

# Frontend
cd adminportal && npm install && npm run dev
```

## Architecture

Standard Shesha layering — Domain, Application, EntityFrameworkCore, Web.Host. API controllers are auto-generated from application services. Prefer the Shesha developer skills (below) over manual scaffolding.

## Key Conventions

### Back-end Naming Conventions

- Two-letter acronyms should be ALL CAPS (e.g. `IO`, `DB`).
- Acronyms of three or more letters should only have the first letter capitalized (e.g. `Sla`, `Xml`, `Http`).

### Dev Credentials

- Test username and passwords for the backend can be found in `.sheshadev.local.json` in the project root. This file is excluded from version control.

## Skill Usage Rules

- **Before implementing backend application services, DTOs, AutoMapper profiles, or the application layer**, always invoke the `shesha-developer:shesha-app-layer` skill first. It contains Shesha-specific patterns, base classes, and templates that must be followed.
- **Before creating or modifying domain entities, reference lists, or migrations**, always invoke the `shesha-developer:domain-model` skill first.
- **Before creating or modifying workflow artifacts**, always invoke the `shesha-developer:shesha-workflow` skill first.
- These skills must be invoked BEFORE any manual exploration or planning for the relevant task.
