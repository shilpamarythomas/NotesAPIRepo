
CODE SETUP DETAILS

⦁	Copy the code to your local folder.

⦁	Change DB connection string in appsettings.json file as shown below
 ![image](https://github.com/shilpamarythomas/NotesAPIRepo/assets/119781064/34eb6083-2533-499d-b9e3-29a5b102bf40)

⦁	Make sure below nuget packages are available in NorLinqNotes Project (Dependencies-> Packages) folder as shown below
 ![image](https://github.com/shilpamarythomas/NotesAPIRepo/assets/119781064/44c9b6ea-e7c5-4a94-9bba-56180490e310)


⦁	Make sure below nuget packages are available in Entities Project (Dependencies-> Packages) folder as shown below.
		  ![image](https://github.com/shilpamarythomas/NotesAPIRepo/assets/119781064/6653bccf-598a-4ce6-a6a0-cf720288a368)

 

⦁	From package manager console run below commands to generate DB with tables and seed data
⦁	Add-Migration InitialCreate
⦁	Update-Database

⦁	Run the code

API DETAILS

⦁	Once the code is run, below screen will be displayed to test API methods
![image](https://github.com/shilpamarythomas/NotesAPIRepo/assets/119781064/81aa84fe-d063-4300-8a14-1e361eb4cbeb)

 
 
⦁	“/api/Note/GetNote” will give the list of notes. Below is the request URL for this method. Please change the local portno.
http://localhost:5293/api/Note/GetNote
⦁	“/api/Note/AddNotes” will add new notes with below input data. 				
 
	Below is the request URL for this method. 
	http://localhost:5293/api/Note/AddNotes

⦁	“/api/Note/UpdateNotes” will update notes. Below is the request body example value attached.
 

Below is the request URL for this method. 
http://localhost:5293/api/Note/UpdateNotes?Id=5
![image](https://github.com/shilpamarythomas/NotesAPIRepo/assets/119781064/0608a3e3-aaf0-4e9a-9cab-fe9094a06daa)

⦁	“/api/Note/DeleteNotes” will delete notes. Below is the request url
http://localhost:5293/api/Note/DeleteNote?Id=5


