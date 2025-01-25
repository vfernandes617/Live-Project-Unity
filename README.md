# Live-Project-Unity
---
During my time at the Tech Academy I worked on a live project to build a game using the Unity Engine. This was a two week sprint and the scripts were all created using C#. This was an apprentiship for Prosper IT Consulting, were we participated in daily stand-ups with a small team. The goal was to deliver a minimal viable product (MVP) by the end. For this MVP, I was tasked with creating an arcade  game. I chose to create a version the popluar game flappy bird. There were quite a few mechanics and physics that I had to implement to fully realize this game.
Below are some examples of logic and code I have for this project.
---
- [Main Menu](#MainMenu)
- [Parallax](#Parallax)
- [Spawn](#Spawn)
- [Player](#Player)
- [Mountain](#Moutain)
- [Skills Learned](#Skills)

---

## MainMenu

For my main menu screen, I created a scene that takes place before the game. Then, I created a play button that, once pressed, starts the "Gameplay" scene. I returned to the menu towards the end of development, once I had finalized my art style, and ensured that the background I created fit thematically with my gameplay.

---
![Project Screenshot](https://github.com/vfernandes617/Live-Project-Unity/blob/main/Tappy%20Plane/Images/mainmenu.jpg)
---

## Parallax


To create the Parallax effect in my game I created three seperate layers within the game. The parallax effect is a visual technique that creates the illusion of depth and movement by making objects closer to the viewer appear to move faster than objects in the background. It's based on the optical illusion that objects closer to us appear larger than those farther away. The ground layer was moving seperate from the mountain objects coming towards the character. The background would move slightly faster giving the player the illusion that of speed. And Finally the mountains would move but because of the layers moving the mountains appear to be still.
---
![Project Screenshot](https://github.com/vfernandes617/Live-Project-Unity/blob/main/gif/tappyplane.gif)
---

## Spawn

For this spawn script. I created it to actually spawn my objects into the world. Each spawn brings in a prefab of the mountain into the world and puts them into a location into the world.

---
![Project Screenshot](https://github.com/vfernandes617/Live-Project-Unity/blob/main/IMG/Screenshot%202025-01-24%20210836.png)
---

## Player

This script is a Unity C# script for a Player class, which is responsible for controlling the behavior of a player character in a 2D or 3D game. Here's a breakdown of what each part of the script does:

Fields
SpriteRenderer spriteRenderer

Used to manage the appearance of the player object by rendering its sprite.
Sprite[] sprites

An array of sprites used for animation or visual changes during gameplay.
int spriteIndex

Tracks the current index of the sprite in the sprites array.
Vector3 direction

Stores the player's movement direction. This vector is updated for jumping or applying gravity.
AudioClip crashClip

A sound effect (e.g., for when the player crashes).
AudioSource audioSource

Used to play audio clips (like the crash sound).
float force

The upward force applied to the player when a key or mouse button is pressed.
float gravity

The constant gravity force applied to pull the player downward.
Methods
Awake()
Called when the script instance is being loaded.
Retrieves the SpriteRenderer component attached to the game object, which is necessary for managing the player's visual appearance.
OnEnable()
Called when the object becomes active.
Resets the player's position and direction:
The position is reset to ensure the player starts at a specific location.
direction is reset to Vector3.zero, ensuring no momentum carries over when reactivating the object.
Start()
Called before the first frame update.
Sets up:
Sprite Animation: InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f) is used to repeatedly call the AnimateSprite method every 0.15 seconds for sprite animation.
AudioSource: Retrieves the AudioSource component to play sound effects like the crash sound.
Update()
Called every frame.
Handles player movement:
Input Handling:
Input.GetKeyDown(KeyCode.Space) or Input.GetMouseButtonDown(0) checks if the player presses the spacebar or the left mouse button.
If pressed, an upward force (direction = Vector3.up * force) is applied.
Gravity:
direction.y += gravity * Time.deltaTime applies gravity over time, pulling the player downward.
Position Update:
transform.position += direction * Time.deltaTime moves the player based on the updated direction.

---
![Project Screenshot](https://github.com/vfernandes617/Live-Project-Unity/blob/main/IMG/Screenshot%202025-01-24%20211755.png)
---

## Mountain

This script controls the speed in which the spawn. And once the mountains leaves the camera view they get destroyed.
![Project Screenshot](https://github.com/vfernandes617/Live-Project-Unity/blob/main/IMG/Screenshot%202025-01-24%20212634.png)


## Skills Learned

During this project, I gained valuable experience in Agile/Scrum methodologies within a collaborative team environment. I honed my C# coding skills in Visual Studio and effectively integrated these scripts into my game.

Key Agile/Scrum Practices:

Sprint Planning:

Defined clear sprint goals.
Prioritized and selected user stories/tasks from the backlog.
Decomposed tasks into manageable chunks.
Adhered to short sprint durations (1-2 weeks) for rapid iteration and feedback.
Product Backlog Management:

Maintained a prioritized backlog of features, bugs, tasks, and improvements.
Utilized project management tools like Jira or Trello.
Daily Stand-up Meetings:

Conducted concise (15-minute) daily meetings to review progress, identify roadblocks, and maintain accountability.
Definition of Done (DoD):

Established a shared understanding of "done" encompassing code reviews, unit tests, integration, and documentation updates.
Sprint Reviews and Retrospectives:

Presented completed work to stakeholders and gathered feedback.
Conducted regular retrospectives to identify areas for improvement and enhance future sprints.
Collaboration and Communication:

Leveraged communication tools such as Slack or Microsoft Teams.
Maintained transparency through shared task boards.
Incremental Delivery:

Focused on delivering small, valuable increments to users and stakeholders.
Scrum Artifacts:

Utilized sprint backlogs, burndown charts, and product increments to track progress and measure success.
Flexibility and Adaptability:

Responded effectively to changing priorities and unforeseen challenges.
Celebrating Success:

Recognized individual and team achievements to foster a positive and motivating work environment."
Key Improvements:

Conciseness: The text is more concise and easier to read.
Clarity: The language is more direct and avoids unnecessary jargon.
Structure: The information is presented in a more organized and logical manner.
Impact: The text highlights the key skills and experiences gained.
This refined version effectively communicates the value of your Agile/Scrum experience in a professional and impactful way.
