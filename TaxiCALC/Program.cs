using TaxiCALC.Data;
//all types of taxi data is loaded first
TaxiData almVogn = new TaxiData(vognType.Almindelig, 37, 12.75m, 5.75m ); 

TaxiData aftenVogn = new TaxiData(vognType.AlmindeligAften, 47m, 16m, 7m); //constructor method

TaxiData storVogn = new TaxiData(vognType.Stor, 77m, 17m, 5.75m);

TaxiData storSpecial = new TaxiData(vognType.StorSpecial, 87m, 19m, 7m);

//TaxiData.km and TaxiData.Minutes should be userdefined as it is undefined decimal fields



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

