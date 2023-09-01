# GitHubIntro

This project provides a quick introduction to working with GitHub and inheritance in Object Oriented C#.  
You will need to work in groups with at least 1 other student.  
Create your groups and decide who will act as the leader then decide a different regular 2D shape for each person to be in charge of implementing. Try to keep the shapes simple (Square, Circle, etc) as you will have to implement a method for calculating their area.  
Make sure to read the instructions and observe the tasks other roles have.


## Forking a Repo
[GitHub Guide](https://docs.github.com/en/get-started/quickstart/fork-a-repo)  
A fork is a copy of an existing repo that has the same code and visibility as the original. This allows other users to work on public repos where they do not have write access. This can be used for features such as fixing issues, iterating on ideas or using the work as a starting point.

### Instructions: For Leader
You need to create a fork of this repo.  
* At the top of the page there is a button with 'Fork', select it and 'Create Fork'


## Changing Visibility
Repos can be either 'Private' or 'Public', you should make sure your repo is public so your lecturer can monitor your progress.

### Instructions: For Leader
You need to let your Tutor know the URL of your repo, they will be able to confirm if it is public  
You need to set your repo to public
* Select the 'Settings' option on your Repo
* Scroll down to the bottom of the page to find the 'Danger Zone'
* Select the following options:
  * 'Change visibility'
  * 'Change to public'
  * 'I want to make this repository public'
  * 'I have read and understand these effects'
  * 'Make this repository public'


## Adding Collaborators
For users to contribute to a repo they need to be added as a collaborator

### Instructions: For Leader
You need to add the rest of your group as collaborators on your repo
* Select the 'Settings' option on your repo
* Select the 'Collaborators' section
* Under 'Manage access' select 'Add people'
* Find the username of the person you want to add and click 'Select a collaborator above'

### Instructions: For Others
You need to accept the invitation to collaborate.
* Go to the email account linked to your GitHub and accept the invitation to collaborate


## Opening a Repo in Visual Studio 2022
Opening the repo in your IDE helps simplify your workflow with a GUI for actions such as commiting, pushing, pulling and solving merge conflicts.

### Instructions: For Everyone
You need to clone the repo to create a local copy.
* Open Visual Studio 2022
* Select '**Clone a repository**'
* Enter the url of the forked repo as the 'repository location'


## Creating and Working on a Branch
[GitHub Guide](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-branches)  
Branches are often used to add new features or fixes to a project. They branch off from the master branch on creation and are later merged back in. Branching allows for multiple developers to be developing different aspects of a program simultaneously.  
In this example we are going to have everyone develop a shape simultaneously to showcase branching.

### Instructions: For Everyone
You need to create a new branch to work on.
* At the bottom right select 'master'
* Click the 'New Branch' button and enter an appropriate name. Branches should have clear and distinct names such as the shape you are working on.
* Make sure you are basing the branch on 'master'
* Select 'Create' and make sure that 'master' has swapped to your branch's name, this shows that you are now working on that branch.

## Development
### Instructions: For Everyone
You need to create and test your unique shape class. You should look at `Octagon.cs` for reference.
* In the 'Solution Explorer' right click your project and create a new class
* Name the class with the name of your shape
* Make your class public and inherit the `Regular2DShape` class
* Right click the error on your class's name and select the two following options:
  * '**Quick Actions and Refactorings...**' --> '**Implement Abstract Class**' to create the method `GetArea()` without implementation.
  * '**Quick Actions and Refactorings...**' --> '**Generate constructor 'Shape(length)**' to create the constructor for the class.
* Implement the `GetArea()` method by removing the existing code that throws an error and replacing it with code to calculate and return the area of your shape
* Return to `Program.cs` to create a new instance of your shape, calculate its area and write it to the console.

## Commiting and Pushing Changes
[GitHub Guide](https://github.com/git-guides/git-commit)  
Commits can be thought of as a snapshot of your repository at a certain time. You can use commits to mark when a feature is completed, or in class you may use a commit as a way of saving progress at the end of a lesson. Commits are only saved locally, to make sure a commit is saved remotely you need to push the commit to the branch.

### Instructions: For Everyone
You need to commit your changes and push them to your remote branch
* Search for 'Commit or Stash' to bring up the Git Changes window
* Enter a brief message summarising your changes. This could be as simple as 'Implemented Octagon'
* Select 'Commit All'
  * If you have not saved your work before commiting you will be asked if you want to save files before commiting. Accept this by clicking 'Save and commit'.
* Wait until get a message saying your commit has been created. Ask your lecturer if there is an issue.
* Push your changes to remote with the third icon (Underlined up arrow)
* Wait until you get a message stating you have successfully pushed to origin. Ask your lecturer if there is an issue
* Create a pull request for your commit via the pop-up
* Go to GitHub and check that your changes have been reflected in the remote repo and that a pull request has been created

## Merging Branches and Solving Conflicts
Merging branches is typically done via Pull Requests. One member of the group should go first, they will not have to solve a conflict but should watch how others solve them.

### Instructions: One at a time
You need to merge the pull requests back into the master branch.
* On GitHub open the 'Pull Requests' tab

#### First Person
* You should see a message stating 'This branch has no conflicts with the base branch'
* Click 'Merge pull request' then 'Confirm merge'

#### Everyone Else
* You should see a message stating 'This branch has conflicts and must be resolved'
* Click 'Resolve Conflicts'
* Resolve the conflict(s) by modifying the code inside
  * You should ensure every shape is created and has its area printed only once
  * You need to remove the extra symbols added in to show where conflicts are such as `<<<<<< BranchName` and `======`
* Select 'Mark as resolved' when it has been resolved then 'Commit merge'
* You should now see a message stating 'This branch has no conflicts with the base branch'
* Click 'Merge pull request'
  
#### Optional Clean-Up
* Return to the 'Code' tab and go to change the branch, select 'View all branches'
* Find your branch in the 'Active branches' section and click the delete button

### Updating Locals
* Return to Visual Studio 2022
* Go to change branch and then '...' and 'manage branches'
* Select the 'master' branch and then 'pull'
* You should now see all of the changes the rest of your group have made
