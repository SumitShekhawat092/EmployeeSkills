Good Morning, I have Implemented a Basic Functionality where we can see Employee List but Before we have to add some Employees with Their Skills set, So to run the application you have to follow belows steps:

Required Tools to Start in Your Window Laptop/Desktop.
1. Visual Studio 2022 ( URL: https://visualstudio.microsoft.com/vs/community/ | Find and Download: Visual Studio Community 2022 )
2. MS Sql Server (Instruction to Download and Install: https://www.youtube.com/watch?v=P6y0R3XzWlc)
3. ASP.NET Core Runtime 8.0.21 ( https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-8.0.21-windows-x64-installer )

Repo Location: https://github.com/SumitShekhawat092/EmployeeSkills

I have mensioned Short and More Explain Steps. person who alerady run .net project those can go with Short Expain to Quick run otherwise you go with Deep Explain so that you can not miss any step, lets Start :)

+++++++++++++++++++ Short Explain +++++++++++++++++++

Step 1: "Download Zip" : https://github.com/SumitShekhawat092/EmployeeSkills/archive/refs/heads/main.zip
Step 2: Double Click on "EmployeeSkills.sln" file to open Project
Step 3: Connection String: By the way you no need to Update Connection String I have use "." for Default Data Source, But If You Want to update "Data Source" then you can.
Step 4: Alt + x to Open Package Manager Console
        Type "Update-Database" Now Hit Enter Button
        It may be take for 15-20 Seconds but after completion you will see "Done." in the Console.

Step 5: Now Run the Project
        Press: F5 or Click on Green Play button With Selection Https to Run Project.
        You may see Popup to accept Trust SSL Certificate: Click On "YES"

Step 6: You can run application and Test
        Now Browser will open and you are ready to perform Add Employee Funcitionality 



+++++++++++++++++++ Deep Explain for Installation Process +++++++++++++++++++


Step 1: "Download Zip" : https://github.com/SumitShekhawat092/EmployeeSkills/archive/refs/heads/main.zip
Step 2: When You Extract/UnZip Folder you will find 4 Files and Folders
        EmployeeSkills  |   Folder  |   Contain Source Code
        .gitignore      |   File    |   git ignore file that ignore unrelevent changes
        EmployeeSkills.sln| File    |   with this file you will be able to run the project.
        README.md       |   file    |   Instruction to Start Application.

        Note: You just need to double click "EmployeeSkills.sln" file to Run application (Remember above required tools should be installed in your windows operating system)
        Note: Maybe You will see warning "Security Warning for EmployeeSkills" Popup when you open solution, So no worry just Click on Open Button :)

Step 3: When Visual studio open you will see "Solution Explorer" on Right Side where you can see list of project related folders and file.
        
        Now We Required to Update Connection String for That we need to Find "appsettings.Development.json" File.
        So in Solution Explorer Find appsettings.json near by you can see arrow button to explore files where you see "appsettings.Development.json"
        double click on that file So that we update our connection string.

        Note: If you are not able to find file no worries, Press "Ctrl + ;" and Type "appsettings.Development.json" to search file Then you will be able to find that file, Click on it to see connection string.


        After Open file you will see peice of code as below:
        "ConnectionStrings": {
            "DefaultConnection": "Data Source=SUMIT\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Db_EMPSkill;Trust Server Certificate=True"
        }

        Here we required to change Data Source From "Data Source=SUMIT\\SQLEXPRESS;" to "Data Source={your server};"


Step 4: Migration for Database Creation
        Press: Alt + x (to open Package Manager Console)
        or you can go "Tools" > "Nuget Package Manager" > "Package Manager Console" 
        after then you have to write "Update-Database" and Hit Enter Button

        PM> Update-Database

        It may be take for 15-20 Seconds but after completion you will see "Done." in the Console.


Step 5: Now Run the Project
        Press: F5 or Click on Green Play button With Selection Https to Run Project.
        You may see Popup to accept Trust SSL Certificate: Click On "YES"

Step 6: You can run application and Test
        Now Browser will open and you are ready to perform Add Employee Funcitionality 