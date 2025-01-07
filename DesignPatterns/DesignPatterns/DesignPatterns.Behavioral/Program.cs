using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Template_Method;
using DesignPatterns.Behavioral.Visitor;

Console.WriteLine("Selecione o padrão:");
Console.WriteLine("1 - Chain of Responsibility");
Console.WriteLine("2 - Command");
Console.WriteLine("3 - Iterator");
Console.WriteLine("4 - Mediator");
Console.WriteLine("5 - Memento");
Console.WriteLine("6 - Observer");
Console.WriteLine("7 - State");
Console.WriteLine("8 - Strategy");
Console.WriteLine("9 - Template Method");
Console.WriteLine("10 - Visitor");
Console.WriteLine("11 - Iterator");

string selectedOption = Console.ReadLine();

switch (selectedOption)
{
    case "1":
        new ExecutorChainOfResponsibility().Execute();
        break;
    case "2":
        new ExecutorCommand().Execute();
        break;
    case "3":
        new ExecutorIterator().Execute();
        break;
    case "4":
        new ExecutorMediator().Execute();
        break;
    case "5":
        new ExecutorMemento().Execute();
        break;
    case "6":
        new ExecutorObserver().Execute();
        break;
    case "7":
        new ExecutorState().Execute();
        break;
    case "8":
        new ExecutorStrategy().Execute();
        break;
    case "9":
        new ExecutorTemplateMethod().Execute();
        break;
    case "10":
        new ExecutorVisitor().Execute();
        break;
    case "11":
        new ExecutorInterpreter().Execute();
        break;
    default:
        Console.WriteLine("Opção não disponível");
        break;
}