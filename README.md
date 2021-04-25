# MillionAndUpApi

### Description 

* Asp.net core api 5.0 with JWT authentication and basic EF context with a Sqlite database.
* This project contains migrations to create the database schema and seed the data.
* Dependency injection usage for all services.
* Mvc, Domain and Repository Patterns applied.
* This project contains integration tests using NUnit.
* Layers and responsibilities clearly defined.
* Git/Github integration.


### How to test

1. Run git clone https://github.com/jhongarzon/MillionAndUpApi.git
2. Cd MillionAndUpApi
3. Open MillionAndUpAssesment.sln file with Visual Studio 2019.
4. Run the project press F5
5. Once it compiles it should open a Swagger page like the one below:

![image](https://user-images.githubusercontent.com/25871181/115980965-24e9ba80-a556-11eb-8606-ed8a628dc9ff.png)

6. Go to the service called [Users/Authenticate] and enter the credentials below. You can also open the Sqlite Db file [MillionAndUp.Api/MillionUp.db] in and chose any user to make the authentication

![image](https://user-images.githubusercontent.com/25871181/115980995-53679580-a556-11eb-9aa0-0cbd108c541d.png)

7. Once you get the token you can pass it in the first service in Swagger pressing the button [Authorize] and then copy/paste the token you got in the previous step

![image](https://user-images.githubusercontent.com/25871181/115981124-37182880-a557-11eb-8fbc-6b6c7d5938df.png)

8. Now you can call any other service and it will show you the data in the [Sqlite] database.
9. To check the test you can go to your visual studio and run all the tests for Users and Properties controllers
