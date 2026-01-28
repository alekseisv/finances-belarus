var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Автоматически открываем index.html
app.UseDefaultFiles();

// Разрешаем доступ к статическим файлам
app.UseStaticFiles();

// Запускаем приложение
app.Run();
