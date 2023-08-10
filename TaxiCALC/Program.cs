using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TaxiCALC.Data;


TaxiData almVogn = new TaxiData(); //slow method but can be in any order.
almVogn.vognNavn = vognType.Almindelig;
almVogn.startPris = 37;
almVogn.Kilometerpris = 12.75;
almVogn.minutPris = 5.75;



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
