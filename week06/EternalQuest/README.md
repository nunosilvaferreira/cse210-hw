# Eternal Quest Program

This program helps users track different types of goals with gamification elements to encourage progress and achievement.

## Features

1. **Three Goal Types**:
   - **Simple Goals**: One-time goals that can be marked complete (e.g., run a marathon)
   - **Eternal Goals**: Never-ending goals that give points each time (e.g., scripture study)
   - **Checklist Goals**: Goals requiring multiple completions with a bonus (e.g., attend temple 10 times)

2. **Score Tracking**: The program keeps track of points earned from completing goals.

3. **Persistence**: Goals and scores can be saved to and loaded from files.

4. **User Interface**: Simple menu-driven interface for easy interaction.

## How to Run

1. Make sure you have .NET Core installed on your system.
2. Clone or download the repository.
3. Navigate to the project directory in your terminal.
4. Run the program with: `dotnet run`

## Key Concepts Demonstrated

This program demonstrates several key object-oriented programming concepts:

1. **Polymorphism**:
   - The `Goal` base class defines abstract methods that each derived goal type implements differently.
   - The `GoalManager` treats all goals uniformly through the base class interface.

2. **Inheritance**:
   - `SimpleGoal`, `EternalGoal`, and `ChecklistGoal` all inherit from the `Goal` base class.
   - Shared attributes and behaviors are defined in the base class.

3. **Encapsulation**:
   - All member variables are private, with public methods providing controlled access.
   - Each class is responsible for its own data and behavior.

4. **Abstraction**:
   - The `Goal` class provides a clear abstraction for what a goal should do without specifying implementation details.
   - Each derived class provides concrete implementations of the abstract methods.

## Exceeding Requirements

To exceed requirements, I've implemented:
1. A comprehensive scoring system that tracks points across all goal types.
2. Detailed goal status displays showing completion state and progress.
3. Robust file saving/loading functionality that preserves all goal data.
4. Clear user feedback throughout the program's operation.

## Example Usage

1. Create a new goal (select type, enter name, description, and points)
2. Record events when you complete goals
3. View your list of goals and current score
4. Save your progress to a file
5. Later, load your saved goals to continue tracking