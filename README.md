# A website for e-books built with Asp.Net MVC5

## How to start
+ Create DB "**SachDienTu**" in Local DB
+ Run **\SachDienTu\SQL\SachDienTu.sql**
+ Change connection string in web.config
+ Build solution success
+ F5 to start debugging

## Send Mail
+ SMTP4Dev: Send Mail

## Roles
```
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('2A791232-D6E5-4D91-9B29-D83D5D825155',  N'Super Admin')
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('16242CE0-95DD-4B5B-8133-7C11B595176B',  N'Admin')
INSERT INTO [dbo].[AspNetRoles](Id, [Name]) VALUES ('386DCAC5-6AFC-4214-AA99-F186F1721C7D',  N'SEOer')
```

## Account
+ User: nvmanhifi
+ Mail: nvmanhifi@gmail.com
+ Pass: Abc@123$

## UserRoles
```
INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '16242CE0-95DD-4B5B-8133-7C11B595176B')

INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '2A791232-D6E5-4D91-9B29-D83D5D825155')

INSERT INTO [dbo].[AspNetUserRoles](UserId, RoleId) VALUES ('2ffbf77e-63c3-4a18-9664-88fc967cf343', '386DCAC5-6AFC-4214-AA99-F186F1721C7D')
```
