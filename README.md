# GameEngineMidterm

Apply 3 principles of OOP:
I had the OOP principle of inheritance in my classes intended for the factory design principle. The enemyspawner and enemy classes were base classes while they had children labled enemy1, enemy2, enemyspawner1, and enemyspawner2. This is not reflected in the final push as The code for the child classes was incomplete and was preventing the project from compiling due to errors associated with them not having an override for the abstract function in the parent classes. Additionally I was going to implement polymorphism into my project using the games childed enemy classes so that a enemy manager coould simply loop through them all regardless of type. This would work well with the nature of my enemies all derived from the enemy base class. 

Singleton design principle:
For singleton design principle I was in the process of implementing a score manager. The score manager was completing all of the requirements to follow the singleton design principle such as using statics with instance to verify that it is the only instance of the object and destroying itself if not. If it is it becomes the instance. This score manager accepted an imput temporatily set to keypress F and was supposed to update the score and then the textmeshpro text on screen. This would serve as a single global interface for the games score called by all kinds of non implemented functions such as destroying enemies etc.

Factory design principle:
The factory design principle was not implemented in it's functional entirety due to time constraints. The plan was to use an enemy base class interface paired with some child classes for enemy 1 and two as well as an enemy spawner abstract creator class with child classes for spawning 1 and 2 all using abstracts in the base classes being overwritten in the child classes. In this situation the game manager could simply call enemyspawner to spawn enemy without being aware of what it was spawning. 

I reused code for my implementation of both design principles from practice code that I did based on the study guide while preparing for the midterm.
