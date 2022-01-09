using CarteiraControlerWebApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraControlerWebApplication.Services
{
    interface IBscScanService
    {
        public Task<TransacoesDTO> GetApi(string wallateAddress, string contractaddress);

    }
}
