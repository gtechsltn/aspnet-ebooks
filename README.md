# Bookstore Management in ASP.NET MVC 5 
+ Windows 11
+ Visual Studio 2019
+ SQL Server Management Studio 18
+ SQL Server Express **LocalDB**
+ ASP.NET MVC 5
+ Entity Framework 6
+ [**SMTP4Dev**](https://github.com/rnwood/smtp4dev/)
+ [**SB Admin 2**](https://github.com/StartBootstrap/startbootstrap-sb-admin-2)
+ HTML, CSS, JavaScript
+ [PLAN: Google Sheets](https://docs.google.com/spreadsheets/d/1ytUTc-IhOv2U19rmXv8X9mRTbE-dnBlmuV9JuYZM9Tc/)
+ [Guide: Google Docs](https://docs.google.com/document/d/1MrG85vfEP8z_4rXdPEqtRSbv4vslUnvESuxBKp-D-Gk/)
+ ConsoleApp1_GenCodeSample
+ ConsoleApp2_DownloadLinks

## Download HTML Source (link)
```

static void Main(string[] args)
{
    MainAsync(args).GetAwaiter().GetResult();
}

static async Task MainAsync(string[] args)
{
    string htmlSource = string.Empty;
    string url = "https://stackoverflow.com/questions/41778074/how-to-get-html-page-source-by-c-sharp";
    using (HttpClient client = new HttpClient())
    {
	    using (HttpResponseMessage response = await client.GetAsync(url))
	    {
		    using (HttpContent content = response.Content)
		    {
			    htmlSource = await content.ReadAsStringAsync();
			    File.WriteAllText(realPath, htmlSource, Encoding.UTF8);
		    }
	    }
    }
}

```

## Demo and Video
+ https://ebooks.demo.phanxuanchanh.com
+ https://www.youtube.com/watch?v=J5eICdblK3g

## Connection string using Windows Authentication
```
<add name="DefaultConnection" connectionString="Data Source=(localdb)\ProjectsV13;Initial Catalog=SachDienTu;Integrated Security=SSPI;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" />

<add name="Installation" connectionString="Data Source=(localdb)\ProjectsV13;Initial Catalog=SachDienTu;Integrated Security=SSPI;MultipleActiveResultSets=True;" providerName="System.Data.EntityClient" />

<add name="SachDienTuDBContext" connectionString="metadata=res://*/Models.SachDienTu.csdl|res://*/Models.SachDienTu.ssdl|res://*/Models.SachDienTu.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=(localdb)\ProjectsV13;Initial Catalog=SachDienTu;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
```

## How to start
+ Create DB "**SachDienTu**" in Local DB
+ Run **\SachDienTu\SQL\SachDienTu.sql**
+ Run script to create Roles (Table: AspNetRoles)
+ Run script to create Account (Table: AspNetUsers)
+ Run script to create UserRoles (Table: AspNetUserRoles)
+ Change connection string in web.config
+ Build solution success
+ F5 to start debugging

## Send Mail
+ Account > Register
+ Account > Confirm by Email
+ SMTP4Dev: Send Mail

## Roles (Table: AspNetRoles)
```
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('2A791232-D6E5-4D91-9B29-D83D5D825155',  N'Super Admin')
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('16242CE0-95DD-4B5B-8133-7C11B595176B',  N'Admin')
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('386DCAC5-6AFC-4214-AA99-F186F1721C7D',  N'SEOer')
```

## Users (Table: AspNetUsers)
+ User: chien672001
+ Email: chien672001@gmail.com
+ Pass: Abc@123$

```
INSERT INTO [dbo].[AspNetUsers]
           ([Id]
           ,[LastName]
           ,[FirstName]
           ,[Email]
           ,[EmailConfirmed]
           ,[PasswordHash]
           ,[SecurityStamp]
           ,[PhoneNumber]
           ,[PhoneNumberConfirmed]
           ,[TwoFactorEnabled]
           ,[LockoutEndDateUtc]
           ,[LockoutEnabled]
           ,[AccessFailedCount]
           ,[UserName])
     VALUES
           (N'2ffbf77e-63c3-4a18-9664-88fc967cf343'
           ,N'Nguyễn Văn'
           ,N'Chiến'
           ,N'chien672001@gmail.com'
           ,1
           ,N'ADvfagO8N+GTdDifEkP1cpIZeV2cFHY8H2Jeh1t1hhMR27JCCIp5WUJUJwqbuW3D6A=='
           ,N'58cf1eb0-43f6-4c87-9718-bb3b0c8a8070'
           ,N'0868033257'
           ,1
           ,0
           ,GETDATE()
           ,0
           ,0
           ,N'chien672001')
```

## UserRoles (Table: AspNetUserRoles)
```
INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '16242CE0-95DD-4B5B-8133-7C11B595176B')

INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '2A791232-D6E5-4D91-9B29-D83D5D825155')

INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '386DCAC5-6AFC-4214-AA99-F186F1721C7D')
```

# References
+ https://github.com/phanxuanchanh/aspnet-ebooks/
+ https://github.com/gtechsltn/aspnet-ebooks/
+ https://github.com/gtechsltn/BookStore-ASP.NET-5-Mvc/
+ https://github.com/gtechsltn/BookStoreMVC5/
