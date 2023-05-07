using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://yahoo-finance127.p.rapidapi.com/price/eth-usd"),
    Headers =
    {
        { "X-RapidAPI-Key", "1295a1bbb0msha312fe4d6b8a03fp1eddadjsnb7fe37663eff" },
        { "X-RapidAPI-Host", "yahoo-finance127.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}