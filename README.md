# Platform Game

## Overview
This game is a basic platformer where the player can move a character left and right, jump to avoid enemies, and collect coins. The goal is to avoid collisions with enemies while collecting as many coins as possible to achieve a high score.

## Key Features

### 1. Character Control
- **Left/Right Movement**: Use the left and right arrow keys to move the character.
- **Jump**: Press the spacebar to make the character jump.

### 2. Enemies
- Two enemies move left across the screen, reversing direction when hitting walls.
- Colliding with an enemy stops the game, prompting the player to restart.

### 3. Coin Collection
- Collecting coins increases the score. Collected coins disappear.

### 4. Scoring System
- The player’s score increases when coins are collected.
- A message box appears when the player collects all coins or collides with an enemy, showing the score.

### 5. Game Theme Music
- Background music plays in a loop when the game starts.

## Class Description

### `frmGame` Class
- This class handles the main game logic.

#### Fields
- `enemy1Speed_`, `enemy2Speed_`: Speeds of the enemies.
- `playerSpeed_`: Speed of the player.
- `goLeft_`, `goRight_`: Direction of player movement.
- `jumping_`: Indicates if the player is jumping.
- `jumpSpeed_`, `gravity_`: Variables related to jumping and gravity.
- `score_`: Current score.
- `startingTop_`, `startingLeft_`: Starting position of the player.
- `gameTheme_`: Sound player for the game theme music.

#### Main Methods
- `frmGame()`: Constructor that initializes and starts the game.
- `tmrGame_Tick()`: Called on every Tick of the game loop, processing all game logic.
- `KeyIsDown()`: Called when a key is pressed, updating movement and jump states.
- `KeyIsUp()`: Called when a key is released, updating movement states.
- `restartGame()`: Resets the game to its initial state.

## User Interface
- **Player**: Player character image (`pbxPlayer`).
- **Enemies**: Enemy images (`pbxEnemy1`, `pbxEnemy2`).
- **Ground**: Images representing platforms and the ground.
- **Score Label**: A label (`lblScore`) displaying the current score.

## Usage Example
When the game starts, the player can move left and right and jump using the spacebar to collect coins. Colliding with an enemy or falling below the ground ends the game, presenting an option to restart with the displayed score.
