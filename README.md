# Software_Design_Pattern
Software Design Pattern in Unity

----------------------------------------------------------------
I got all the information from these sources.                            

Сodaza - https://www.youtube.com/@codaza-channel                                           
Unity Ok - https://www.youtube.com/@unityk555                                           
Builder Line - https://www.youtube.com/@builderline7061                                           
Роман Сакутин - GameDev - https://www.youtube.com/@GamedevelopingRu1                                           
ExtremeCode - https://www.youtube.com/@ExtremeCode                                                                                      
Bot GameDev - Уроки по Unity - https://www.youtube.com/@botgamedev-unity9130                                           
Лавка Разработчика - https://www.youtube.com/@gamedevlavka

Refactoing GURU - https://refactoring.guru/uk/design-patterns/csharp                            
Habrador - https://www.habrador.com/tutorials/programming-patterns/                            
----------------------------------------------------------------

Here I put together a colexion of pattens in the Unity engine
There are still patterns to be added, but I think I've already added the most basic ones

Now I will tell you about the most important patterns in unity in my opinion

Behavioral Patterns 

Pattern Visitor - will help get rid of the long if or Switch when bumping into different Entity, etc.

Pattern Observer - Building game logic on events is the right decision in OOP. So this pattern will help you to easily and intelligently build the connection between UI and GameObject via Action.                                   
P.S. Don't forget to unsubscribe from events. 

Pattern State - Allows you to dynamically change the state of the object depending on the situation. For example as in the game GTA
Where the player could fall into the water for example and I have already changed the model of behavior from walking to swimming. Also, this patter will help in changing the animation

Pattern Strategy - The most popular pattern, along with Singletone, allows you to easily change a given strategy through abstraction (interface or abstract class). In a large project it is very difficult to change a large code, and just a pattern strategy allows you to quickly change the code of the program by just passing a parameter to the method

Pattern Command - A really cool pattern that is often used in turn-based games. Allows you to cancel a given command and add through the queue. Also a great example of this pattern is the browser itself, where you can go back or forward through pages
