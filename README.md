# Assignment: Creating a Blog Backend

## Introduction

In this assignment, we'll create the backend infrastructure for a multi-author blog platform. The platform will support multiple blogs, each managed by different authors, with moderation capabilities and user interaction through comments.

## Scenario

Atlas Publishing Co. wants to create a new blogging platform that will host multiple independent blogs. Each blog will have a single author who can create and manage their posts. The platform needs to support user registration so readers can comment on posts, and a moderation system should be included to manage these comments.

Sarah, the project manager, has outlined these key requirements:

- Authors should only be able to manage their own blog's content. This includes creating and editing posts.
- Moderators should be able to review and hide inappropriate comments across all blogs.
- Comments should be visible by default, but moderators can hide them if needed.
- The system should use modern authentication and authorization practices.

This is the project's first phase, where we will only focus on the core infrastructure.

## Requirements

### Data Structure

We will use SQLite as the database storage for this application and ASP.NET Identity for the authorization and authentication system. Please create the following tables in a SQLite database:

`Blogs` 

- Blogs are associated with a single author.
- They contain the title, subtitle, description, creation date/time, and last edited date/time.
- One-to-many relationship with `Posts`.

`Posts` 

- Posts are associated with a single blog.
- They contain the title, post date, post text, creation date/time, and last edited date/time.
- One-to-many relationship with `Comments`

`Comments`

- Contains the creation date/time, comment text, a visibility flag, and the user ID.
- The comment will be hidden from non-moderator users if the visibility is false.
- No comment hierarchy (replies) is needed.

### Authentication and Authorization

We will use ASP.NET Identity for user authentication and claims management. Install identity and create and execute the initial migrations to set up the SQLite database.

> **Note**: You may choose to write database creation scripts for the `Blogs`, `Posts`, and `Comments` tables or use an Entity Framework migration to create them.

We will add claims support for more granular authorization in a future assignment. However, we are not building the user interface in this part of the project.

### Technical Requirements

1. Start with the ASP.NET Core empty template. 
2. Install and configure Entity Framework Core and ASP.NET Identity with SQLite as the backend.
3. Set up the Entity Framework DB Context to include the `Blogs`, `Posts`, and `Comments` tables.
4. Set up the DBContext and Password policy in `Program.cs`.  Please enable controllers, views, authentication, authorization, and the default route.
5. Do **not** create any views or controllers. The only models created should be those needed for the DB Context.

## Starter Files

Start a new project from the empty template.

## Conclusion

By implementing proper data structures and authentication mechanisms early on, we ensure the application can scale and maintain security as new features are added. Working with Entity Framework Core, implementing ASP.NET Identity, and designing data relationships are early considerations in designing and building real-world applications.