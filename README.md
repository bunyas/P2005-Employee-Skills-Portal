Prerequisites
Before you begin, ensure you have the following installed:

.NET Core SDK
Visual Studio (2019 or later)
Azure Account
Azure CLI
IIS installed on Windows
Running Locally
Clone the Repository:


git clone https://github.com/your-repository-url.git
cd your-repository-name
Restore Dependencies:

dotnet restore
Update appsettings.json:

Ensure appsettings.json is correctly configured for local development.

Run the Application:

dotnet run
Access the Application:

Open your browser and navigate to https://localhost:5001.

Deploying to Azure
Using Visual Studio
Publish to Azure:

Right-click on the project in Solution Explorer and select Publish.
Choose Azure as the target.
Select Azure App Service (Windows) and click Next.
Sign in to your Azure account.
Create a new Azure App Service or select an existing one.
Click Finish to deploy.
Configure Azure AD Authentication:

Ensure your Azure App Service is configured with the correct Azure AD settings as outlined in the application setup.

Access the Application:

Open your browser and navigate to https://p2005.azurewebsites.net/


Deploying to IIS
Install .NET Core Hosting Bundle
Download and install the .NET Core Hosting Bundle on the server.

Configure IIS
Open IIS Manager:

Press Windows + R, type inetmgr, and press Enter.

Add a New Site:

Right-click on Sites and select Add Website.
Configure the site name, physical path (to your published application), and binding information.
Click OK.
Publish Application:

In Visual Studio, right-click the project and select Publish.
Choose Folder as the publish target.
Select a folder to publish your application to and click Finish.
Copy Files:

Copy the published files to the physical path configured in IIS.

Configure Application Pool:

In IIS Manager, select the new site and click Basic Settings.
Ensure the application pool is set to use No Managed Code.
Browse the Application:

Open your browser and navigate to http://localhost.
