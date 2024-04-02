# UnityDemos

This repository is a collection of various demo projects for Unity that I made, aimed to be easy-to-understand examples of various functionalites in Unity, with scripts that can be taken and used off-the-shelf. Forked from my ![Old Github Account](https://github.com/JamesG321)


## Rigid Body Demolition
![Demolition](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/Demolition.png)
This demo uses the built-in rigid body physics of Unity to create explosions that interact with rigid bodies. Comes with an interactive demo where you can place explosives and detonate them on a rigidbody 'jenga' tower.

Complete with adjustable explosion power and radius:
![Day night cycle Variables](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/DemolitionVariables.png)

To use it in your own project, use [explode.cs](https://github.com/JamesG4321/UnityDemos/blob/master/Demolition/Assets/Scripts/explode.cs) to your 'explosion' and adjust the detonate key/condition as needed.

#### Controls: 
Space - Explode!

Left Click - Place explosive

R - Reset tower


## Click and drag demo
![Click and drag thumbnail](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/click%20and%20drag%20thumbnail.png)
This is a demo for a click and drag script that allows the user to pick up and move/drag around an object using thier mouse. Release velocity is also calculated based on how fast the user drags the object before letting go of the click. This allows the user to 'throw' around the object as well. 

To use it in your own project, simply attach [DragObject.cs](https://github.com/JamesG4321/UnityDemos/blob/master/Click%20and%20drag%20demo/Assets/Scripts/DragObject.cs) to a rigid body.


### Models used: [Farm Animals Set by Vertex Cat](https://assetstore.unity.com/packages/3d/farm-animals-set-97945)

## Day night cycle script
![Day night cycle tumbnail](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20thumbnail.png)
This demo is a simple day night cycle system using a diretional light and achieveing the effect of sunlight changing throughout the day by changing the intensity and rotation of the light. 

Complete with adjustable day length and time of day:
![Day night cycle Variables](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/DayNightCycle%20inspector%20variables.PNG)

To use it in your own project, attach [SetSunlight.cs](https://github.com/JamesG4321/UnityDemos/blob/master/DayNightCycle/Assets/Scripts/SetSunlight.cs) to your project and add a directional light as the sun into the public variable.


### Models used: 

#### Tent and campfire: [LowPolySurvivalEssentials demo by BrokenVector](https://brokenvector.itch.io/ultimate-low-poly-survival)
#### Low poly tree: [Low poly tree by kotzuo](https://sketchfab.com/3d-models/low-poly-tree-6d986e0b24b54d85a5354e5cac6207a1)
#### Moon texture: [solarSystemscope.com](https://www.solarsystemscope.com/textures/)

## Rigidbody toaster demo
![Rigidbody toaster thumbnail](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/toaster%20thumbnail.PNG)
This demo shows the usage of rigid body physics and box colliders with a toaster that ejects toast at high speed and bounces around a confined space colliding with the walls and toast. Complete with adjustable eject force and toast spawn points: ![toaster variables](https://github.com/JamesG4321/UnityDemos/blob/master/Images%20for%20documents/rigidbody%20toaster%20inspector%20variables.PNG)

The demo was built to be a prototype/proof of concept segment for the [codavore](https://codavore.blogspot.com/) game, where the toaster is the first malfunction that the player would experince in their spaceship.

#### Controls: 
Space - eject toast on both sides

G & H - eject toast on left/right side

C - switch between overview/toaster cam

R - reset

### Models used: [toaster by idealton, remixed and sperated by me](https://sketchfab.com/3d-models/toaster-888f15c535bd4eeea3934e235370941d)


