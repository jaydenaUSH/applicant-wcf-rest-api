using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Service1 : IService1
    {
        //private internDBEntities db = new internDBEntities();
        public string GetAllApplicants()
        {
            var applicants = "AppliANT";

            return applicants;
        }
       /* public mockData GetApplicantByID(string ID)

        {

            return db.mockDatas.FirstOrDefault();
        }
        public void CreateApplicant() { return; }
        public void EditApplicant() { return; }
        public void DeleteApplicant(string ID)
        {
            return;
        }
        public string Test()
        {
            return "working";
        }*/
    }
}
