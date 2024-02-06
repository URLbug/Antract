## ПО Антракт
### Для документооборота(внешнего) ликерного завода

### Цель:
Создать ПО чем-то похожий на "1С", но только лучше.

### Задача:
1. Улучшить производительность;
2. Улучшить качество обновлений;
3. Сделать ПО бесплатным и open source.
4. Доработать и улучшить все минусы и плюсы 1С.

### Фреймвор и стек разработки
1. C#
2. Windows Form
3. Npgsql

### Архитектура проекта
```
D:.
│   .gitignore
│   App.csproj
│   App.csproj.user
│   LICENSE.md
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
├───components
│       Config.cs
│       DB.cs
```

