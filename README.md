# An Api client written in C# using ASP.NET.

To run install dotnet-core.

Delete `.env` in "appsetting" files,

Then change the secret in appsetting.json:

```
"Secret": "PUT YOUR OWN STRING HERE!!!"
```

And the SqlServer adress when production:

```
"WebApiDatabase": "ENTER PRODUCTION SQL SERVER CONNECTION STRING HERE"
```

If migrations is not set, install ef tools and run:

```
dotnet ef migrations add InitialCreate --context SqliteDataContext --output-dir Migrations/SqliteMigrations
```
