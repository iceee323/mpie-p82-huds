# Practical 9: Adventure Game Head-Up Display

In this practical, you are going to further extend the adventure game scene you've been working on by adding a HUD and GUI.

By the end of this practical you will be able to:

- Create a HUD using a Canvas Game Object
- Add and correctly position UI Elements on a Canvas
- Use scripts to manipulate UI Elements on a HUD, in response to events in the scene
- Create interactive menus that manipulate the parameters of Game Objects

To get started, open up your adventure game with sound from last week. If you've used your third person character in your game with sound, you might want to switch back to using an first person controller for today.

## Task 1: A Better Crosshair
The point at which the player’s gun is pointing is currently displayed using a small sphere, which floats in space in the player’s field of view. This doesn’t look particularly good. In this task, you should replace this red dot with a HUD that shows a cross hair icon, which you have downloaded from the Internet. Here are some tips for completing this task:

- Download a crosshair image with a transparent background
- Unity imports image assets as textures, while the UI system shows images as sprites. You will, therefore, need to change the “Texture Type” of the image you’ve imported to “Sprite (2D and UI) before it can be added to the canvas.
- When you have correctly added your new crosshair, remove the red dot by deleting the RedDotCrosshair GameObject from the hierarchy

To help the player understand that they need to find some ammo at the start of the level, you may wish to ‘grey out’ the crosshair when the gun is empty. This can be done by manipulating the alpha value of the UI Image’s colour parameter from a script.

## Task 2: An Ammo Display
Recall that finding ammunition for the player’s gun is an important part of completing the scene. In its current form, the game provides the user with no visual indication that they have no ammo at the start of the scene. In this task, you should rectify this problem by creating a HUD that shows the user how much ammo they have. Your HUD should satisfy the following requirements:

- A number should be displayed on the HUD, which indicates the current ammo level
- A small icon (e.g. some bullets) should be shown next to this number to indicate that the number represents the ammo level

## Task 3: Helpful Hints
To help the player complete the scene, you should show the following text hints on the HUD:

- If the player hasn’t found the ammo after 30 seconds, display the hint “I wonder if there’s any ammo in that shack?”
- If the player has collected the ammo, but hasn’t walked up the path after 30 seconds, display the hint “I wonder what’s up that path?”
- If the player has reached the bridge, but hasn’t hit the target to open it after 30 seconds, display the hint “I wonder what would happen if I shot that target on the bridge?”

## Task 4: An Interactive Menu
To complete today’s practical, you should create an interactive menu for the scene. This menu should be shown over the top of the scene when the game loads. The menu should have the following functionality:

- A “Play Game” button that makes the menu disappear when clicked
- A “Difficulty” slider that allows the player to configure the length of the delay before the text hints are shown (when the difficulty is set to max, no hints should be shown).
- A “Crosshair Size” slider that allows the player to vary the size of the crosshair

When implementing this functionality, you should experiment with using both scripts and the UI Actions functionality in the inspector. You may also wish to disable the character’s controls when the menu is displayed on the screen. One way to do this might be to disable the “First Person Controller” script on the “FPSController” game object while the menu is on view.

## Optional Extensions
If you complete all of the above tasks before the end of the practical, or would like to continue to develop your skills in your free study time, then you should consider attempting the following tasks:

- Use a second camera to add a Minimap to your HUD (see https://youtu.be/ZuV9Xlt-l6g) 
- Create a “speech bubble” next to the radio in the shack, which displays the mayday message being broadcast. To do this, you should use a Canvas that’s configured in “World Space” mode (see http://blogs.unity3d.com/2014/06/30/unity-4-6-new-ui-world-space-canvas/)
- Create a “game over” HUD, which is shown if the player falls into the valley below the bridge. This HUD should be shown for 3 seconds, before reloading the scene (see http://answers.unity3d.com/questions/198878/restart-current-level.html)

