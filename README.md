"# Game-Store" 
Project Description
The project is a simple console-based game store application that allows users to select and purchase games for different gaming platforms. 
The current implementation focuses on the PS5 platform, but it is designed with extensibility in mind to potentially support other platforms like the Switch in the future.

Upon launching the application, users are presented with a menu where they can choose a console game system (currently only PS5 is supported). 
Once the PS5 option is selected, users are greeted with the PS5 Game Store menu, listing available games along with their prices and stock levels.
Users can then select a game to purchase, provided it is in stock.

After selecting a game, users are prompted to make a payment using $10, $5, and $1 bills/coins. 
The application calculates the total payment and determines if any change is due. 
The payment and change processes are handled in a user-friendly manner, guiding the user through each step.

The application utilizes Object-Oriented Programming (OOP) principles to organize and structure the code.
It employs inheritance, encapsulation, and polymorphism to create a modular and maintainable codebase.
The core classes involved in the application are Platform, PS5, and Game, each serving a specific role:

Platform: An abstract base class that defines the common properties and methods for different gaming platforms.

PS5: A derived class from Platform that implements platform-specific functionalities and manages the list of available games.

Game: A class representing individual games with properties like name, price, and stock units.
