using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;

namespace WebApplication2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Service1 : IService1
    {
        private internDBEntities db = new internDBEntities();
        public List<mockData> GetAllApplicants()
        {

            var applicants = db.mockDatas.ToList();

            return applicants;
        }
        public mockData GetApplicantByID(string ID)

        {
            int applicantId = Convert.ToInt32(ID);

            return db.mockDatas.FirstOrDefault(a=>a.applicant_id== applicantId);
        }
        public void CreateApplicant( mockData applicants) {
            
            db.mockDatas.Add(applicants);
            db.SaveChanges();
                return; }
        public void EditApplicant(string ID, mockData updatedInfo) {
            // Find the user
            int applicantId = Convert.ToInt32(ID);
            var expecetdUser = db.mockDatas.FirstOrDefault(a => a.applicant_id == applicantId);
            if (expecetdUser != null)
            {
                db.Entry(expecetdUser).CurrentValues.SetValues(updatedInfo);
                db.SaveChanges();
            }
            return; }
        public void DeleteApplicant(string ID)
        {
            int applicantId = Convert.ToInt32(ID);

            var applicant = db.mockDatas.FirstOrDefault(a => a.applicant_id == applicantId);
            db.mockDatas.Remove(applicant);
            db.SaveChanges();
            return;
        }
        
    }
}
