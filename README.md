# Mimo Backend Coding Challenge

This is Mimo's Backend Coding Challenge

If you are reading this, you most probably have been asked to complete this assessment as part of Mimo's interview process.

In this repository, you will find the base project and instructions on what to do with them. 

## What is done

Basic layers, some api endpoints.

## What's missing   
0. **Tests for all layers** :worried:
1. DDD, 
2. Events, 
3. Cross cutting concerns, automapping etc,
4. Caching (lessons and chapters are not frequently changed )


I rushed to finish this for the end of the week because of the holidays...  
  
On an Ideal world with DDD approach I would have a **Course** aggregate root, user aggregate and not anemic model.

There would be events such as when a lesson is completed increase the progress of the achievement, same with when all lessons on a chapter are completed and so on and so forth for all achievement types...  


## Instructions
1. Unzip the project  
2. Navigate to the folder in project path from the **command line**
3. Run command
    ```csharp
   dotnet restore
   ```
4. Run 
   ```csharp
   dotnet build
   ```
5. To run
   ```csharp
   dotnet run
   ```


## Contact

Adem Gashi - [@ademg](https://linkedin.com/in/ademg) - adem888@gmail.com




