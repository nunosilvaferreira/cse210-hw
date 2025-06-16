# Exercise Tracking Program

This program demonstrates the principles of inheritance and polymorphism in C# by modeling different types of exercise activities.

## Program Description

The program tracks three types of fitness activities:
- Running (tracks distance)
- Cycling (tracks speed)
- Swimming (tracks laps)

For each activity, it calculates and displays:
- Distance (in miles)
- Speed (in mph)
- Pace (minutes per mile)
- A summary combining all information

## Design Principles

1. **Abstraction**: Created abstract base class `Activity` with derived classes for each activity type.
2. **Encapsulation**: All member variables are private, with protected access where needed.
3. **Inheritance**: Common attributes (date, minutes) are defined in the base class.
4. **Polymorphism**: 
   - Method overriding for distance, speed, and pace calculations
   - Virtual `GetSummary` method in base class that uses other polymorphic methods
5. **Proper Organization**: Each class in its own file with matching names.

## How to Run

1. Clone the repository or copy all files into a C# project
2. Compile and run the program
3. The program will output summaries for three sample activities:
   - A 30-minute run covering 3.0 miles
   - A 30-minute cycling activity at 9.7 mph
   - A 30-minute swimming session with 20 laps

## Expected Output

03 Nov 2023 Running (30 min): Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2023 Cycling (30 min): Distance 4.8 miles, Speed 9.7 mph, Pace: 6.2 min per mile
03 Nov 2023 Swimming (30 min): Distance 0.6 miles, Speed 1.2 mph, Pace: 48.4 min per mile


## Math Formulas

The program uses these calculations:
    - Swimming distance: laps × 50 meters ÷ 1000 × 0.62 (to miles)
    - Speed: (distance / minutes) × 60
    - Pace: minutes / distance

