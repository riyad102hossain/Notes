### Asynchronous Programming

<details>
  <summary>What is Asynchronous Programming?</summary>
  Asynchronous programming is a way of writing code that allows multiple tasks to run independently without blocking the main program, making it responsive and efficient, especially for time-consuming operations. 
</details>
<details>
 <summary>async</summary> 
  Marks a method as asynchronous. When you declare a method with async, it can contain await expressions and run without blocking the main thread.
</details>
<details>
   <summary>await</summary>
   Pauses the execution of an async method until the awaited task is complete. This allows other tasks to continue running without blocking.
</details>

### Thread

<details>
  A thread is a unit of a program that can execute independently, allowing multiple tasks to run together.
</details>

# N-Tier Architecture

**N-tier architecture** is a software design pattern where an application is divided into multiple tiers. Each tier performs a specific responsibility and interacts with other layers.

## Layers of N-Tier Architecture

### 1. Presentation Tier (UI Layer)
  Directly interacts with the user.  
  Displays data and accepts user input.  

### 2. Application Tier (Business Logic Layer) 
  Stores and executes business rules and logic.  
  Acts as a mediator between the Presentation Tier and Data Tier.  

### 3. Data Tier (Database Layer)
  Stores and retrieves data.  
  Handles database operations.  


