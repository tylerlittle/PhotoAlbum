# PhotoAlbum
Overview
- This repository contains a console app written in C# that retrieves and displays photo ids and titles for a given album from <i>https://jsonplaceholder.typicode.com</i>
- Also contained within the solution is a project containing unit tests

---

### To run the app with Visual Studio 2019 for Mac:
- Copy the following repo url:  <i>https://github.com/tylerlittle/PhotoAlbum.git</i>
- Create a new directory for where you want to clone the repo to.  For example, create a new directory <i>photoAlbum</i> on the desktop.
- Open Visual Studio 2019
- In the menu bar, select <i>Version Control</i> &rarr; <i>Clone Repository</i>
- Paste the copied url into the <i>Url</i> textbox
- Choose the directory to clone the repo to.  This will be the directory created earlier.
- After the repo is cloned, proceed to build PhotoAlbum by selecting <i>Build</i> &rarr; <i>Build PhotoAlbum</i> from the menu bar.
- Open up a terminal and navigate to the root of where you cloned your project.  In our example, this will be inside the <i>photoAlbum</i> directory on the desktop.  From there, drill down to <i>PhotoAlbum</i> &rarr; <i>bin</i> &rarr; <i>Debug</i> &rarr; <i>net5.0</i>
- Once inside the <i>net5.0</i> directory, enter the command:
  - dotnet PhotoAlbum.dll <i>albumId</i>
    - where <i>albumId</i> is the id of the album to query

NOTE: Album ids range from 1 - 100.

Examples that will result in success:
- dotnet PhotoAlbum.dll 1
- dotnet PhotoAlbum.dll 3
- dotnet PhotoAlbum.dll 100

Examples that will return friendly errors (hints):
- dotnet PhotoAlbum.dll
- dotnet PhotoAlbum.dll 1 2
- dotnet PhotoAlbum.dll abc
- dotnet PhotoAlbum.dll 0
- dotnet PhotoAlbum.dll 101

---
### If using Visual Studio for Windows:
- Follow the same general steps as the steps for Mac above.
- After cloning the repo with Visual Studio, you will need to double-click the PhotoAlbum.sln if the Solution Explorer is opened in Folder View.  Once you are no longer in folder view, ensure to set the PhotoAlbum project as the startup project by right-clicking that project and selecting <i>Set as Startup Project</i>.

---
## Developed With
- C#
- .NET 5.0
- Newtonsoft.Json
- <span>xUnit.Net</span>
