* Install .NET 5.0
* Install docker
* MAC ONLY: Install Powershell (https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos?view=powershell-7.1)
    * Install Brew (if not installed) \
<code>/bin/bash -c "$(curl -fsSL [https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh](https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh))"</code>
    * <code>brew install powershell</code>
    * <code>pwsh</code>
* Environment Setup Tasks. In CMD/Powershell/Terminal run the following
    * <code>dotnet new -i EPiServer.Net.Templates --nuget-source https://nuget.optimizely.com/feed/packages.svc/ --force</code>
    * <code>dotnet tool install EPiServer.Net.Cli --global --add-source [https://nuget.optimizely.com/feed/packages.svc/](https://nuget.optimizely.com/feed/packages.svc/)</code>
    * <code>dotnet nuget add source [http://nuget.episerver.com/feed/packages.svc](http://nuget.episerver.com/feed/packages.svc) -n Optimizely</code>
    * Run <code>dotnet dev-certs https --trust</code>
* Setup a DB server on Docker (if you're not already running one)
    * Grab the docker compose file from [https://bit.ly/docker-compose-dbs](https://bit.ly/docker-compose-dbs) 
    * In CMD/Powershell/Terminal run <code>docker compose up</code>
* From the src/Training.B.Web folder
    * <code>dotnet-episerver create-cms-database Training.B.Web.csproj -S localhost -U sa -P epiR0cks</code> - Note, if you're already running Docker SQL, use your own username and password
    * <code>dotnet-episerver add-admin-user Training.B.Web.csproj -u dept -p P4ssw0rd! -e user@email.com -c EPiServerDB</code>
    * <code>dotnet build</code>
    * <code>dotnet run</code>
