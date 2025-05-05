# FINAL PROJECT - CS50's INTRODUCTION TO GAME DEVELOPMENT
## INFINITY SPACE
- [Introduction](#introduction)
- [Project Requirements](#projectrequirements)
- [Usage](#usage)
- [Explaining](#explaining)
- [States](#states)
- [Contact](#contact)
### Introduction
   This documentation details the work completed for my final project, the Infinity Space game.I chose the Unity Engine because I think it is more professional, complete, and easier for beginners compared to LÖVE for this project.
   I spent approximately one month working on this important project and finally finished it. This is the first game I have created, and I applied several programming techniques learned in this course and at my university.  
   In this game, the player transforms into a ball and tries to overcome obstacles in the vast universe. The goal is to reach the endpoint to win.
### Project Requirements
   - Your game must be in either LÖVE or Unity.  
   - Your game must be a cohesive start-to-finish experience for the user; the game should boot up, allow the user to play toward some end goal, and feature a means of quitting the game.  
   - Your game should have at least three GameStates to separate the flow of your game’s user experience, even if it’s as simple as a StartState, a PlayState, and an EndState, though you’re encouraged to implement more as needed to suit a more robust game experience (e.g., a fantasy game with a MenuState or even a separate CombatState).   
   - Your game can be most any genre you’d like, though there needs to be a definitive way of winning (or at least scoring indefinitely) and losing the game, be it against the computer or another player. This can take many forms; some loss conditions could be running out of time in a puzzle game, being slain by monsters in an RPG, and so on, while some winning conditions may be defeating a final boss in an RPG, making it to the end of a series of levels in a platformer, and tallying score in a puzzle game until it becomes impossible to do more.  
   - You are allowed to use libraries and assets in either game development environment, but the bulk of your game’s logic must be handwritten (i.e., putting together an RPG in Unity while using a UI library would be considered valid, assuming the bulk of the game logic is also not implemented in a library, but recycling a near-complete game prototype from Unity’s asset store with slightly changed labels, materials, etc. would not be acceptable).  
   - Your project must be at least as complex as (and distinct from!) the games you’ve implemented in this course, and should really be moreso. Submissions of low complexity may be rejected! You must explain your game in detail and why you believe it to meet the complexity and distinctiveness requirement in a README.md file at the root of your project.  
### Usage
   1. Clone the final project in the repository:  
      git clone --branch games50/projects/2018/x/final --single-branch https://github.com/me50/hautranuit.git  
   2. Open Unity Hub and Add Project which you just cloned.  
   3. Run the game in Unity Engine in 'Play Maximized' mode or you can build the game and play it.  
   4. The keys used in the game are W A S D or  ⇦ ⇧ ⇨ ⇩ to move and Space to jump. If you reach a check point, press R to return it.
### Explaining
##### 1. Assets
I used the Unity Asset Store to download several necessary assets for my project, such as GalaxyBox, Halloween Pumpkin, and MetalMaterials. These assets are completely free and have enhanced the visual appeal of my game. Additionally, I obtained other resources from external sources, such as game sounds and jumping sound effects. In the future, I plan to learn more about UI/UX design so that I can create my own assets.
#### 2. Moving 
The main character in our game is a ball. It needs to be able to move forward, backward, left, right, and jump high. In Unity, there is an object called Input Manager that allows you to modify 'vertical', 'horizontal', and 'jump' so that the system can receive input from your keyboard and mouse. In the moving scripts, we need some variables such as jumpHeight, jumpSpeed, jumpMax, and thrust. Some of the techniques I used were Vector3 in the MoveByRigidbody() function, AddForce(), and ResetJump.
#### 3. Camera
In this game, the camera needs to follow the player, and the camera angle must change based on signals from the mouse to ensure that the player gets the best view when overcoming obstacles. I use a third-person camera with a specific offset in front of the player. This helps to prevent dizziness while playing and ensures a comfortable experience. The camera continuously tracks the player's position. Some techniques for applying camera rotation include using Input.GetAxis("Mouse Y") * rotationSpeed, Input.GetAxis("Mouse Y") * rotationSpeed, Quaternion rotation, and currentOffset = rotation * offset, ...
#### 4. Enviroment
This game takes place in space, so some environmental elements will be modified to fit the setting. For example, the default SkyBox will be replaced with a GalaxyBox to create a majestic, starry universe. The StaticPlatform and MovingPlatform will also be updated with materials that suit the game's atmosphere. I downloaded all of these assets from the Unity Store as mentioned above.
- Moving Platform  
  When working with StaticPlatform, you just need to create cubes and spheres and add materials to make them look nice. On the other hand, with MovingPlatform, more complex techniques are required. For instance, the object moves between fixed set points, and the player must wait for it to arrive, then jump on it to reach the other side. Another type of MovingPlatform disappears after a while, and you need to move quickly over it, or it will fall down. It reappears after a short time. There's also a MovingPlatform that I like the most - it moves when you approach it, lifts you up, and then lowers itself back to the original position. I applied my knowledge of Box Collider and Trigger to make these happen
- ProBuilder  
  Objects in Unity are limited in number, so I used ProBuilder, which was introduced in the Portal Lecture, to create new objects and add more variety to the game.
- Wind  
  There is an obstacle in the game to which I applied Unity's WindZone object. I downloaded fan models from the Unity Asset Store. When players pass through the WindZone, they will be pushed away in the direction the fan is heading. Although the fan blades don't actually rotate but I think this will be an interesting challenge for players. 
- CheckPoint  
  In the game, CheckPoint (or SavePoint) is a necessary system similar to other obstacle course games. If a player falls, they can press "R" to return to a CheckPoint. In this game, a CheckPoint object has two child objects: Trigger and Action. The Trigger consists of two components: BoxCollider and Trigger scripts. When the player reaches the Trigger zone, the Action is activated. The Action may contain either the 'Action Check Point' or 'Action Check Point GameOver' script. A model of a 'Halloween Pumpkin' has been added to the CheckPoint for easy recognition, and its light will turn on when activated.
### States 
  * StartState  
  * PlayState   
  * PauseState      
  * GameOverState
### Contact
  - edX account: hautran_32
  - github account: hautranuit
  - email: 22520412@gm.uit.edu.vn
  
  




