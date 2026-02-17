* TaskManager API REST

API RESTful desarrollada con .NET Core para gestión de tareas, implementando autenticación JWT y sistema de roles de usuario.

 ** Características del proyecto:

- Arquitectura en capas (Modelo, Servicio, Acceso a datos)
- Arquitectura Code First con Entity Framework Core
- Migraciones de base de datos automáticas
- Validaciones de entrada basicas
- Autenticación y autorización con JWT (Proximamente)
- Sistema de roles de usuario (Proximamente)

** Tecnologias utilizadas:

- ASP.NET Core 8 
- Entity Framework Core
- SQL Server
- C#

** Requisitos para instalacion:

- .NET SDK 6.0 o superior
- SQL Server
- Visual Studio o VS code

** Como instalarlo:

1. Clonar el repositorio
```bash
git clone https://github.com/DanielAmador18/ServicioNetCore.git
cd ServicioNetCore
```

2. Configura la cadena de conexión en `appsettings.example.json`
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Tu cadena de conexión"
  }
}

```

3. Ejecuta las migraciones
```bash
dotnet ef database update
```

4. Ejecuta el proyecto
```bash
dotnet run
```
