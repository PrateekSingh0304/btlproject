using DataAccess.Abstraction;
using DataAccess.Implementation;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Service.Controllers
{
    public class CenterController : ApiController
    {
        IDataAccess dataAccess;
        public CenterController()
        {
        }
        [HttpGet]
        public List<Center> GetAllCenters()
        {
            // this could be done using unity container by injecting the dependency directly to the constructor of this controller.
            GenericDataAccess data = new GenericDataAccess();
            var CenterList = data.GetAllData();

            return CenterList;
        }
        
    }
}
