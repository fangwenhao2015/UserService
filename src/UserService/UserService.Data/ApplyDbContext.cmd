set day=%random%
dotnet ef migrations add  %day% -s ../UserService.Protal
dotnet ef database update %day% -s ../UserService.Protal