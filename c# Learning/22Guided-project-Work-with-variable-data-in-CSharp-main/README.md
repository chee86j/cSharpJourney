# Guided-project-Work-with-variable-data-in-CSharp

https://learn.microsoft.com/en-us/training/modules/guided-project-work-variable-data-c-sharp/2-prepare

Starter and Solution code for the **Guided project**: "Work with variable data in C# console
applications" from the Microsoft Learn collection "Getting started with C#"

Prepare for guided project

Use Visual Studio Code to develop a version of a C# console application. The application comes with the basic features that create sample data on pets available for adoption and is able to display the pet's information. The main feature to add is searching available dogs using a single search term. The secondary tasks include adding and displaying suggestedDonation data.

The design specification
For the new features of the Contoso Pets application, the design specification provides details for the dog search and suggested donation features:

-Dog attribute search

--Gather input for the pet characteristic search term
--Loop through the animals array and identify "dogs"
--For each dog, combine the physical and personality descriptions to search
--Search the combined description for the input term match
--Output the dogs that have a term match

-Suggested donation data

--Define suggestedDonation string
--Expand the ourAnimals array to contain suggestedDonation and populate sample data for suggestedDonation
--Ensure all usage of ourAnimals array accounts for the added suggestedDonation data
--Output suggestedDonation with regional currency symbol ($, €, ¥,... )

Starter code overview
Initial starter code development is complete.

1. The Starter project for this guided project module includes a Program.cs file that provides the following code features:

-the code declares variables used to collect and process pet data and menu item selections

-the code declares the ourAnimals array

-the code uses a for loop around an if-else if-else construct to populate the ourAnimals array with a sample dataset

-the code displays the following main menu options for user selection:

    Output

    1. List all of our current pet information
    2. Display all dogs with a specified characteristic

    Enter menu item selection or type "Exit" to exit the program

-the code reads the user's menu item selection and displays a message echoing their selection

-only selection "1. List all of our current pet information" functions using the starter code

Your goal is to update the existing code to develop app features described previously. The key features:

-Add dog attribute search

-Include suggested donation data

You use Visual Studio Code as your development environment, and you test your application at each stage of your development process.

Setup
A. On your local machine, navigate to your downloads folder.
B. Right-click the Guided-project-Develop-conditional-branching-and-looping-structures-in-CSharp.zip file, and then select Extract all.
C. Use the Browse button to specify the Windows Desktop folder as the extract location, and then select Select Folder.
D. Select Show extracted files when complete, and then select Extract.
E. Make note of the extracted folder location.

Open the extracted Guided-project-Work-with-variable-data-in-CSharp-main folder in Visual Studio Code

A. Open Visual Studio Code locally (or open MS Learn sandbox and open Visual Studio Code if you aren't using a local dev environment)

B. In Visual Studio Code, on the File menu, select Open Folder

C. Navigate to the folder that contains your extracted files, expand the folder structure to locate the folder named "GuidedProject".

D. Select Guided-project-Work-with-variable-data-in-CSharp-main and then select Select Folder
i. The Visual Studio Code EXPLORER view should show two subfolders named Final and Starter.

You're now ready to begin the Guided project exercises. Good luck!
