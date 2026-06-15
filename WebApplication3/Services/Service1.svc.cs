using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
        public string CreateApplicant( mockData applicants) {
            var newApplicant = new mockData
            {
                first_name = "Mariko",
                last_name = "Tanaka",
                address_1 = "4417 Birchwood Lane",
                address_2 = "Unit 12B",
                city = "Orlando",
                state = "FL",
                zip = "32801",
                country = "United States",
                phone = "407-555-2048",
                email = "mtanaka@example.com",
                reason = "Lost primary income after a seasonal layoff and struggling to cover monthly groceries.",
                story = "Single parent of two working part-time while job searching.\n\nRent and utilities have consumed most of the household budget, leaving little for food.",
                gender_avatar = "https://robohash.org/marikotanaka.png?size=50x50&set=set1",
                enough_food = true,
                household_size = 4,
                insecurity_frequency = "Monthly",
                illnesses = "Type 2 diabetes managed with medication; no other chronic conditions reported.",
                posted = true,
                source = "referral",
                applicant_status = "pending",
                priority_id = 2,
                health_insurance = false,
                health_plan = "PPO",
                children_in_household = 2,
                seniors_in_household = 1,
                job_loss_or_reduced_hours = true,
                medical_transportation = false,
                grocery_transportation = true,
                dental_transportation = false,
            };
            if(applicants ==null)
            {
                applicants = newApplicant;
            }

            db.mockDatas.Add(applicants);
            db.SaveChanges();
                return "Applicant successfully created"; }
        public string EditApplicant(string ID, mockData updatedInfo) {
            int applicantId = Convert.ToInt32(ID);

            var newApplicant = new mockData
            {
                first_name = "Darnell",
                last_name = "Okafor",
                address_1 = "1208 Sandhill Crane Dr",
                address_2 = "Apt 304",
                city = "Kissimmee",
                state = "FL",
                zip = "34741",
                country = "United States",
                phone = "321-555-7716",
                email = "dokafor@example.com",
                reason = "Reduced work hours after a warehouse closure left the household short on grocery money each month.",
                story = "Recently took on care for an aging parent while working fewer hours.\n\nMost of the income now goes to medical costs, leaving little for consistent meals.",
                gender_avatar = "https://robohash.org/darnellokafor",
                enough_food = false,
                household_size = 5,
                insecurity_frequency = "Weekly",
                illnesses = "Hypertension and early-stage arthritis; both managed with regular medication.",
                posted = false,
                source = "online",
                applicant_status = "pending",
                priority_id = 4,
                health_insurance = true,
                health_plan = "HMO",
                children_in_household = 2,
                seniors_in_household = 2,   
                job_loss_or_reduced_hours = true,
                medical_transportation = true,
                grocery_transportation = false,
                dental_transportation = false,
            };
            // Find the user
            var expecetdUser = db.mockDatas.FirstOrDefault(a => a.applicant_id == applicantId);
            if (expecetdUser != null)
            {
                if (updatedInfo == null)
                {
                    updatedInfo = newApplicant;
                }
                // Where there is no new value for a key make it the exisiting one
                foreach (var prop in typeof(mockData).GetProperties())
                {
                    if (prop.GetValue(updatedInfo) == null)
                        prop.SetValue(updatedInfo, prop.GetValue(expecetdUser));
                }


                updatedInfo.applicant_id = expecetdUser.applicant_id;
                db.Entry(expecetdUser).CurrentValues.SetValues(updatedInfo);
                try { db.SaveChanges(); return "User successfullly updated";
                }

                catch (DbEntityValidationException ex) {
                    var errors = string.Join("\n", ex.EntityValidationErrors
            .SelectMany(e => e.ValidationErrors)
            .Select(e => $"Property: {e.PropertyName}, Error: {e.ErrorMessage}"));
                    throw new Exception(errors);
                }
            }
            return "Error updating user";
        }
        
        public string DeleteApplicant(string ID)
        {
            int applicantId = Convert.ToInt32(ID);

            var applicant = db.mockDatas.FirstOrDefault(a => a.applicant_id == applicantId);
            if(applicant != null) {
                db.mockDatas.Remove(applicant);
                db.SaveChanges();
                return "User sucessfully deleted";
            
            }
            
            return "No user found";
        }
        
    }
}
