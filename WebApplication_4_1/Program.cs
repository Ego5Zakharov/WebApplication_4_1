var builder = WebApplication.CreateBuilder(args);




//Создать собственный контроллер для работы с Валютой
//создать endpoint для получения всех отношений разных валют
//к тенге (минимум 5 валют)
//конвертировать сумму отправленную в тенге по отношению к валютам
//по отдельности на каждую валюту
//Отправлять на сервер модельку персону с личной информацией (например
//Имя, Фамилия, Баланс) и отправлять ответом полную информации  о нем  

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
