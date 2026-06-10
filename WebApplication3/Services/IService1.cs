using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;
using WebApplication3;


namespace WebApplication2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {
        [OperationContract]

        [WebGet(UriTemplate = "getAllApplicants", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        List<mockData> GetAllApplicants();
        
        [OperationContract]
        [WebGet(UriTemplate = "/getApplicantByID/{id}", ResponseFormat = WebMessageFormat.Json)]
        dynamic GetApplicantByID(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/createApplicant", ResponseFormat = WebMessageFormat.Json)]
        void CreateApplicant();

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/editApplicant", ResponseFormat = WebMessageFormat.Json)]
        void EditApplicant();

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteContact", ResponseFormat = WebMessageFormat.Json)]
        void DeleteApplicant(string ID);

        [OperationContract]
        [WebGet(UriTemplate = "test")]
        string Test();
        
        //Operation Contract 
        //WebGet/Invoke 
        //Funcion
    }
}