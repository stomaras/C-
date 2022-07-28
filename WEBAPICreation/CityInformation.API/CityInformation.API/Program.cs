var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();//takes care for specificatgion order matters
    app.UseSwaggerUI();// takes care about specification and take cares a nice ui for me
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// add end points for controllers  without specifying routes
// specifying that routes is what we do with attributes
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });




app.Run();
