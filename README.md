# 🧩 Console Management Project - C#

This repository contains a series of exercises developed in **C#**, focused on **Object-Oriented Programming (OOP)**, **SOLID principles**, **JSON persistence**, and the **MVC architecture** for console applications.

---

# 📚 Project Contents

## 🧠 1. OOP Fundamentals - Citizen
**Narrative:** A municipality requires a system to manage its citizens.

- `Citizen` class with:
  - `FullName` (string)
  - `DNI` (string)
  - `Age` (int)
  - `Greet()` method: returns a custom greeting with name and age
  - `IsAdult()` method: returns `true` if age ≥ 18
  - Validation: age cannot be negative

🎯 *Goal: practice encapsulation, properties, constructors, and basic logic.*

---

## 🐾 2. Inheritance and Polymorphism - Veterinary
**Narrative:** System to register animals for a veterinary clinic.

- Base class `Animal` with virtual method `MakeSound()`
- Derived classes:
  - `Dog` → `"Woof!"`
  - `Cat` → `"Meow!"`
- `Introduce()` method: returns `"I am a cat named Luna and I go Meow!"`

🎯 *Goal: practice inheritance, polymorphism, and method overriding.*

---

## 📐 3. SOLID Principles - Invoice Refactoring
**Narrative:** A legacy system handles everything in a single class.

- Applied SRP (Single Responsibility Principle):
  - `InvoiceCalculator`
  - `InvoicePrinter`
  - `InvoiceSaver`
- Applied ISP (Interface Segregation Principle):
  - `IPrintable` interface
  - Separate implementations for paper and digital printing

🎯 *Goal: apply responsibility separation and good design practices.*

---

## 🛠️ 4. CRUD + JSON + Repository - Hardware Store
**Narrative:** Console system for managing hardware store products.

- `Product` class: `Id`, `Name`, `Price`, `Stock`
- Full CRUD:
  - Create, Read, Update, Delete
- `ProductRepository` class:
  - Persistence in `products.json`
  - Automatic serialization and deserialization

🎯 *Goal: manage files, collections, and logic separation.*

---

## 📖 5. Final Project - Library (MVC)
**Narrative:** A community library requests a system to register books and manage loans.

- **Models**:
  - `Book`: title, author, ISBN, availability
  - `User`: name, email
  - `Loan`: book, user, date
- **Controllers**:
  - Handles books and users
  - Manages loans and returns
- **Views**:
  - Interactive console menu with styled output

🎯 *Goal: apply MVC, persistence, input validation, and clean design.*

---

## ✍️ Author
Tomas Llera
Educational project - OOP and Console Architecture in C#
