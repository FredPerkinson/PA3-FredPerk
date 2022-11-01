using System;
using PA3-Fredp.database; 
using PA3_Fredp.models;

namespace PA3_Fredp
{
    class Program
    {
        System.Console.WriteLine("Hello");
        DeleteDriver.DropDriverTable();
        SaveDriver.CreateDriverTable();

        Driver myDriver = new Driver(){Title = "Mistborn", Author = "ABC"};
        myDriver.Save.CreateDriver(myDriver);
    }
}



















// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();
