# Shapes Area Calculator Program

## Overview

This C# program demonstrates the power of polymorphism by calculating areas of different geometric shapes (squares, rectangles, and circles) in a clean, object-oriented way. The program showcases how different shape objects can be treated uniformly through their common base class while maintaining their unique area calculation behaviors.

## Key Features

- **Polymorphism in Action**: Different shapes calculate their areas differently, but all respond to the same `GetArea()` method call
- **Clean Architecture**: Separate classes for each shape type following SOLID principles
- **Professional Output**: Well-formatted display showing shape type, color, and calculated area
- **Easy Extension**: Simple to add new shape types without modifying existing code

## How It Works

The program consists of:

1. **Base `Shape` class** (abstract)
   - Contains common properties (color)
   - Declares abstract `GetArea()` method

2. **Concrete shape classes** (all inherit from `Shape`):
   - `Square`: Calculates area as side²
   - `Rectangle`: Calculates area as length × width
   - `Circle`: Calculates area as π × radius²

3. **Main Program**:
   - Creates a collection of different shapes
   - Demonstrates polymorphism by treating all shapes uniformly
   - Displays each shape's type, color, and calculated area

## How to Run the Program

### Prerequisites
- .NET SDK (8.0 or later) installed
- Code editor or IDE (Visual Studio, VS Code, etc.)

### Execution Steps

1. **Create the project**:
   ```bash
   dotnet new console -n ShapesCalculator
   cd ShapesCalculator

2. **Add the class files:**

    Create/overwrite the files with the provided code:

    -Shape.cs

    -Square.cs

    -Rectangle.cs

    -Circle.cs

    -Program.cs

3. Run the program:

    dotnet run

4. Expected Output:

    Shapes Area Calculator

    Shape Collection:
    -----------------
    Square     | Color: Red     | Area: 25
    Rectangle  | Color: Blue    | Area: 24
    Circle     | Color: Green   | Area: 28.27
    Square     | Color: Yellow  | Area: 6.25
    Rectangle  | Color: Purple  | Area: 9


#### Learning Points

**This program demonstrates:**

- Polymorphism: Different objects responding to the same method call in different ways

- Inheritance: Shared behavior through the base Shape class

- Abstraction: Using abstract methods to enforce implementation contracts

- Clean Code: Well-organized, single-responsibility classes

