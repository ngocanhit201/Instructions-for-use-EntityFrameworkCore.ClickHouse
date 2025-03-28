package
```
dotnet add package ClickHouse.Client --version 7.13.0
dotnet add package EntityFrameworkCore.ClickHouse --version 1.0.2
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.3
dotnet add package Microsoft.EntityFrameworkCore.Abstractions --version 9.0.3
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.3
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 9.0.3
dotnet add package Newtonsoft.Json --version 13.0.3
dotnet add package Spectre.Console.Cli --version 0.49.1

```
scaffold
```
dotnet ef dbcontext scaffold "Host=127.0.0.1;Port=8123;Username=default;Password=;Database=db2;Compress=True;CheckCompressedHash=False;SocketTimeout=60000000;Compressor=lz4" EntityFrameworkCore.ClickHouse -o Models -c MyDbContext
```

Step by step:
```
1. New project .net 9
2. Add package (above)
3. Scaffold
4. Add DB context in program.cs
5. Copy my GodMethods.cs
6. Use it
=> I will explain in my video
```