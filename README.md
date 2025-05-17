# 🎯 Modular Ability System – Unity Asset

## 📦 Overview

The **Modular Ability System** is a flexible and extensible Unity package for adding reusable character abilities like **Dash**, **Heal**, and **Fireball**, with support for **cooldowns**, **mana cost**, and **damage handling**. Ideal for RPGs, action games, and any game needing scalable skill systems.

---

## 📁 Folder Structure

```
ModularAbilitySystem/
│
├── Documentation/
│   └── README.md (this file)
│
├── Prefabs/
│   └── Fireball.prefab
│
├── Scenes/
│   └── DemoScene.unity
│
├── Scripts/
│   ├── Abilities/
│   │   ├── DashAbility.cs
│   │   ├── HealAbility.cs
│   │   └── FireballAbility.cs
│   │
│   ├── Components/
│   │   ├── PlayerHealth.cs
│   │   ├── PlayerMana.cs
│   │   └── FireballMover.cs
│   │
│   ├── Core/
│   │   └── AbilityManager.cs
│   │
│   └── Interfaces/
│       ├── IAbility.cs
│       └── IDamageable.cs
```

---

## 🚀 Features

- 🔌 **Plug-and-Play Abilities** – Drag-and-drop architecture using interfaces and Unity components
- ⏱️ **Cooldown & Mana Cost** per ability
- 🔥 **Projectile Logic (Fireball)** with runtime damage injection
- 💙 **Health and Mana Management** components included
- 🖱️ **Mouse Input Support** – Fire abilities using left-click via `AbilityManager`
- 📜 Fully documented and easy to extend

---

## 🎮 Setup Instructions

1. Open the `DemoScene.unity` in the `Scenes/` folder.
2. Select the `Player` GameObject.
3. The following scripts are already attached:
   - `AbilityManager`
   - `DashAbility`, `HealAbility`, `FireballAbility`
   - `PlayerHealth`, `PlayerMana`
4. In the Inspector:
   - Add abilities to the `AbilityManager → Ability Components` list
   - Assign the `Fireball.prefab` to `FireballAbility → fireballPrefab`

---

## 🎯 Usage Guide

### Keyboard & Mouse Input:

| Key        | Ability                         |
| ---------- | ------------------------------- |
| Q          | Dash                            |
| E          | Heal                            |
| Left Click | Fireball (via `AbilityManager`) |

---

## 🧱 Script Summary

### 🔹 Interfaces

- **`IAbility`** – Base interface for all abilities
- **`IDamageable`** – Used to apply damage to any compatible GameObject

### 🔹 Core

- **`AbilityManager`** – Manages and activates assigned abilities, including mouse input

### 🔹 Abilities

- **`DashAbility`** – Moves player forward with cooldown
- **`HealAbility`** – Heals character's health
- **`FireballAbility`** – Spawns a projectile with runtime-configurable damage

### 🔹 Components

- **`PlayerHealth`** – Tracks current and max HP
- **`PlayerMana`** – Tracks and validates mana for ability usage
- **`FireballMover`** – Controls projectile movement, damage, and impact

---

## 🔄 How to Add New Abilities

1. Create a new script in `Scripts/Abilities/`
2. Inherit from `MonoBehaviour` and implement `IAbility`
3. Attach it to your player or character GameObject
4. Add it to the `AbilityManager` list

```csharp
public class MyNewAbility : MonoBehaviour, IAbility
{
    public string AbilityName => "My Ability";

    public void Activate(GameObject user)
    {
        // Custom ability logic
    }
}
```

---

## 🔧 Requirements

- Unity 2021.3 or newer
- Rigidbody required for projectile prefabs
- Demo scene uses Unity’s built-in Input System

---

## 📋 Limitations

- Not multiplayer-ready out of the box
- No built-in UI (cooldowns, health bars, etc.)
- Requires manual setup via Inspector

---

## 🔐 License

MIT License

---

## 🧾 Changelog

### v1.0.0

- Initial release
- Dash, Heal, and Fireball abilities
- Mana and cooldown logic
- Fireball collision and damage
- Basic input and demo scene

---

## 📧 Support

For bug reports, feature requests, or help using the package, contact [your-email@example.com] or visit the asset page.
