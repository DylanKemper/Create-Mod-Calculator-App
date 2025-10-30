# Create Mod Calculator App
### Independent Project — Windows Forms Application
**Developer:** Dylan Kemper  
**Date:** 30 October 2025  
**IDE:** Visual Studio Community  
**Language:** C# (.NET 8.0, Windows Forms)

## Overview
The **Create Mod Calculator App** is a desktop utility designed for players of the Minecraft Create Mod. It allows users to calculate processing rates, required speeds (RPM), and production efficiency for various Create Mod machines such as the Mechanical Press and Crushing Wheels.
This application helps automate complex calculations from the mod’s internal processing equations, providing accurate and instantaneous conversions between machine RPM and item throughput (Items Per Second).

The project demonstrates practical use of **object-oriented design, mathematical modeling,** and **event-driven programming** in a Windows Forms environment.

## Project Objectives

- Apply **object-oriented programming (OOP)** principles to model Create Mod machines.
- Implement a **modular architecture** that supports multiple machine types with unique behaviors.
- Provide a **user-friendly interface** for real-time calculation and result visualization.
- Allow users to input any known variable (e.g., RPM or Items/sec) and compute the missing one automatically.
- Ensure the system is easily **extendable** for future machines and formulas.

## Features and Functionality
### 1. Dynamic Machine Selection
- Choose a machine (e.g., Mechanical Press, Crushing Wheels) from a dropdown menu.
- The interface updates according to the selected machine’s available variables.

### 2. Bi-Directional Calculation
- Enter RPM → App calculates Items per Second.
- Enter Items per Second → App calculates RPM using numerical methods (Brent’s or Newton-Raphson).
- Automatic recalculation occurs when a field changes, eliminating the need for manual button input.

### 3. Modular Machine Architecture
- Each machine is defined as a separate class implementing a shared interface (IMachine).
- Machines define their own calculation logic and equations, allowing for independent maintenance and scalability.

### 4. Root-Finding Algorithms
- Implements Brent’s Method and Newton-Raphson for solving nonlinear machine equations.
- Ensures fast and stable convergence for all supported variable types.

### 5. Input Validation
- Automatic numeric validation for all input fields.
- Graceful error handling for invalid or missing data (displays default or zero values instead of crashing).

## System Architecture
| Namespace | Purpose |
|------------|----------|
| `IMachine (Interface)` | Defines required methods (e.g., Solve, Calculate) that all machines must implement. |
| `MachineBase (Abstract Class)` | Provides shared logic or default behaviors (e.g., clamping, validation). |
| `MechanicalPress, CrushingWheels, etc.` | Child classes that contain specific formulas and logic for each machine. |
| `MainForm` | The WinForms user interface that handles user interaction and triggers calculations. |

## OOP Concepts Demonstrated
- **Encapsulation**: Each machine class contains its own data and solving logic.
- **Abstraction**: Complex equations are hidden behind a simple interface (IMachine).
- **Polymorphism**: Each machine implements its own calculation while sharing a common interface.
- **Extensibility**: New machines can be added by simply creating new classes and registering them in the form.

## Author
Dylan Kemper

## License
This project was developed for educational and fan-use purposes only.
All rights reserved © 2025 Dylan Kemper.
This project is not affiliated with Mojang or the Create Mod development team.
