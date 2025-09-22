using Oop;

Pet pet = new Pet();
pet.Name = "Whiskers";
pet.PrintInfo();

Console.WriteLine("=========================");

Dog dog = new Dog("Buddy", 2020, "Golden Retriever");
dog.PrintInfo();

Dog dog2 = new Dog("Max", "Beagle");
dog2.PrintInfo();
dog2.Bark();

// var x = new IConsoleTool(); This line will cause a compile-time error because interfaces cannot be instantiated directly.

var consoleTool = new ConsoleTool();
consoleTool.Write("Hello, World!");
consoleTool.WriteEmptyLine();
consoleTool.WriteError("This is an error message.");