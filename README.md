# .Net 8 - Docker - Nginx -Elasticsearch - Kibana - Ocelot - RabbitMq - Postgresql - Entity Framework

[Micro-Publish on Postman](https://www.postman.com/winter-equinox-787317/micro-publish/overview)

![General Architecture](MicroCaseStudy/system-summary.png)


  # BackEnd:
  Docker structure is being established...
      
   ```ruby
   docker-compose build
   ```
   ```ruby
   docker-compose up -d
   ``` 
   
  ## Technologies used:

* ASP.NET Core
* Entity Framework
* Swagger
* Mapper
* Serilog
* Rate Limit
* Ocelot
* Elasticsearch
* Kibana
* Nginx
* RabbitMQ

# Case Study - Microservice Project

This project is designed as a microservice architecture for **user management, customer management, and sales tracking**. Below are the expected features and evaluation criteria.

## Expected Features

### 1. User Management:
- Users should be able to log in to the system (**JWT authentication**).
- Manage user roles (**Admin, Sales Representative, etc.**).
- User information should be managed with **CRUD operations**.

### 2. Customer Management:
- Customers' information (**name, email, phone, company**) should be managed with **CRUD operations**.
- Notes can be added and edited for each customer.
- The customer list should be **sortable and filterable**.

### 3. Sales Tracking:
- Create a **sales pipeline** for potential sales (e.g., "New", "In Contact", "Negotiation", "Closed").
- Store the **date and notes** for each sales stage.
- Log the **timestamp** when the sales status changes.

### 4. Microservice Architecture:
- User management, customer management, and sales tracking should be designed as **separate microservices**.
- Microservices should communicate through an **API Gateway**.

### 5. Database:
- Design using **SQL or NoSQL database** preference.
- Each microservice should have **its own database**.

### 6. Testing & Documentation:
- Write **unit tests** for each service.
- Prepare API documentation (**Swagger** is recommended).

## Evaluation Criteria

1. **Code Quality**:  
   - Modularity, readability, and adherence to **DRY principles**.  
2. **Microservice Design**:  
   - Independence of services.  
3. **Database Design**:  
   - Performance and scalability.  
4. **Testing & Security**:  
   - Coverage of unit tests.  
   - Secure authentication using **JWT**.  
5. **Technical Documentation**:  
   - Detailed documentation for better understanding.  
6. **Performance & Usability**:  
   - API response times and efficiency.  

## Project Submission

- Version control the microservices using **Git** and upload them to a remote repository (**GitHub, GitLab, Bitbucket**).
- Containerize the microservices.
- Organize each microservice in **separate folders**.
- Use **Docker Compose** to orchestrate the entire system (`docker-compose.yml` file).
- Follow **clean code** and **secure coding** principles.
- API documentation should be accessible via **Swagger**.
- Preferably, provide a **video explanation** of your work and share its link.

