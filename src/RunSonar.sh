set -e
cat << eof

Updating Sonnar

eof

PROJECT_KEY="FastSharper"
SONAR_SCANNER_LOCATION="sonarscanner"
OPENCOVER_LOCATION="FastSharper.Tests\coverage.opencover.xml"
TOKEN="de773e5d0e2808a211aab1c85c6a2327362b3850"
COVERAGE_EXCLUSIONS="Tests/**/*.cs"


dotnet test //p:CollectCoverage=true //p:CoverletOutputFormat=opencover
dotnet build-server shutdown
dotnet sonarscanner begin //k:$PROJECT_KEY //d:sonar.login=$TOKEN //d:sonar.cs.opencover.reportsPaths=$OPENCOVER_LOCATION /d:sonar.coverage.exclusions=$COVERAGE_EXCLUSIONS
dotnet build
dotnet sonarscanner end //d:sonar.login=$TOKEN

cat << eof

Sonar update succeeded

eof
