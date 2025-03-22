# Convergence


# Convergence Application — Army Builder System

This set of scripts powers the core of the **Convergence Application**, a utility designed to support tabletop war games. It focuses on building armies from card-based units, managing points, and interacting with card data through a clean UI.

##  What It Does
- Lets players build armies by selecting and managing cards
- Tracks army composition and total point cost
- Displays card stats, names, and artwork
- Provides UI navigation through multiple tabs
- Allows players to add/remove cards, view stat blocks, and switch army builds

## System Breakdown

### `ArmyManagement.cs`
- Handles the main logic for updating the army panel UI
- Displays card buttons, names, point totals, and updates based on user actions
- Loads stat block images when buttons are pressed

### `CardLibraryManager.cs`
- Central controller for all armies and UI panels
- Manages army lists, point tracking, and connection between components
- Supports three different army lists (armyList0, armyList1, armyList2)

### `Card.cs`
- Handles interaction from the individual card buttons
- Updates UI elements (cost, name, image)
- Triggers logic to add a card to the correct army

### `CardSO.cs`
- ScriptableObject storing card data: name, cost, image, GameObject reference
- Used to instantiate and reference consistent card values across the app

### `CanvasTabManager.cs`
- Controls tabbed UI navigation
- Allows users to flip between inventory, deck, or different panels

## 🧪 Features
- Multiple armies supported (expandable)
- Card preview and stat block generation
- Add/remove logic tied to buttons
- Supports future UI refactoring (modular structure)
- Built for expansion into full deck-building or compendium systems

## 🛠️ Built With
- Unity (2021+)
- C#
- UnityEngine.UI
- ScriptableObjects

## 📦 Use Case
This is a key part of the **Convergence App** used by Dungeons & Vanners Studios to manage complex tabletop war game data. The goal is to provide players with a smooth and intuitive way to build and manage their armies from an expanding pool of cards.
