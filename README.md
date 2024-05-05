# Geometric Figures Library
## Overview
This library provides functionality to calculate the area of various geometric figures, including circles and triangles. It is designed to be extensible, allowing for easy addition of other figure types. The library also includes functionality to check if a triangle is a right triangle.
## Features
- **Calculate Area**: Calculate the area of circles and triangles.
- **Extensible**: Easily add more figure types.
- **Type Agnostic**: Create figures and calculate areas without knowing the figure type at compile-time.
- **Right Triangle Check**: Determine if a triangle is a right triangle.
## Usage
### Creating and Using Figures
To use the library, you need to create instances of figures through the FigureFactory. Here's how you can create and use figures:

```C#
// Create a circle with radius 5
IFigure circle = FigureFactory.CreateFigure("circle", 5);
Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
```

```C#
// Create a triangle with sides 3, 4, 5
IFigure triangle = FigureFactory.CreateFigure("triangle", 3, 4, 5);
Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}");
Console.WriteLine($"Is Right Triangle: {((Triangle)triangle).IsRightTriangle()}");
```
### Adding New Figure Types
To add a new figure type, implement the IFigure interface and add the new type to the FigureFactory.

## Development
### Requirements
.NET SDK
### Building the Library
To build the library, use the following command:
```shell
dotnet build
```
### Running Tests
To run the unit tests, use the following command:
```shell
dotnet test
```

# Extra task
**Products Table:**
- Columns might include ProductID, ProductName.

**Categories Table:**
- Columns might include CategoryID, CategoryName.  

**ProductCategories Table:** This is a junction table for the many-to-many relationship.
- Columns might include ProductID, CategoryID.
