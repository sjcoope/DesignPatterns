Recently I've started building up my design pattern library and realised while I've used the singleton in the past, I've always thought it a relatively simple pattern. That's true on the surface of it, but some reading I've done recently has made me realise it's quite easy for this simple pattern to cause a whole host of problems.

#Overview
First though, let's discuss what the singleton pattern is and what it's useful for.

Essentially, the singleton pattern is used to ensure there's only ever one instantiated object for a specific class. There are a few ways to achieve this (which I'll cover later in this post) but the basic singleton relies on a private constructor and a static method on the class. Because the constructor is private it can only be accessed witin the class, which is why we have a static method. Ultimately, this means we can let the class control how and when it is instantiated.

In my experience singletons are used in two scenarios:

- **Single to Many** - One entry point for managing multiple resources (e.g. thread pools, connection pools, etc.)
- **Many to Single** - Multiple entry points to a core application resource (e.g. logging, configuration, etc.)

When considering a singleton it's also important to think about the following:

- **Parameters** - Singletons don't allow parameters to be passed and used in the instantiation of the object. Needing parameters would mean that different parts of the program need a slightly different implementation of the singleton, in which case it's better to use the factory pattern.
- **Inheritance/Subclassing** - Singletons also prevent subclassing via the use of the private constructor. Which is a good thing because inheritance could lead to more than one instance of the singleton (and breaks the pattern). In .Net it's also worth using the `sealed` keyword for any JIT optimisations it provides.

##Alternatives
There are ways to achieve the same functionality provided by the singleton pattern, but in my opinion these don't offer the same level of control. For example, we could create a static class with all static members. However, this means we lost the optimisation of lazy loading. A static class is loaded when the application is loaded, whereas the singleton instance is usually created when it's first requested. Also, because of the way static initializations are handled it can get a bit messy (which is a personal preference thing).

#Implementation
To show the different ways we can implement the singleton pattern, I'm going to work through a very basic example in code. The example is based on how to make tea (yes - very British) and include the following 5 steps:

- Fill Kettle
- Boil Kettle
- Put Teabag in Cup
- Fill Cup
- Remove Teabag from Cup

All of these steps have to happen in a certain order, hence you can't boil the kettle unless it's been filled first, etc.

In the code samples, the `BasicTeaMaker1` class shows the general non-singleton implementation. In the `Example` class we create two of these tea makers and separate threads and execute them to show the potential collisions during the tea making operation.

Basic Singleton

- Fine for single threaded scenarios - but don't create one like this as it's a point of failure in the future. Always consider threading.

Managing Threading

- sychronised - uuse lock in .Net.
  Fixes the problems, but isn't this expensive? Because once we've instantiated the object we don't need to traverse the lock everytime the instance is requested (because there won't be any collisions/deadlocks once it's created). If performance isn't important then this is a viable option. Performance suffers because a lock is acquired everytime the instance is requested.

- Eager Loading
  Move to an eager loading approach - i.e. create an instance of the singleton object with a static intializer, this is guaranteed to be threadsafe as the instance is created when the class is loaded (true?)

- Double Checked Locking
  with double check locking we first check to see if the instance is created and if not then we synchronise. This way we only synchronise the first time through, just waat we want. We need the second check to handle any threads that pass the first check at the same time and are then passed through teh synchronisation in order. Avoid this because it's easy to get wrong, any deviation from the pattern breaks it and will cause problems or affect performance.
  It doesn't perform as well as another option.

-- Nested Class
The instance is triggered by the first reference to the static member of the nested class, which only occurs in Instance.
Means the implementation is lazy, but doesn't use locks and so is more performant. But the code is a bit more complicated and doesn't look nice!

- Lazy<T> Type
- Simple and performs well.
  -- Allows us to check whether or not the instance has been created yet with the IsValueCreated property.
  Uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode. Can experiment with othe rmodes.

Whichever one you choose depends on the balance you need between performance and lazy loading.

Conclusions
Class doesn't do one thing, it's responsible for it's own instantiation and it's implementation details (i.e. making a cup of tea).

Notes:
   // public sealed class Singleton {
    //     private Singleton() {

    //     }

    //     public static Singleton Instance {get {return Nested.instance;}}

    //     private class Nested
    //     {
    //         // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit.
    //         static Nested()
    //         {}

    //         internal static readonly Singleton instance = new Singleton();
    //     }
    // }