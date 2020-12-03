using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RegistrationService;


namespace RegistrationAPI.Controllers
{
    public class RegistrationController : ApiController
    {
        public IEnumerable<MemberDetail2> Get()
        {
            using (RegistrationEntities entities = new RegistrationEntities())
            {
                return entities.MemberDetail2.ToList();
            }
        }
        public MemberDetail2 Get(int id)
        {
            using (RegistrationEntities entities = new RegistrationEntities())
            {
                return entities.MemberDetail2.FirstOrDefault(e=>e.ID==id);
            }
        }
    }
}
