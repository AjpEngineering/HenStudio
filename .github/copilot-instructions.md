# Copilot Instructions

## Project Guidelines
- For HEN Studio optimizer modeling, keep `HenOptimizer` as the parent table and use separate child subtype tables for `Genetic`, `Greedy`, and `MILP` optimizer-specific settings.
- For `_HenRepositories`, use the Project repository interface files as the template for future repository interfaces, including the same header/region style and DTO-plus-interface structure. Use `Repo` instead of `Repository` in interface names and filenames, e.g. `IProjectRepo` rather than `IProjectRepository`.
- For concrete repository implementations in `_HenPersistence`, name the concrete class by removing the leading `I` from the interface name, e.g. `IProjectRepo` -> `ProjectRepo`.