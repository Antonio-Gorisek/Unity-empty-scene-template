<div align='center'>
<h1>Template for Unity projects, C#</h1>
  
<h3>Template for future Unity projects, designed to make coding more efficient.</h3>
</div>

# Addons Overview

<div align='center'>
A wide variety of assets, scripts and tools have been added to support any type of Unity project. <br>
⚠️ Remember to remove any unnecessary components before publishing your product.
</div>

## Assets
This repository contains popular and free assets that speeds up creating your project!
- ### Graphy 
  <details>
    <summary>Ultimate FPS Counter - Stats Monitor & Debugger</summary>
     <br>
    
     ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/50e1180d-cd24-4552-9259-56ef72afd888)
     <h4> Main Features: </h4><ul>
      <li>FPS (Graph and Text)</li>
      <li>Memory (Graph and Text)</li>
      <li>Audio (Graph and Text)</li>
      <li>Advanced device information</li>
      <li>Debugging tools</li>
    </ul><br>
    For more information click <a href = "https://assetstore.unity.com/packages/tools/gui/graphy-ultimate-fps-counter-stats-monitor-debugger-105778">HERE</a>
  </details>
  
- ### Joystick Pack
   <details>
      <summary>Package With Multiple Virtual Joysticks</summary>
      <br>    
     
     ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/c05d69b7-1613-4702-8a56-520aa743c1bc)
      <h4> Package Content: </h4><ul>
        <li>Dynamic Joystick</li>
        <li>Fixed Joystick</li>
        <li>Floating Joystick</li>
        <li>variable Joystick</li>
       </ul><br>
      For more information click <a href = "https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631#description">HERE</a>
    </details>

- ### DOTween
  <details>
    <summary>HOTween v2 - Animating in Unity made easier</summary>
    <br>

    ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/29eb57af-14c3-466b-a8e9-c4e3f0aa11b2)
  <h4>Features:</h4><ul>
    <li>Easy animating</li>
    <li>Utility panel</li>
    <li>Efficient organization of animations</li>
    <li>Animation flow managment</li>
    <li>Safe mode</li>
    <li>...</li>
    </ul><br>
    For more information click <a href = "https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676">HERE</a>
  </details>

- ### Lean Touch
  <details>
    <summary>Quickly Add Touch Controls</summary>
    <br>

    ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/14dbb86e-1635-4cd4-aea6-abe80c21bd2a)
  <h4>Description:</h4><ul>
    <li>Touch Simulation</li>
    <li>Easy To Use</li>
    <li>Cross Platform</li>
    <li>DPI Handling</li>
    <li>Gesture Handling</li>
    <li>Long Term Support</li>
    <li>...</li>
    </ul><br>
    For more information click <a href = "https://assetstore.unity.com/packages/tools/input-management/lean-touch-30111?aid=1101l4Jks">HERE</a>
  </details>

- ### Naughty Attributes
  <details>
    <summary>Extension For The Unity Inspector</summary>
    <br>

    ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/5a4ca36e-e927-45db-86ce-9567bb7832ce)

  <br>Add more attributes to the Unity Inspector to make coding more efficient!
  <h4>Special Attributes:</h4><ul>
    <li>Animator Param</li>
    <li>Button</li>
    <li>Curve Range</li>
    <li>Dropdown</li>
    <li>Enum Flags</li>
    <li>Expandable</li>
    <li>Horizontal Line</li>
    <li>Info Box</li>
    <li>...</li>
    </ul><br>
    For more information click <a href = "https://github.com/dbrizov/NaughtyAttributes">HERE</a>
  </details>

- ### In-game Debug Console
  <details>
    <summary>See debug messages and execute commands while the app is running</summary>
    <br>

    ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/647ba3a3-28f2-408c-b6ad-ebd3c5a90208)

  For more information click <a href = "https://assetstore.unity.com/packages/tools/gui/in-game-debug-console-68068">HERE</a>
  </details>

- ### TextMeshPro
  <details>
    <summary>Ultimate Text Solution For Unity</summary>
    <br>

    Better replacement for Unity's UI Text and the legacy Text Mesh. 
    <br>
    For more information click <a href = "https://docs.unity3d.com/Manual/com.unity.textmeshpro.html">HERE</a>
  </details>

## Tools
Throughout our coding experience, we've encountered some problems and annoyances that hindered our coding process.<br>
So, we've created simple tools to make them go away!😄<br>
<br>
- Most of them you can find in `Tools` window in Unity:
  - **Refresh script:** force refresh all scripts contained in the `Scripts` folder
  -  **Missing Scripts/Delete:** deletes all instances of removed scripts in the hierarchy
<br>

- Some tools are contained in the `Editor` folder. <br>
  ![image](https://github.com/IndigoGameStudio/Template/assets/73490593/84e50413-4862-4af2-bcb9-aecf636dfffe)
  - **Custom Code:** adds custom templates for different types of classes and objects
    - Static Class, Abstract Class, Interface and Struct Class
    - Scriptable Object

## Scripts
We've gathered frequently used code in `Scripts` folder in a carefully categorized manner. <br>
Besides offering ready-made scripts, it also suggests ways to systematically store new ones.<br>
<br>
These scripts include:
  - **TouchInput:** implements simple touch gestures
  - **WindowManager:** mobile apps in mind, provides methods for creating and managing windows
  - **User:** template for storing and loading future user data
    - **UserData:** enum for a variety of data that could be stored (ex. settings data)
  - **PlayerMovement:** simple object movement methods for both 2D and 3D
  - **QuickSort:** implementation of the famous Quick Sort algorithm
  - **SensorReader:** script that gets information about sensors in the phone
    -   Gyroscope data
    -   Accelometer data
    -   Altitude Sensor data
    -   Gravity Sensor data
  - **WheelRotation:** used for rotation of object based on pointer data (ex. rotating a wheel)
  - **Singleton:** objects that inherit this class become Singleton objects
  - **AudioManager:** provides simple methods for implementing audio effects
  - **Crypto:** makes encrypting/decrypting data much more efficient
  - **GetObject:** shortcuts for getting children of specific objects
  - **Load/Save:** load and save data using JSON
  - **Log:** custom log system that provides more colors, messages and printing out complex objects with ease
  - **PlayerPrefs:** blocks Unity from using PlayerPrefs
  - **SettingsManager:** template for project's settings management
  - **WebRequest:** implements Post and Get methods







