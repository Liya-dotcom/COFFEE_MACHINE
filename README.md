# COFFEE_MACHINE
TJITTERS Coffee Machine
A simple C# console application that simulates a coffee ordering system for a fictional coffee shop called "TJITTERS".

Features
Allows users to select from 4 coffee sizes with different prices:

Small (R15.50)

Medium (R22.50)

Large (R35.50)

Extra-large (R43.50)

Calculates the total cost based on quantity

Supports ordering multiple coffees in one session

Basic input validation

How to Use
Clone or download the repository

Open the solution in Visual Studio or your preferred C# IDE

Build and run the program

Follow the on-screen prompts to:

Select your coffee size (1-4)

Enter the quantity you want

Decide whether to order another coffee or complete your order

Code Structure
The program uses a simple switch-case structure to handle user choices

Total cost is accumulated in the TotalCoffeeCost variable

Uses goto statements for flow control (note: this is generally not considered best practice)

Basic error handling for invalid inputs

Limitations
Prices are stored as integers (whole numbers) despite displaying decimal values

Limited error handling (will crash on non-numeric input)

Uses goto statements which can make code harder to maintain

No persistent storage of orders

No advanced features like customizations or discounts

Future Improvements
Replace goto statements with proper loops

Add more robust error handling

Implement floating-point prices for accuracy

Add more coffee options and customizations

Create a receipt system

Add support for saving order history

Requirements
.NET Framework

Visual Studio or another C# development environment (optional - can compile with command line tools)

License
This project is open source and available for anyone to use or modify.
