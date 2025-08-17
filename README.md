# Carseer-Assignment-
This assignment required for the Software Developer role in Carseer Company, using .NET Core.

How to run the app locally:

1. Clone the repository:
git clone https://github.com/RahafDuhaimesh/Carseer-Assignment-.git

2. Navigate to the project folder:
cd Carseer-Assignment-/carseerTask

3. Build and run the application:
dotnet build
dotnet run

5. Open the browser and go to: http://localhost:5000

6. Build the Docker image:
docker build -t carseer-app .

7. Run the Docker container:
docker run -d -p 8080:80 -e ASPNETCORE_URLS=http://+:80 -e DOTNET_RUNNING_IN_CONTAINER=true carseer-app

8. Open the browser and go to: http://localhost:8080





