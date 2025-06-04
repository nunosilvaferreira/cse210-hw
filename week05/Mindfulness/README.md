# Mindfulness Program - CSE 210 Assignment

## Overview
This program provides guided mindfulness activities to help users reduce stress and increase focus. It includes three core activities (Breathing, Reflection, and Listing) plus a bonus Gratitude Journaling activity.

## Program Structure
The program follows an object-oriented design with inheritance:

Activity (Base Class)
├── BreathingActivity
├── ReflectingActivity
├── ListingActivity
└── GratitudeActivity (Bonus)


## Class Responsibilities

### 1. Activity (Base Class)
- **Attributes**:
  - `_name`: Activity name
  - `_description`: Activity description
  - `_duration`: Session duration in seconds
- **Methods**:
  - `DisplayStartingMessage()`: Shows welcome message and sets duration
  - `DisplayEndingMessage()`: Shows completion message
  - `ShowSpinner(seconds)`: Displays spinning animation
  - `ShowCountDown(seconds)`: Displays countdown timer

### 2. BreathingActivity
- Guides user through deep breathing exercises
- Alternates between "Breathe in..." and "Breathe out..." prompts
- Uses countdown timers for breathing intervals

### 3. ReflectingActivity
- Helps users reflect on meaningful experiences
- Provides random prompts and follow-up questions
- Shows spinner during reflection periods

### 4. ListingActivity
- Guides users to list positive aspects of their life
- Counts and displays number of items listed
- Provides random prompts to focus listing

### 5. GratitudeActivity (Bonus)
- Additional activity for gratitude journaling
- Provides prompts for positive reflection
- Saves and displays user entries

## Key Design Principles

1. **Inheritance**:
   - All activities inherit common functionality from base Activity class
   - Eliminates code duplication for shared features

2. **Encapsulation**:
   - Member variables are private/protected
   - Methods provide controlled access to functionality

3. **Abstraction**:
   - Base class handles common implementation details
   - Derived classes implement activity-specific behavior

## Creativity and Exceeding Requirements

1. **Added Fourth Activity**:
   - Gratitude Journaling activity provides additional mindfulness option

2. **Activity Logging**:
   - Tracks usage statistics for each activity type
   - Users can view their activity history

3. **Enhanced User Experience**:
   - Color-coded console output for better readability
   - Improved prompt selection algorithm prevents repetition

4. **Additional Features**:
   - Menu system with clear navigation
   - Persistent activity tracking across sessions

## How to Use

1. Run the program from the command line
2. Select an activity from the menu (1-4)
3. Follow the on-screen instructions
4. View your activity log (Option 5) to track progress
5. Quit when finished (Option 6)

## Development Notes

The program was designed according to the team activity specifications, with special attention to:
- Proper class hierarchy and inheritance
- Encapsulation of member data
- Reusable base class functionality
- Clean, consistent code style