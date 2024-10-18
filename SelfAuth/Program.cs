// See https://aka.ms/new-console-template for more information
using Microsoft.Identity.Client;

Console.WriteLine("Hello, World!");

string clientId = "bbd5737a-1040-477a-81b8-8f7f0711a208";

var app = PublicClientApplicationBuilder.Create(clientId)
    .WithRedirectUri("http://localhost")
    .Build();

var scopes = new string[]
{
    "https://graph.microsoft.com/User.Read.All"
};
var result = await app.AcquireTokenInteractive(scopes)
    .ExecuteAsync();

Console.WriteLine(result.AccessToken);


Console.ReadLine();