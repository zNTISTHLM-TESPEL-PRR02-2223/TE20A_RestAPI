﻿using RestSharp;
using System.Text.Json;
using System.Net;
RestClient pokeClient = new("https://pokeapi.co/api/v2/");
RestRequest request = new("pokemon/pidgey");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
  Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);
  Console.WriteLine(p.Name);
  Console.WriteLine(p.Weight);
}
else
{
  Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();
