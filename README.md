[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

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
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

-------

Some of the features I listed may be worded differently from the professor's plan, but I don't believe that I am missing any other features. Also, I treated both the attributes and actions of each listed object as the same, but I've attempted to keep them separate by listing the attributes above and the actions below. Utilizing the plan and its proper mods, I got to work with implementing these features. As I looked into the Instantiate method in its documentation, I used the method that takes the position into account, but I noticed another required parameter that I've never heard of (even in my experience with Godot), which is a Quaternion. But I've been able to correctly assume that it involves an object's rotation, so I went with a default Quaternion constructor to indicate no rotation to the plant.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
