using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private internDBEntities db = new internDBEntities();
        public void GetAllApplicants()
        {
            var applicants = db.mockDatas.ToList();
            foreach (var applicant in applicants)
            {
                Console.WriteLine(applicant);
            }
        }
        public void GetApplicantByID(string ID)
        {

        }
        public void CreateApplicant() { return; }
        public void EditApplicant() { return; }
        public void DeleteApplicant(string ID) {
            return;
        }
    }
}

