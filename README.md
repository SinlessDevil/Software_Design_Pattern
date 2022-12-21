# Software Design Pattern in Unity

---
I got all the information from these sources.                            

>Сodaza - https://www.youtube.com/@codaza-channel                                           
>Unity Ok - https://www.youtube.com/@unityk555                                           
>Builder Line - https://www.youtube.com/@builderline7061                                           
>Роман Сакутин - GameDev - https://www.youtube.com/@GamedevelopingRu1                                           
>ExtremeCode - https://www.youtube.com/@ExtremeCode                                                                                      
>Bot GameDev - Уроки по Unity - https://www.youtube.com/@botgamedev-unity9130                                           
>Лавка Разработчика - https://www.youtube.com/@gamedevlavka

>Refactoing GURU - https://refactoring.guru/uk/design-patterns/csharp                            
>Habrador - https://www.habrador.com/tutorials/programming-patterns/                            
---

Here I put together a colexion of pattens in the Unity engine
There are still patterns to be added, but I think I've already added the most basic ones

Now I will tell you about the most important patterns in unity in my opinion

# Behavioral Patterns 

* Pattern Visitor - will help get rid of the long if or Switch when bumping into different Entity, etc.

* Pattern Observer - Building game logic on events is the right decision in OOP. So this pattern will help you to easily and intelligently build the connection between UI and GameObject via Action.                                   
P.S. Don't forget to unsubscribe from events. 

* Pattern State - Allows you to dynamically change the state of the object depending on the situation. For example as in the game GTA
Where the player could fall into the water for example and I have already changed the model of behavior from walking to swimming. Also, this patter will help in changing the animation

* Pattern Strategy - The most popular pattern, along with Singletone, allows you to easily change a given strategy through abstraction (interface or abstract class). In a large project it is very difficult to change a large code, and just a pattern strategy allows you to quickly change the code of the program by just passing a parameter to the method

* Pattern Command - A really cool pattern that is often used in turn-based games. Allows you to cancel a given command and add through the queue. Also a great example of this pattern is the browser itself, where you can go back or forward through pages

# Creational Patterns

* Pattern Pool Objects - For me, this is the most popular patter. When we need to create a huge number of objects practically infinitely, this patch is just what helps us. Because, unlike in Farbika, we don't create objects here, but roughly speaking only include those objects that are switched off in the pool. The advantage of this pattern is that it saves memory and reduces the workload of the Garbage Collector.

* Pattern Factory or Abstract Factory - Pattern which allows you to conveniently create objects

* Pattern Singletone - You have to be as careful as possible with this patter and try to use it as little as possible. It is intended to provide a global access point to all components, properties, and fields of a class. It also tells us that there should only be one object!

# Structural Patterns

* Pattern Flyweight - An incredibly useful pattern that everyone should know - is a structural design pattern that allows programs to support vast quantities of objects by keeping their memory consumption low.
The pattern achieves it by sharing parts of object state between multiple objects. In other words, the Flyweight saves RAM by caching the same data used by different objects.

* Pattern Subclass Sandbox - The subclass sandbox pattern describes a basic idea, while not having a lot of detailed mechanics. You will need the pattern when you have several similar subclasses. If you have to make a tiny change, then change the base class, while all subclasses shouldn't have to be touched. So the base class has to be able to provide all of the operations a derived class needs to perform.

* Pattern Decorator - is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects, called decorators. For example Abilities, Skills, game effects, they often have a tendency to change a little bit just for this patter is best suited 

* Pattern Composite - is a structural design pattern that allows composing objects into a tree-like structure and work with the it as if it was a singular object.For example, this is often a strategy where you have to give a command to all units 

---

That's all for now.)
