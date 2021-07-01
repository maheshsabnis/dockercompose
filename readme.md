# docker compose example
version: "3.9"
services: 
  serviceone: # name of the service
    container_name: empserv # the container name in which the image will be loaded
    ports:  # port from local mapped with the container 
        - 9001:80
    build: serviceone     # the folder from where the the dockerfile is read
  
  servicetwo:
    container_name: deptserv
    ports: 
        - 9002:80
    build: servicetwo

# run the compose file using following command

- docker-compose up
    - will create a network
    - this will build image and load it in container and expose port from container
    - all containers will be attached with the created network

# Releasing resources
- docker-compose down
    - remove cotatainers
    - remove network
    - But images will be as it is


# Hands-on
1. Create two APIs as
    - Providing List of Patients
    - Providing List of Doctors
2. Create a client application (ASP.NET Core / Angular)
3. Load these 3 apps in docker orachstration using docker-compose.yaml        