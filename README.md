# ApiErrorLogging
Error logging via Api

This Application helps to log the error passed from the frontend application.
Http's Post Method is used for logging the error.

You can also clear or delete the logs from frontend application.
Http's Delete Method is used for clearing the log. 
Usually in real world application we won't clear the logs, this is just done for demonstrating the delete of logs.

NOTE: Before running the application you need to set up database. SQL Scripts are available in solution under SQLScripts folder.
Data source in connection string of web.config has been updated for security reason. You need to put your pc name in data source of
connection string (put your PC name in place of NAME_OF_YOUR_PC in connection string).