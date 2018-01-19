DEPLOYMENT GUIDE

1- Implemented using IIS Express. It should host the web api on the http://localhost:53559/. Routes were configured using urls like /api/.../...
2- SQL express needed. Please notice that the webconfig contains the connection string to the data base. Currently set to point to the instance .\SQLEXPRESS
3- Script included into the Solution Items folder. EntityFramework was configured to create the database with some mock data by using an Initializer. It supposed to create the table USERS with some test data.
   In case this does not work, you can run the script which also includes test users data.
4- The URL of the external Banco Provincia service was configured in the webconfig of the API project.