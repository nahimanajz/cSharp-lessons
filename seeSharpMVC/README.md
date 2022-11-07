# mvc.
`Dependency injection` avoiding duplicated code by creating interface so that changes done on interface will reflect to classes overriden that interface methods
# appsettings.json
It is where we keep our `secrets keys`
it is also a container of `appsettings.development.json` and `appsettings.production.json` for housing all environment variables.

# Dotnet pipeline

- Request from browser = __Auth__`->` __MVC__ `->` __Static Files__
`_ViewImports.cshtml` is used to define links of the application by the help of @tagHelper
`_ViewStart.cshtml`.defines the start page of the application
# adding hot reload in vscode
- Open `Properties\launchSettings.json` then add ` "hotReloadProfile": "aspnetcore" ` thereby in terminal execute this command `dotnet watch run --launch-profile projectname` find guidance [here](https://kontext.tech/article/971/net-hot-reload-in-visual-studio-code)
```
"profiles": {
    "seeSharpMVC": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "https://localhost:7233;http://localhost:5042",
      "hotReloadProfile": "aspnetcore",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
 ```
 Package manager is [Nuget]() https://www.nuget.org/packages)
 
