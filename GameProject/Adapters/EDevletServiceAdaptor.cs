using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class EDevletServiceAdaptor:IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthDate.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
