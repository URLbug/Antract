## ПО Антракт
### Для документооборота(внешнего) ликерного завода

### Цель:
Создать ПО чем-то похожий на "1С", но только лучше.

### Задача:
1. Улучшить производительность;
2. Улучшить качество обновлений;
3. Сделать ПО бесплатным и open source.
4. Доработать и улучшить все минусы и плюсы 1С.

### Архитектура проекта
```
D:.
│   .gitignore
│   App.csproj
│   App.csproj.user
│   LoginForm.cs
│   LoginForm.Designer.cs
│   LoginForm.resx
│   MainForm.cs
│   MainForm.Designer.cs
│   MainForm.resx
│   Program.cs
│   README.md
│
├───admins
│       AdminForm.cs
│       AdminForm.Designer.cs
│       AdminForm.resx
│       RegistForm.cs
│       RegistForm.Designer.cs
│       RegistForm.resx
│
├───bin
│   └───Debug
│       └───net8.0-windows
│               App.deps.json
│               App.dll
│               App.exe
│               App.pdb
│               App.runtimeconfig.json
│               Microsoft.Extensions.DependencyInjection.Abstractions.dll
│               Microsoft.Extensions.Logging.Abstractions.dll
│               Npgsql.dll
│
├───components
│       Config.cs
│       DB.cs
│
└───obj
    │   App.csproj.nuget.dgspec.json
    │   App.csproj.nuget.g.props
    │   App.csproj.nuget.g.targets
    │   project.assets.json
    │   project.nuget.cache
    │
    └───Debug
        └───net8.0-windows
            │   .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
            │   App.AdminForm.resources
            │   App.admins.RegistForm.resources
            │   App.AssemblyInfo.cs
            │   App.AssemblyInfoInputs.cache
            │   App.assets.cache
            │   App.csproj.AssemblyReference.cache
            │   App.csproj.BuildWithSkipAnalyzers
            │   App.csproj.CopyComplete
            │   App.csproj.CoreCompileInputs.cache
            │   App.csproj.FileListAbsolute.txt
            │   App.csproj.GenerateResource.cache
            │   App.designer.deps.json
            │   App.designer.runtimeconfig.json
            │   App.dll
            │   App.GeneratedMSBuildEditorConfig.editorconfig
            │   App.genruntimeconfig.cache
            │   App.GlobalUsings.g.cs
            │   App.LoginForm.resources
            │   App.MainForm.resources
            │   App.pdb
            │   apphost.exe
            │
            ├───ref
            │       App.dll
            │
            └───refint
                    App.dll
```

### Фреймвор и стек разработки
1. C#
2. Windows Form