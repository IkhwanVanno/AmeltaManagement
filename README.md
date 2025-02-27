How to run the project
insert the .bak database file into the sql management system, the file is in the folder (DatabaseFile).
how to backup database in SqlManagementSystem
- Right click on Databases > Restore Database...
- Select Device > Click Add > Select .bak file.
- Check the database that will be restored.
- Click OK to start the restore.

How to open a project 
- open the sln file in visual studio code 2022
- make sure the database address is difficult to match your computer (settings are in the koneksi.cs file)
- conn.ConnectionString = “Data Source=your server name;Initial Catalog=your database name;Integrated Security=True”;
- then run/debug the project
