
## agregar librerias
dotnet add package EntityFramework --version 6.2.0 (es el opensource , no la usamos)

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.9

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.7

dotnet new mvc --auth Individual

apuntar a a DB Postgres -- appsettings.json

.csproj ..... LIBRERIAS IMPORTANTES
    <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="5.0.10" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="5.0.10" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="5.0.10" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="5.0.10" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.10" />
    <PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="5.0.10" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.9" />


dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

dotnet aspnet-codegenerator identity -dc PruebaMVCLogin.Data.ApplicationDbContext --files "Account.Register;Account.Login"

dotnet tool update --global dotnet-ef --version 5.0.10
