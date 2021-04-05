# Identity Server 4 - In Memory Example

### IDS Steps
| Type | Description |
|---|---|
| (CLI) | mkdir Identity						-> cd Identity |
| (CLI) | dotnet new sln -n Identity |
| (CLI) | mkdir ids								-> cd ids |
| (CLI) | dotnet new web						-> cd.. |
| (CLI) | dotnet sln add ./ids/ids.csproj		-> cd ids |
| (CLI) | dotnet add package IdentityServer4 |
| (CODING) | Add Identity Server to Startup.cs |
| (CLI) | dotnet run |
| (BROWSER) | open http://localhost:5000 |
| (BROWSER) | navigate to http://localhost:5000/.well-known/openid-configuration |
| (CODING) | Add UI -> https://github.com/IdentityServer/IdentityServer4.Quickstart.UI |



### Client API Steps
| Type | Description |
|---|---|
| (CLI) | cd.. |
| (CLI) | mkdir client 	-> cd client |
| (CLI) | mkdir weatherapi 	-> cd weatherapi |
| (CLI) | dotnet new api |
| (CLI) | cd..	->	cd..	->	dotnet sln add ./client/weatherapi/weatherapi.csproj	->	cd client/weatherapi |
| (CODING) | Update port in launchsettings.cs |
| (BROWSER) | navigate to http://localhost:5444/weatherforecast |
| (CLI) | dotnet add package IdentityServer4.AccessTokenValidation |
| (CLI) | dotnet add package Microsoft.AspNetCore.Authorization |
| (CODING) | Update Startup.cs to use IdentityServerAuthentication |
| (CODING) | Update Controller to use Authorize attribute |


### Client Web Steps
| Type | Description |
|---|---|
| (CLI) | cd.. |
| (CLI) | mkdir weathermvc 	-> cd weathermvc |
| (CLI) | dotnet new mvc |
| (CLI) | cd..	->	cd..	->	dotnet sln add ./client/weathermvc/weathermvc.csproj	->	cd client/weathermvc |
| (CLI) | dotnet add package IdentityModel |
| (CLI) | dotnet add package Microsoft.AspNetCore.Authentication.OpenIdConnect |
| (CLI) | dotnet add package Microsoft.AspNetCore.Authorization |
| (CODING) | Update Startup.cs to use Cookie & oidc Authentication |
| (CODING) | Add Endpoint + functionality to Home Controller |


### cURL Command Examples
#### Get Token
curl -X POST "Content-Type: application/x-www-form-url-urlencoded" -H "Cache-Control: no-cache" -d "client_id=m2m.client&scope=weatherapi.read&client_secret=SuperSecretPassword&grant_type=client_credentials" "http://localhost:5000/connect/token"

curl --insecure -X POST "Content-Type: application/x-www-form-url-urlencoded" -H "Cache-Control: no-cache" -d "client_id=m2m.client&scope=weatherapi.read&client_secret=SuperSecretPassword&grant_type=client_credentials" "https://localhost:5443/connect/token"


### Authorize
curl --insecure -X GET -H "Authorization: Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IkE1NENDNEQ3OTRDRURDRDAwN0MzNUJCQTEyREFFQTlBIiwidHlwIjoiYXQrand0In0.eyJuYmYiOjE2MTc1Mzg1ODYsImV4cCI6MTYxNzU0MjE4NiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MDAwIiwiYXVkIjoid2VhdGhlcmFwaSIsImNsaWVudF9pZCI6Im0ybS5jbGllbnQiLCJqdGkiOiI0RDg4RUZGNkY3MDY4MzRGNzE4MUY1QUVGQjI0RkNFNyIsImlhdCI6MTYxNzUzODU4Niwic2NvcGUiOlsid2VhdGhlcmFwaS5yZWFkIl19.W7UZAbZfS8FPhpoe59vSqavW1SDl3yyedm0GCMAdS4AD1ALVnNuyBFHTcUqxkrbtnlrCG-AYBerAKD8QIzFJU679DYjL20DODWnAEet-Qvgyo2wFvb7TaVdYV48ki--GS11ySsN8Ii_8TjDYpY0LRyBjxObh7wDoMAZRQcgRmsZg4Y4IVAvOLUwo5amWHAN1TCDbuXql6_AH5BO_WKmoFMrdOLO9nmtxSnVuWctjpZOzFMhjwz8oLgv7v5vPI4zZSUAiKcJZtsZZkq8ZnAYyuaxuCFq_gfhFIA0yW1N7-YZjzT5m-wGv1YgpMA-qUIrC4X5GqA9_ncPsgv6aBS6m0w" -H "Cache-Control: no-cache" "http://localhost:5002/weatherforecast"


### Credits
https://www.youtube.com/watch?v=HJQ2-sJURvA&t=679s&ab_channel=IdentityServer
