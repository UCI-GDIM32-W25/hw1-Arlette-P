[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

So that the format does not become confusing, I will link the google doc instead of typing it out again.
https://docs.google.com/document/d/1dO-rPqi41AWmFPItY63uYNZYioqZBUl5RPTv4V-2Hxc/edit?usp=sharing 

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Write your Devlog here!

My project breakdown turned out fairly different, mostly due to it not being as detailed as the answers that Proffessor Reid gave. For example, for "player" I had "movement" and "calls upon the plant prefab and brings the plant into the environment" only and was missing the sprite appearence, how was movement achieved and planting seeds action. I also had placed the attributes relating to planting seeds under "the plants" instead of "player" while also missing what appearence the plant sprites took.

In my code, for movememnt, I used if statements along with Input.GetKey(KeyCode) and _playerTransform.Translate to allow the player to move in all directions accross the screen This relates to how under movement, it states that the player sprite will move in all directions using WASD. I also used if statements to plant the plants. First I used if(_numSeeds > 0) to make sure that once _numSeeds reached 0, the code will stop running. I then used another if statement with Input.GetKeyDown(KeyCode.Space). I used GetKeyDown instead of just GetKey as GetKey would spawn a plant for every frame the space was pressed instead of just once per press. Inside of this if statement, I used Instantiate to call upon _plantPrefab and summon it to where the player currently is.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
- [Pixel Adventure 1] (https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360) - Plant sprite
- [Simple 2D Platformer Assets Pack] (https://assetstore.unity.com/packages/2d/characters/simple-2d-platformer-assets-pack-188518) - Player Sprite
