using WebApplicationUnitTestNetCore.Service;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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



app.MapGet("/GetEmployee", () =>
{
    var obj = new EmployeeService();
    return obj.GetEmployeeList();
})
.WithName("GetEmployee")
.WithOpenApi();

app.MapGet("/GetTestCon", () =>
{
    var obj = new EmployeeService();
    return obj.GetTestCon();
})
.WithName("GetTestCon")
.WithOpenApi();



app.Run();

public class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class responseTest
{
    public string item { get; set; }
}