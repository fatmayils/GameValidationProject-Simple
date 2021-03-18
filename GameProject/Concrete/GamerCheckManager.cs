using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.NationalityId==2345&&gamer.BirthDate.Year==2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}