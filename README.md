# ApiErrorLogging
Error logging via Api

This Application helps to log the error string passed from the frontend application.
Post Method is used for logging the error.

You can also clear or delete the logs from frontend application.
Delete Method is used for clearing the log. 
Normally in real world application we won't clear the logs, this is just done for demonstrating the delete o logs.

NOTE: Before running the application you need to set up database. SQL Scripts are available in solution under SQLScripts folder.
Data source in connection string of web.config has been updated for security reason. You need to put your pc name in data source of
connection string. Please find connection string below, you  need to put your pc name in place of NAME_OF_YOUR_PC variable
<add name="AngularLoggingEntities" 
connectionString="metadata=res://*/Models.ErrorLog.csdl|res://*/Models.ErrorLog.ssdl|res://*/Models.ErrorLog.msl;
provider=System.Data.SqlClient;provider connection string=&quot;data source=NAME_OF_YOUR_PC;
initial catalog=AngularLogging;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
providerName="System.Data.EntityClient" />
