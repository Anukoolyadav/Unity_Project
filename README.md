🏔️ Project Title

EcoRide Challenge x Mountain Rush – 3D Off-Road Driving & Collectible Game (Unity 6)

🎮 Overview

Mountain Rush is a 3D off-road driving game built using Unity 6, where the player drives through a custom-built terrain filled with mountains, trees, roads, and collectible items. The player controls a physics-based vehicle, collects items placed across the map, and explores the environment with a smooth third-person follow camera.

This project demonstrates skills in Unity game development, C# scripting, terrain design, physics simulation, and game mechanics implementation.

🚀 Features
✔ Custom Terrain & Environment

Sculpted mountains using Unity Terrain Tools

Painted textures: grass, dirt, rock

Added trees, rocks, and environmental assets

Fully playable open-world style map

✔ Drivable Vehicle with Realistic Physics

Implemented using Ezereal Car Controller

Wheel collider physics for suspension & traction

Acceleration, braking, steering, reverse gear

Smooth and stable driving experience

✔ Dynamic Follow Camera (C# Script)

Third-person chase camera

Smooth follow using Lerp

Physics-timed updates using FixedUpdate

✔ Collectible System

Trigger-based collectibles placed across the map

Custom C# script to detect collection & destroy item

Collectibles snapped onto the road surface accurately

✔ Optimized Road System

Road created using EasyRoads3D / custom mesh

MeshCollider added for smooth driving

Fixed concave collider issues

Prevented car from getting stuck in terrain

🧩 Gameplay

Drive the truck through the mountain track

Collect scattered items placed across the terrain

Avoid falling off the edges or getting stuck

Explore the environment and complete the collection challenge

📚 Technologies Used

Unity 6 (6000.2.xx)

C# Programming

Ezereal Car Controller

Unity Terrain Tools

EasyRoads3D

URP Rendering Pipeline (optional)

Visual Studio Code / Rider

🛠️ Setup Instructions
1. Clone / Download the project

Place the project folder anywhere on your system.

2. Open with Unity 6

Make sure you have:

Unity 6 (6000.2.xx)

3. Install required packages

Terrain Tools

TextMeshPro (optional)

URP (if used)

4. Ensure correct physics setup

Electric Truck MUST have:

Rigidbody

Wheel Colliders

No Box/Sphere/Capsule Colliders on body

Road Mesh MUST have:

MeshCollider (Convex OFF)

5. Play the game

Press Play and start driving!

📜 Scripts Overview
CameraFollow.cs

Handles smooth camera tracking of the car.

Collectible.cs

Detects when the player collides with an item and removes it.

CarController (from Ezereal)

Controls physics, movement, acceleration, braking, and gear shifts.

🔧 Common Issues & Fixes
❗ Car gets stuck in the road

✔ Remove primitive colliders from car body
✔ Use non-convex MeshCollider on road

❗ Collectibles floating / falling

✔ Snap collectibles to surface
✔ Ensure road has MeshCollider
✔ Make collectibles “IsTrigger = true”

❗ Camera not following

✔ Assign correct target (Electric Truck)
✔ Only ONE active camera in the scene

✨ Future Enhancements

Add timer / score UI

Add checkpoints or laps

Add enemy AI cars

Add sound effects & VFX

Create UI menu and pause system

Improve terrain detail and lighting

👤 Author

Anukool yadav
B.Tech CSE | Unity Developer | Full-Stack Developer | AI-ML

📄 License

This project is for educational and demonstration purposes only.
