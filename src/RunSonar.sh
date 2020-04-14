set -e
cat << eof

+---------------------------+
| Sonarqube update started  |
+---------------------------+

eof

COLLECT_COVERAGE="true"
COVERLET_OUTPUT_FORMAT="opencover"
SONAR_SCANNER_LOCATION="sonarscanner"

PROJECT_KEY="FastSharper"
TOKEN="de773e5d0e2808a211aab1c85c6a2327362b3850"
OPENCOVER_LOCATION="FastSharper.Tests\coverage.opencover.xml"
COVERAGE_EXCLUSIONS="Tests/**/*.cs"


dotnet test \
    //p:CollectCoverage=$COLLECT_COVERAGE \
    //p:CoverletOutputFormat=$COVERLET_OUTPUT_FORMAT
dotnet build-server shutdown
dotnet sonarscanner begin \
    //k:$PROJECT_KEY \
    //d:sonar.login=$TOKEN \
    //d:sonar.cs.opencover.reportsPaths=$OPENCOVER_LOCATION \
    /d:sonar.coverage.exclusions=$COVERAGE_EXCLUSIONS
dotnet build
dotnet sonarscanner end \
    //d:sonar.login=$TOKEN

cat << eof

+----------------------------+
| Sonarqube update succeeded |
+----------------------------+

eof
