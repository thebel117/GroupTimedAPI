Objective:

This project is designed to push you to begin working as a team. You and your teammates will utilize team git to work on a single code base in order to create an ASP.NET Web API that meets the requirements given below.

This brief time period is set up to provide you with a relatively safe environment in which you can grow (either through failure or success) as both an individual and a team. You may find yourself working with new technologies and/or people of varying understandings. The goal is for you to best figure out how to succeed through this process before moving on to a larger, more personal project.

All of that being said, it is important that for this exercise you work with your teammates and utilize your learning and resources together, rather than relying on your Instructors or the Learning Assistants. For this project, they will only step in if it is deemed absolutely necessary. You're welcome to ask questions, there is just no guarantee they will be immediately answered in depth.

 
Pre-Reqs:

    An understanding of an API
    An introduction to git
    An introduction to n-tier architecture


On Git/Branching

    Create a new branch for each section of code (feature) you add.
    When you're finished making these changes, commit and push your changes to your branch
    When you are ready to merge your changes into the master/main branch, make a Pull Request
    Everyone should periodically pull from master/main to stay up to date
    Make sure your master/main branch is updated before you make a new branch from it

 
Requirements:

Create an n-tier style (think Eleven Note) API that simulates functionality for a Social Media API. Each member of the group is responsible for at least one custom table with a minimum of three tables per group. Only two endpoints for each table are required for this project (see below). Your application should do its best to follow principles and patterns such as APIE and SOLID. You will need to complete the following tasks:

 
Construct an API based on the following models:

Users
    int Id
    string Email
    string Password
    nullable string FirstName
    nullable string LastName

Posts
    int Id
    string Title
    string Text
    int AuthorId (foreign key)
    virtual list of Comments
    virtual list of Likes (if applicable)

Comments
    int Id
    string Text
    int AuthorId (foreign key)
    int PostId (foreign key)
    virtual list of Replies

Replies
    int Id
    string Text
    int ParentId (foreign key)
    int AuthorId (foreign key)

Likes (optional)
    int Id
    int PostId
    int UserId (foreign key)

This should leave our database schema looking like so:

Construct endpoints including, but not necessarily limited to:

    POST (Create) a Post (required)
    GET All Posts (required)
    GET Posts By Author Id
    PUT (Update) a Post
    DELETE a Post

    POST (Create) a Comment on a Post using a Foreign Key relationship (required)
    GET Comments By Post Id (required)
    GET Comments By Author Id
    PUT (Update) a Comment
    DELETE a Comment

    POST (Create) a Reply to a Comment using a Foreign Key relationship (required)
    GET Replies By Comment Id (required)
    GET Reply By Author Id
    PUT (Update) a Reply
    DELETE a Reply

    POST (Create) a Like on a Post using a Foreign Key relationship (required if a group has four members)
    GET Likes By Post Id (required if a group has four members)
    GET Likes By Owner Id
    PUT (Update) a Like

 
Submit your link to a pushed GitHub repository.

 
Presentation:

Your team will present this project as a group.

How to Proceed:

This is a great way to get to know your team, as well as decide how your work patterns will function. We encourage you to start this project with a plan. Think about what the application is asking for, and try to scaffold out a Project Tree. Then some wireframes, and a trello board. Trello is a tool teams of developers use to create tickets(things that need to get done) and separate them into lists like Need To Do, In Progress, and Done. Here's

Links to an external site. a sample of how a development team could implement a Trello Board (ignore the GitHub Integration stuff). Taking the time to plan these steps out will help save headache in the future when your team begins to code!

 
Stretch Goals

Another part of project development comes in the form of stretch goals. These often include items/features that you want to include, but might not fit in the scope of the development cycle. If it's out of scope, it's not priority. If you find yourself completing the tasks at hand, you then reassess available stretch goals as well as any features on your backlog and decide what needs to be done next.

For this application, clean workable code is the primary objective. If you find yourself completing this, moving on to include a form of front end (through a console application or other means) can be a good direction to take the project.

 
Submission Guidelines:

Submit the link to the GitHub repository.

 

Finally, don’t lose sight of the 50,000 ft. view of why you are doing what you’re doing. You’re learning, it’s going to be messy, but that’s all a part of the fun. 