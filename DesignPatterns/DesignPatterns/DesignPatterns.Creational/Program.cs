using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

Console.WriteLine("Selecione o padrão:");
Console.WriteLine("1 - Abstract Factory");
Console.WriteLine("2 - Builder");
Console.WriteLine("3 - Factory Method");
Console.WriteLine("4 - Prototype");
Console.WriteLine("5 - Singleton");

string selectedOption = Console.ReadLine();

switch (selectedOption)
{
    case "1":
        new ExecutorAbstractFactory().Execute();
        break;
    case "2":
        new ExecutorBuilder().Execute();
        break;
    case "3":
        new ExecutorFactoryMethod().Execute();
        break;
    case "4":
        new ExecutorPrototype().Execute();
        break;
    case "5":
        new ExecutorSingleton().Execute();
        break;
    default:
        Console.WriteLine("Opção não disponível");
        break;
}