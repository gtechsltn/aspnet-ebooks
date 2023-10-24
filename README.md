# A website for e-books built with Asp.Net MVC5

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

## Account (Table: AspNetUsers)
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
