# Unity 3D Graphics Scene Report

![RaceTrack](/Assets/raceTrack.png)

## Baseline Implementation

In establishing the baseline, I developed a functional scene featuring both a racetrack and a character player formed by employing two sets of 3D game objects using ProBuilder. The primary objective was to construct a basic car simulator where the character interacts with environmental physics. This initial arrangement establishes the groundwork for the subsequent tasks.

## Task 1: Creating a 3D Scene with Basic Graphics Techniques


### Techniques Used:
- **ProBuilder:** Modifying basic forms to develop complex geometry that satisfies the requirements of the system.
- **Transforms:** The arrangement of game objects in the scene involves utilizing transforms for positioning, rotation, and scaling.
- **Materials:** Basic materials were applied to objects to control their appearance, showcasing fundamental graphics rendering.
- **Lightning:** Point lights and Spotlight were applied to game objects to enhance the appearance of game objects.

### Explanation:

The objective was to construct a virtual 3D setting featuring a racetrack and a player character, employing ProBuilder along with fundamental graphic techniques. I conducted research through tutorials to acquire proficiency in ProBuilder. By manipulating vertex points on plane primitives, I created angles and defined the curves of the racetrack. Additionally, I utilized edge loops on cube primitives to sculpt the cube into the form of a car. Cylinder primitives were incorporated, and through transformations, I organized the elements into wheels and headlights. To enhance the overall aesthetics, materials and lights were introduced to refine the appearance of the car.

## Task 2: Implementing a Moving Object with User Input

### Techniques Used:
- **Transform.Translate:** The character modifies the transform object to generate motion on the racetrack.
- **Input Handling:** Unity's Input Manager was employed to capture keyboard input for controlling the movement.

### Explanation:

The goal was to incorporate user interaction for controlling car movement. By storing inputs from the vertical and horizontal axes into local variables of the player class, we captured the movement along the z-axis and the rotation around the y-axis. This input was continuously recorded in each frame through the Update method. Subsequently, normalized vectors for position and rotation were created, scaled to a magnitude specified in the inspector, and multiplied by delta time for accurate rendering. The transform object was then updated to reflect the new position and rotation.

## Extension Task: Third Person Camera Following a Moving Object

### Techniques Used:
- **Camera Script:** A set of guidelines for rotating the camera around a specified radius from the target position.
- **Negation:** A vector multiplied by -1, employed to determine the camera position.

### Explanation:
The extension involved creating a more immersive experience by implementing a third-person camera that follows the moving character. To accomplish this, users can specify a camera offset in the inspector. This offset is represented by a three-dimensional vector, where the magnitude signifies the radius between the character and the camera. By leveraging the forward vector property of the character, we can determine its pointing direction. By negating the direction and multiplying it by the offset magnitude, we can ascertain how the camera rotates around the radius based on the character's direction. Once the camera is positioned, the LookAt method is employed to align the camera's orientation with the character.

## Additional Extensions

- Rigid body applied to character to simulate physics 
- UI Main Menu
- Event System through Actions that perform OnPlayersDeath delegate

## Conclusion

In summary, we addressed each task by leveraging Unity's transformative and interactive features, along with manipulating forms of primitives using ProBuilder. The chosen techniques aligned seamlessly with the tasks' goals, achieving a balance between simplicity and effectiveness. The extension task brought an additional layer of complexity, highlighting Unity's versatility in creating dynamic and visually captivating 3D scenes.