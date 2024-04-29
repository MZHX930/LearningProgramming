// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp._01SimpleFactory;
using ConsoleApp._02Strategy;
using ConsoleApp._19Composite;
using ConsoleApp._19Composite.Instance;


//01 简单工厂模式
Pattern01 pattern01 = new Pattern01();
pattern01.Run();

Pattern02 pattern02 = new Pattern02();
pattern02.Run();

//19 组合模式
Pattern19 pattern19 = new Pattern19();
pattern19.Run();
