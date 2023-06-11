dotnet tool install --global dotnet-coverage
dotnet tool install --global dotnet-reportgenerator-globaltool

dotnet coverage collect dotnet test --output ".\CoverageResults\coverage.cobertura.xml" --output-format cobertura
reportgenerator "-reports:.\CoverageResults\coverage.cobertura.xml" "-targetdir:.\CoverageResults\html" -reporttypes:HTML;