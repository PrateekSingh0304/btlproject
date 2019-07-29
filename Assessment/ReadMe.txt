Steps to run the application:
The application consists of 3 parts
* Web Client
* Backend Service
* SQL DB Schema.

To run the application:
1. Extract the database schema to your local sql instance.
2. Open folder DB Schema and execute the Stored Proc on the database instance that you extracted in the previous step.
3. Open the "Service" folder and open the .sln file using Visual Studio.
4. If not already configured, configure your service to run on port number 51993.
5. Install node version 8.11.3 on your system.
6. After that install Angular CLI version.
7. Open the folder "Web-Client\web-client" in VS Code and do npm install @angular/cli@7.3.6 on node command prompt.
8. Once done, run command npm start on VS command prompt or ng serve -o from node command prompt after setting correct path of the application.



Application Insight:
The application currently fetches the data from the database and displays to client using Angular Client.
It provides the functionality to display the data and client side filtering on person name.
It can be easily extended for pagenation in future.