# MarktGuru

Open up WebAPI/appsettings.json to change the connection strings. Here you can choose to have multiple DBs for a separation of the IdentityDB 
or have the same DB for Identity and Application. Once that is Set, Run these commands to update the database.

update-database -Context IdentityContext

update-database -Context ApplicationDbContext


Finally, build and run the Application.


Default Roles & Credentials

As soon you build and run your application, default users and roles get added to the database.


Default Roles are as follows.

SuperAdmin

Admin

Moderator

Basic


Here are the credentials for the default users.

Email - superadmin@gmail.com / Password - 123Pa$$word!

Email - basicuser@gmail.com / Password - 123Pa$$word!


You can use these default credentials to generate valid JWTokens at the ../api/account/authenticate endpoint.
