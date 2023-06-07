# API to manage linky indicator data

## Technolohies used

- .net core 6
- asp.net
- ef core 7.0.5

## Migration default configuration

This API use by default the SQL Server. It's possible and easily editable to change this.
- The only code to change is the following :

`builder.Services.AddDbContext<LinkyContext>((sp, x) =>
    x.UseSqlServer(sp.GetRequiredService<IConfiguration>().GetConnectionString("DefaultConnection")));`
- And download the adapted library in the Linky.API project, i.e : Microsoft.EntityFrameworkCore.SqlServer

## Deployment

This solution use migartions, to run it you have to use entity framework core commands.
Execute the following commands into package manager console (take care of the default project used, it have to be Linky.API) : `Update-Database`
