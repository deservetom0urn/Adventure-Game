# 2D Top-Down Adventure Game — Player Mechanics Portfolio

This repository contains the foundational gameplay engineering for a 2D Top-Down Adventure game built within the Unity ecosystem. The project serves as a demonstration of my core competencies in C# scripting, vector mathematics, and Unity's component-based architecture.

### 🛠️ Technical Breakdown & Architectural Patterns

The core mechanics are driven by `PlayerController.cs`, which encapsulates the input processing and kinematic translation of the player avatar:

* **Dynamic Multi-Directional Input Mapping:** The script samples input via Unity’s `Input.GetAxis` API for both the `"Horizontal"` and `"Vertical"` orthogonal axes. This implementation ensures native, out-of-the-box compatibility with cross-platform input schemes, including standard WASD keys, Arrow keys, and hardware gamepad D-pads.
* **Frame-Rate Independence via Delta Timing:** To mitigate performance discrepancies across varying hardware specifications, player displacement is scaled using `Time.deltaTime`. This mathematical normalization guarantees that the player's velocity remains absolutely uniform, preventing gameplay anomalies whether the execution environment runs at 30 FPS or high-refresh-rate 144+ FPS.
* **State Mutation via Transform Manipulation:** The script executes a safe, atomic update pattern. It retrieves the entity's spatial data into a temporary stack-allocated `Vector2` struct, computes the velocity offsets, and explicitly commits the mutated coordinates back to Unity's `transform.position`.

### 📋 Implementation & Inspector Configuration

The script is engineered as a reusable component designed to be attached directly to any 2D Player GameObject. It exposes a serialized `moveSpeed` field (`public float`), granting developers the flexibility to calibrate and fine-tune movement physics dynamically from the Unity Inspector panel without mutating the underlying codebase.
