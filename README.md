[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- UI
  - Number of seeds planted
  - Number of seeds remaining
- Player
  - Eight-directional movement
  - Can plant seeds anywhere
- Plants
  - Added upon the player pressing space
  - Adds one seed planted in the UI
  - Removes one seed remaining in the UI

## Devlog
Some of the features I listed may be worded differently from the professor's plan, but I don't believe that I am missing any other features. Also, I treated both the attributes and actions of each listed object as the same, but I've attempted to keep them separate by listing the attributes above and the actions below. Utilizing the plan and its proper mods, I got to work with implementing these features. As I looked into the Instantiate method in its documentation, I used the method that takes the position into account, but I noticed another required parameter that I've never heard of (even in my experience with Godot), which is a Quaternion. But after a glance at its documentation, I concluded that it involves an object's rotation, so I went with a default Quaternion constructor (which I assumed exists) to indicate no rotation to the plant.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Unfortunately, I cannot give this Devlog full credit because it doesn't quite connect the break-down to the code that you wrote. You talked about the Instantiate method in the code, but didn't describe which object, attribute, or action from your break-down that it was related to. You could have, for example, described how you used Instantiate to make your Plant prefab appear in the Scene in order to implement the action that the Player object has to plant seeds.

Thank you for formatting your break-down list correctly. :) You can also remove the prompts, which makes it easier for me to read your Devlog.
