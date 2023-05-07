using MyAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainie.Models;

namespace Trainie
{
    public class NBUClient
    {
        private MyHttpClient myclient = new MyHttpClient("https://bank.gov.ua");
        public NBUClient() 
        { 

        }
        public Object[] GetNbuObjectData()
        {
            var transactions = GetTransactions();
            var bonds = GetBondvalue();
            return new object[] { transactions, bonds };
        }
        public NbuFullData GetNbuTypedData()
        {
            var transactions = GetTransactions();
            var bonds = GetBondvalue();
            return new NbuFullData()
            {
                Transactions = transactions,
                Bonds = bonds
            };
        }

        public Transaction[] GetTransactions()
        {
            var Result = myclient.GetAsync("NBU_Exchange/exchange?json").Result;
            var transactions = JsonConvert.DeserializeObject<Transaction[]>(Result);
            return transactions;
        }
        public Bond[] GetBondvalue()
        {
            var Result = myclient.GetAsync("NBU_ovdp?json").Result;
            var values = JsonConvert.DeserializeObject<Bond[]>(Result);
            return values;
        }
        public Reserve[] GetReserveData()
        {
            var Result = myclient.GetAsync("NBUStatService/v1/statdirectory/res?date=201708&json").Result;
            var values = JsonConvert.DeserializeObject<Reserve[]>(Result);
            return values;
        }
        public LokalBond[] GetLokalBondData()
        {
            var Result = myclient.GetAsync("depo_securities?json").Result;
            var values = JsonConvert.DeserializeObject<LokalBond[]>(Result);
            return values;
        }
        public UONIA[] GetUONIAData()
        {
            var Result = myclient.GetAsync("NBU_uonia?id_api=UONIA_UnsecLoansDepo&json").Result;
            var values = JsonConvert.DeserializeObject< UONIA[]>(Result);
            return values;
        }
        public PolicyRate[] GetNBURatesData()
        {
            var Result = myclient.GetAsync("NBUStatService/v1/statdirectory/key?date=20230430&json").Result;
            var values = JsonConvert.DeserializeObject<PolicyRate[]>(Result);
            return values;
        }
        public ForeigBanks[] GetForeigBanksData()
        {
            var Result = myclient.GetAsync("NBU_BankInfo/foreing_office?json").Result;
            var values = JsonConvert.DeserializeObject<ForeigBanks[]>(Result);
            return values;
        }

        //ToDo: Add 5 more calls
    }
}
