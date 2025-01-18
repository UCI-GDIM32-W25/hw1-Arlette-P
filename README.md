[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects
- The UI
  - Seeds planted UI
    - Counts up, up to how many you start with in “Seeds remaining UI” (in this case, 5) (WHen player plata  a seed)
    - Attributes: text
  - Seeds remaining UI
    - Counts down, to zero (when player plats a seed)
- The player
  - Attributes 
    - Bunny sprite 
  - Movement 
    - INPUT: WASD
    - Output: player changes direction 
  - Planting seeds:
    - Input: press space
    - Output: seed is planted @player location; decrease seed count + increase plant count (shows up in UI); player has to have seeds left in order to plant 
  - Calls upon the plant prefab and brings the plant into the environment
- The plants
  - Attributes 
    - Plant sprite

Note: I was missing quite a lot of information. I now know exactly what to write down an dhow specific I should be. For the plats I also added a lot more information that would have been answered in the player section.

## Devlog
My project breakdown turned out fairly different, mostly due to it not being as detailed as the answers that Proffessor Reid gave. For example, for "player" I had "movement" and "calls upon the plant prefab and brings the plant into the environment" only and was missing the sprite appearence, how was movement achieved and planting seeds action. I also had placed the attributes relating to planting seeds under "the plants" instead of "player" while also missing what appearence the plant sprites took.

In my code, for movememnt, I used if statements along with Input.GetKey(KeyCode) and _playerTransform.Translate to allow the player to move in all directions accross the screen This relates to how under movement, it states that the player sprite will move in all directions using WASD. I also used if statements to plant the plants. First I used if(_numSeeds > 0) to make sure that once _numSeeds reached 0, the code will stop running. I then used another if statement with Input.GetKeyDown(KeyCode.Space). I used GetKeyDown instead of just GetKey as GetKey would spawn a plant for every frame the space was pressed instead of just once per press. Inside of this if statement, I used Instantiate to call upon _plantPrefab and summon it to where the player currently is.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
- [Pixel Adventure 1](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360) - Plant sprite
- [Simple 2D Platformer Assets Pack](https://assetstore.unity.com/packages/2d/characters/simple-2d-platformer-assets-pack-188518) - Player Sprite

## Prof comments
Thank you for clearly connecting the plans you wrote with the code that you implemented. I'm interested to see if you find the more detailed break-down that we do for HW2 more helpful or not! :)

In the future, please include your break-down activity in the Devlog itself; you can format lists with the hyphen '-' symbol as suggested above. Your links also needed to not have a space between the [] and the () with the link. Also, you can remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
