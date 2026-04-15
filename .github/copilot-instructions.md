# Copilot Instructions

## Project Guidelines
- For HEN Studio optimizer modeling, keep `HenOptimizer` as the parent table and use separate child subtype tables for `Genetic`, `Greedy`, and `MILP` optimizer-specific settings.
- For `_HenRepositories`, use the Project repository interface files as the template for future repository interfaces, including the same header/region style and DTO-plus-interface structure. Use `Repo` instead of `Repository` in interface names and filenames, e.g. `IProjectRepo` rather than `IProjectRepository`.
- For concrete repository implementations in `_HenPersistence`, name the concrete class by removing the leading `I` from the interface name, e.g. `IProjectRepo` -> `ProjectRepo`.
- When creating or restoring database SQL files, use the actual repository path with a leading underscore: `_HenStudioDatabase\Tables\...` rather than `HenStudioDatabase`. Ensure files are written to `C:\_AJP\git\Pinch\_HenStudioDatabase\Tables\...`.

## Code Style
- For each method, add a triple-slash XML comment above the method and enclose the method in a #region block named after the method, following the `GetGlobalSettings()` style.
- Apply the same style to private methods as public methods: add triple-slash XML comments above each method and wrap each method in a #region block named after the method.
- Use the repository/test file house style consistently: file header banner, #region blocks, XML comments on methods, and matching formatting conventions.