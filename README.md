# applicant-wcf-rest-api

This project is WCF REST API that performs queries on a Microsoft SQL Server. Based on the endpoint the API will either output structure JSON data, or a string of explanation.

## Tools Used
Visual Studio (VS)
Git
SSMS
Postman

## WCF REST API Overview
WCF REST APIs are REST APIs for Windows Communication Foundation. The structure is to have an operation contract, a WebGet for the endpoint, then the function to be executed

## Database Setup Assumptions
The database was already created, and sample data to populate tables were generated from Mockaroo.

## Entity Framework Setup Notes
Using the wizard in Visual Studio, I was able to incorporate ADO to map SQL data

## Connection string/security notes
By using Windows authentication, sensitive information like the user id or the password of a specific instance to a database were hidden.

## List of available endpoints
- /deleteContact
- /editApplicant
- /createApplicant
- /getApplicantByID
- /getAllApplicants

## Example request/response payloads
``` bash 
#Get All Applicants
[
  {
    "address_1": "4417 Birchwood Lane",
    "address_2": "Unit 12B",
    "applicant_id": 0,
    "applicant_status": "pending",
    "children_in_household": 2,
    "city": "Orlando",
    "country": "United States",
    "dental_transportation": false,
    "email": "mtanaka@example.com",
    "enough_food": true,
    "first_name": "Mariko",
    "gender_avatar": "https://robohash.org/marikotanaka.png?size=50x50&set=set1",
    "grocery_transportation": true,
    "health_insurance": false,
    "health_plan": "PPO",
    "household_size": 4,
    "illnesses": "Type 2 diabetes managed with medication; no other chronic conditions reported.",
    "insecurity_frequency": "Monthly",
    "job_loss_or_reduced_hours": true,
    "last_name": "Tanaka",
    "medical_transportation": false,
    "phone": "407-555-2048",
    "posted": true,
    "priority_id": 2,
    "reason": "Lost primary income after a seasonal layoff and struggling to cover monthly groceries.",
    "seniors_in_household": 1,
    "source": "referral",
    "state": "FL",
    "story": "Single parent of two working part-time while job searching.\n\nRent and utilities have consumed most of the household budget, leaving little for food.",
    "zip": "32801"
  },
  {
    "address_1": "3160 Bunting Center",
    "address_2": "54 Gina Terrace",
    "applicant_id": 1,
    "applicant_status": "pending",
    "children_in_household": 8,
    "city": "Genisséa",
    "country": "Greece",
    "dental_transportation": true,
    "email": "mdaen0@livejournal.com",
    "enough_food": true,
    "first_name": "Mandy",
    "gender_avatar": "https://robohash.org/nemononexplicabo.png?size=50x50&set=set1",
    "grocery_transportation": true,
    "health_insurance": true,
    "health_plan": "PPO",
    "household_size": 0,
    "illnesses": "congue risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam",
    "insecurity_frequency": "Never",
    "job_loss_or_reduced_hours": true,
    "last_name": "Daen",
    "medical_transportation": false,
    "phone": "330-214-5711",
    "posted": true,
    "priority_id": 4,
    "reason": "interdum venenatis turpis enim blandit mi in porttitor pede justo eu",
    "seniors_in_household": 4,
    "source": "referral",
    "state": null,
    "story": "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.",
    "zip": null
  },
  {
    "address_1": "48 Larry Street",
    "address_2": "818 Mayer Drive",
    "applicant_id": 2,
    "applicant_status": "denied",
    "children_in_household": 6,
    "city": "Dabu",
    "country": "China",
    "dental_transportation": false,
    "email": "rparradice1@1und1.de",
    "enough_food": false,
    "first_name": "Raff",
    "gender_avatar": "https://robohash.org/laudantiumrecusandaevoluptatem.png?size=50x50&set=set1",
    "grocery_transportation": true,
    "health_insurance": true,
    "health_plan": "PPO",
    "household_size": 5,
    "illnesses": "erat quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in",
    "insecurity_frequency": "Yearly",
    "job_loss_or_reduced_hours": false,
    "last_name": "Parradice",
    "medical_transportation": true,
    "phone": "100-566-1077",
    "posted": false,
    "priority_id": 2,
    "reason": "sit amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae",
    "seniors_in_household": 3,
    "source": "referral",
    "state": null,
    "story": "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.",
    "zip": null
  }, ...
]

```
``` bash 
#Get Applicant By ID

#Request
https://localhost:44351/services/service1.svc/getApplicantByID/{id}

#Response 
{
  "address_1": "3160 Bunting Center",
  "address_2": "54 Gina Terrace",
  "applicant_id": 1,
  "applicant_status": "pending",
  "children_in_household": 8,
  "city": "Genisséa",
  "country": "Greece",
  "dental_transportation": true,
  "email": "mdaen0@livejournal.com",
  "enough_food": true,
  "first_name": "Mandy",
  "gender_avatar": "https://robohash.org/nemononexplicabo.png?size=50x50&set=set1",
  "grocery_transportation": true,
  "health_insurance": true,
  "health_plan": "PPO",
  "household_size": 0,
  "illnesses": "congue risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam",
  "insecurity_frequency": "Never",
  "job_loss_or_reduced_hours": true,
  "last_name": "Daen",
  "medical_transportation": false,
  "phone": "330-214-5711",
  "posted": true,
  "priority_id": 4,
  "reason": "interdum venenatis turpis enim blandit mi in porttitor pede justo eu",
  "seniors_in_household": 4,
  "source": "referral",
  "state": null,
  "story": "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.",
  "zip": null
}
```
``` bash 
#Create Applicant

#Request
https://localhost:44351/services/service1.svc/createApplicant

#Response 
"Applicant sucessfully created"
```
``` bash 
#Edit Applicant

#Request
https://localhost:44351/services/service1.svc/editApplicant/{ID}

#Response 
"User sucessfully updated"
```
``` bash 
#Delete Applicants

#Request
https://localhost:44351/services/service1.svc/deleteContact/{applicantID}

#Response 
"User sucessfully deleted"

```
## How to run the service locally
To run the service locally make sure you have cloned into and have the repository open in VS. Then press the green play button, and the browser will open up shortly after. 

## Testing with Postman
Since this is a local build, Postman Desktop is needed to test the endpoints. I establish the connection by runnning th ecode, and then in the Postman window I send sample requests to the endpoint to see if the result I get back is expected. 

## Known issues or troubleshooting notes
It's important to make sure to choose the right things when setting up the project. I didn't and ran into an issue with endpoints not showing up at all
