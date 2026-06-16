# 2D Adventure Game

This is a simple 2D adventure game built in Unity. I created this project to practice player movement, user input, and C# scripting while learning how Unity's component system works.

## 🛠️ What I Built

The main gameplay is controlled by the `PlayerController.cs` script.

### Player Movement

* Allows the player to move in four directions using the keyboard (WASD or Arrow Keys).
* Uses Unity's `Input.GetAxis()` to detect player input.
* Supports smooth movement that feels responsive during gameplay.

### Consistent Movement Speed

* Uses `Time.deltaTime` so the player's movement stays the same on different devices and frame rates.
* This keeps the gameplay smooth whether the game is running at a low or high FPS.

### Position Updates

* Updates the player's position every frame based on the movement input.
* Uses Unity's `transform.position` to move the character around the map.

## 📋 Features

* Built with **Unity** and **C#**
* Four-direction player movement
* Frame rate independent movement using `Time.deltaTime`
* Adjustable movement speed through the Unity Inspector using the `moveSpeed` variable
