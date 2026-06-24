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

---

## Deployment

WCF REST services are hosted in **IIS** rather than run as a standalone executable. The service is published to a folder, which is then served by an IIS site/application pool.

### Deployment steps

1. Pull the latest code and confirm it builds locally:
   ```
   git pull
   ```
   Then build the solution in Visual Studio (Build > Build Solution) and confirm no errors.
2. Publish the service from Visual Studio:
   - Right-click the project > **Publish**.
   - Choose a **Folder** publish target (e.g. `C:\inetpub\wwwroot\ApplicantApi` or a staging folder like `C:\Deploy\ApplicantApi`).
   - Publish in **Release** configuration.
3. Confirm `Web.config` made it into the published output. This holds the connection string and WCF service/endpoint configuration, so the service won't run correctly without it.
4. Copy/move the published folder to the IIS site's physical path if you published to a staging folder rather than directly into `wwwroot`.
5. In **IIS Manager**, point a site or application at the published folder and assign it to an application pool (see **Runtime configuration notes**).

### Runtime configuration notes

- All configuration lives in `Web.config` — the connection string, WCF service behaviors, and endpoint bindings are loaded from here at startup.
- The service must run under an **application pool** in IIS. The application pool's **identity** is the account the service runs as, and it's that account (not your personal dev login) that needs the SQL login — see **Required permissions**.
- Make sure the app pool is set to the correct **.NET CLR version** (.NET Framework 4.x for a WCF service) and that **Integrated** pipeline mode is selected unless your project requires Classic.
- After changing `Web.config`, IIS automatically recycles the app on the next request — no manual restart usually needed, but you can recycle the app pool from IIS Manager to force it.

### Connection string guidance

`Web.config` example (inside `<connectionStrings>`):
```xml
<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Server=YOUR_SERVER;Database=internDB;Trusted_Connection=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

- The service uses Windows (`Trusted_Connection`) authentication, so no SQL login/password is stored in config.
- Because IIS runs the service under the **application pool identity**, that identity is the account connecting to SQL Server — make sure it has a mapped SQL login (see **Required permissions**). The default `ApplicationPoolIdentity` appears to SQL Server as something like `IIS APPPOOL\<AppPoolName>`, or you can set the pool to run under a dedicated domain/service account.
- Never commit a connection string containing a real username/password to the repo; Windows auth avoids this entirely.

### Folder path setup

For a folder-publish IIS deployment, the structure looks like:

```
<deploy folder>/
  bin/                ← compiled service DLLs
  Service1.svc
  Web.config          ← connection string + WCF config
```

- This service doesn't create runtime folders — it only reads from / writes to the database and returns responses.
- The folder simply needs to be a valid IIS application root with `Web.config` at its root and the compiled DLLs in `bin/`.

### Required permissions

- **Folder permissions**: the application pool identity needs **Read & Execute** access to the deployed folder. IIS grants this automatically when the site is created under `wwwroot`, but verify it if you deploy to a custom path.
- **SQL Server permissions**: the application pool identity needs a SQL Server login mapped to the `internDB` database with at least `db_datareader` and `db_datawriter` (the create/edit/delete endpoints write to the DB). Map this in SSMS under Security > Logins.

### Logging location

- WCF can log to **IIS logs** (request-level, under `C:\inetpub\logs\LogFiles\`) and, if enabled, **WCF tracing** via `system.diagnostics` in `Web.config`, which writes a `.svclog` trace file to the path you configure.
- For application/SQL errors, check **Windows Event Viewer** (Application log) and IIS Failed Request Tracing if enabled.

### How to run/verify the deployed application

1. Browse to the service base URL in a browser (replace `localhost:44351` with the deployed host):
   ```
   http://<server-or-host>/ApplicantApi/services/service1.svc
   ```
   A valid WCF service responds with the service help/metadata page.
2. Test each endpoint in Postman against the deployed host:
   ```
   http://<server-or-host>/ApplicantApi/services/service1.svc/getAllApplicants
   http://<server-or-host>/ApplicantApi/services/service1.svc/getApplicantByID/1
   ```
3. Confirm `getAllApplicants` returns JSON and `getApplicantByID/{id}` returns the expected single record — this proves both the IIS hosting and the SQL connection work end to end.
4. Test a write endpoint (`createApplicant`) and confirm the success string and the new row in SSMS.

### Troubleshooting notes

| Symptom | Likely cause | Fix |
|---|---|---|
| Endpoints don't show up / 404 on `.svc` routes | Project not set up correctly for WCF REST, or routing/WebGet missing — same issue hit during local setup | Confirm the service is configured for `webHttpBinding` with `WebGet`/`WebInvoke` attributes and correct `UriTemplate` |
| `HTTP 500` / service fails on every request | `Web.config` missing, malformed, or connection string wrong | Confirm `Web.config` published, validate `DefaultConnection`, check Event Viewer for the exception |
| Login failed for user `IIS APPPOOL\...` | App pool identity has no SQL login | Map the app pool identity as a SQL login in SSMS with `db_datareader`/`db_datawriter` on `internDB` |
| `.svc` returns "handler not registered" / page asks to download the file | WCF/HTTP Activation Windows feature not enabled in IIS | Enable **WCF Services > HTTP Activation** in Windows Features and restart IIS |
| Works in VS but 403/access denied once deployed | App pool identity lacks Read/Execute on the deploy folder | Grant the app pool identity (or `IIS_IUSRS`) Read & Execute on the folder |

### Screenshots or examples

_Add a screenshot of the deployed service responding in the browser (`service1.svc` metadata page) and a Postman request hitting the deployed host returning JSON._

## Known issues or troubleshooting notes
It's important to make sure to choose the right things when setting up the project. I didn't and ran into an issue with endpoints not showing up at all
