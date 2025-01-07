using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Façade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

Console.WriteLine("Selecione o padrão:");
Console.WriteLine("1 - Adapter");
Console.WriteLine("2 - Bridge");
Console.WriteLine("3 - Composite");
Console.WriteLine("4 - Decorator");
Console.WriteLine("5 - Façade");
Console.WriteLine("6 - Flyweight");
Console.WriteLine("7 - Proxy");

string selectedOption = Console.ReadLine();

switch (selectedOption)
{
	case "1":
        new ExecutorAdapter().Execute();
		break;
    case "2":
        new ExecutorBridge().Execute();
        break;
    case "3":
        new ExecutorComposite().Execute();
        break;
    case "4":
        new ExecutorDecorator().Execute();
        break;
    case "5":
        new ExecutorFacade().Execute();
        break;
    case "6":
        new ExecutorFlyweight().Execute();
        break;
    case "7":
        new ExecutorProxy().Execute();
        break;
    default:
        Console.WriteLine("Opção não disponível");
		break;
}