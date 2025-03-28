package
```

```
scaffold
```
dotnet ef dbcontext scaffold "Host=127.0.0.1;Port=8123;User=default;Password=;Database=db2;Compress=True;CheckCompressedHash=False;SocketTimeout=60000000;Compressor=lz4" EntityFrameworkCore.ClickHouse -o Models -c MyDbContext
```