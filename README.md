
# **Ecommerce Microservices Architecture with .NET Core**

## **Project Overview**
This repository demonstrates a fully functional **e-commerce system** implemented using a **microservices architecture**. The project is designed to showcase modern development practices, focusing on scalability, maintainability, and event-driven communication.

## **Key Features**
- **Product Service:** Manages the product catalog with CRUD operations.
- **Order Service:** Handles order creation and processing asynchronously.
- **Notification Service:** Sends email or in-app notifications when an order is processed.
- **API Gateway:** Centralized routing for client requests to the appropriate microservices.
- **Database Integration:** Each service uses its own SQL database following the database-per-service pattern.
- **Message Broker:** RabbitMQ enables communication between microservices using publish/subscribe patterns.

## **Technologies Used**
- **.NET Core:** Framework for building high-performance web APIs.
- **Entity Framework Core:** ORM for database interactions.
- **RabbitMQ:** Message broker for inter-service communication.
- **Docker:** Containerization for consistent and portable environments.
- **Ocelot (or YARP):** API Gateway for centralized request routing.
- **Serilog:** Structured logging for observability.

## **System Architecture**
- **Microservices:** Independently deployed services communicating via RabbitMQ.
- **Event-Driven Communication:** RabbitMQ facilitates asynchronous communication between services.
- **API Gateway:** Manages client communication and routes requests to services.
- **Scalable Design:** Each service is decoupled and can scale independently.

## **How to Run**
1. **Install Dependencies:**
   - Docker and Docker Compose.
   - .NET Core SDK.
2. **Set Up RabbitMQ:**
   - Use Docker to start RabbitMQ:
     ```bash
     docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:management
     ```
   - Access RabbitMQ Management UI at [http://localhost:15672](http://localhost:15672).
3. **Run Services:**
   - Clone this repository.
   - Build and run the microservices using Docker Compose:
     ```bash
     docker-compose up
     ```
4. **Access APIs:**
   - Use the API Gateway to access the microservices via `/api/products`, `/api/orders`, etc.

## **Use Cases**
- Demonstrates best practices for:
  - **Microservices Architecture:** Decoupled services for scalability and maintainability.
  - **Event-Driven Design:** Using RabbitMQ for asynchronous messaging.
  - **Cloud-Native Development:** Built with containerization and distributed systems in mind.

## **Future Enhancements**
- Add real-time notifications using **SignalR**.
- Implement advanced monitoring with **Prometheus** and **Jaeger**.
- Integrate Kubernetes for orchestration and scaling.
