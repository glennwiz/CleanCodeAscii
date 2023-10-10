# CleanCodeAscii

    +---------------------+     +---------------------+
    |    Presentation     |     |   Infrastructure    |
    |---------------------|     |---------------------|
    | - Controllers       |     | - Repositories      |
    | - ViewModels        |     | - Database Access   |
    | - API Endpoints     |     | - File I/O          |
    +---------------------+     +---------------------+
                |                           |
                |                           |
    +-----------v---------+                 |
    |   Application Layer |<----------------+
    |---------------------|    
    | - Service Classes   |   
    | - Use Cases         |   
    | - DTOs              |    
    | - Interfaces        |    
    +-----------+---------+   
                |
                |
    +-----------v---------+
    |      Domain Layer   |
    |---------------------|
    | - Entities          |
    | - Business Rules    |
    | - Value Objects     |
    +---------------------+
