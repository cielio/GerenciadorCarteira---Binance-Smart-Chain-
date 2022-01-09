using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraControlerWebApplication.DTOs
{
    public class TransacoesDTO
    {

        public string status { get; set; }
        public string message { get; set; }
        public List<Result> result
        {
            get; set;
        }

        public class Result
        {
            public string BlockNumber { get; set; }
            public string TimeStamp { get; set; }
            public string Hash { get; set; }
            public string Nonce { get; set; }
            public string BlockHash { get; set; }
            public string From { get; set; }
            public string ContractAddress { get; set; }
            public string To { get; set; }
            public decimal Value { get; set; }
            public string TokenName { get; set; }
            public string TokenSymbol { get; set; }
            public string TokenDecimal { get; set; }
            public string TransactionIndex { get; set; }
            public string Gas { get; set; }
            public string GasPrice { get; set; }
            public string GasUsed { get; set; }
            public string CumulativeGasUsed { get; set; }
            public string Input { get; set; }
            public string Confirmations { get; set; }
            public string Type { get; set; }

        }

    }
}
