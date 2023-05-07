using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Trainie;
using Trainie.Models;

namespace MyAPI
{
    public class MyClient
    {
        static void Main()
        {
            /*
            MyClient myclient = new MyClient("https://bank.gov.ua");
            var Result = myclient.GetAsync("NBU_Exchange/exchange?json").Result;
            var transactions = JsonConvert.DeserializeObject<Transaction[]>(Result);// почитать Deserialize в C# 
            // почитать про $ 
            Console.WriteLine(Result);
            // Вывести в Консоль для всех элементов transaction курс 
            foreach(var transaction in transactions)
            {
                Console.WriteLine($"{transaction.CurrencyCodeL}:{transaction.Amount}");
            }
            */
            var client = new NBUClient();
            var objectData = client.GetNbuObjectData();
            var typedData = client.GetNbuTypedData();

            var transactions = ((Transaction[])objectData[0]);
            foreach(var t in transactions)
            {
               //t.Print();
                Console.WriteLine(t.Amount);
            }

            // ToDo:
            // print to console all objectData fields & typedData fields
            for( int i = 0; i < typedData.Bonds.Length; i++) 
            {
                Console.WriteLine(typedData.Bonds[i].AuctionDate + " " + typedData.Bonds[i].Amount);
            }



            Console.WriteLine("==========");
            //var kurs = client.GetTransactions();
            //var bond = client.GetBondvalue();
            //var reserve = client.GetReserveData();
            var broadmoney = client.GetLokalBondData();
            //var policyrate = client.GetNBURatesData(); 

        }
    }
}