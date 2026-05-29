using System;
using System.Collections.Generic;

// ==========================================================
// ПОШАГОВАЯ РАБОЧАЯ ТЕТРАДЬ ПО C#
// Тема: Абстрактные классы и абстрактные методы
// Формат: файл всегда компилируется, студент дописывает только TODO
// ==========================================================
//
// ИДЕЯ ФОРМАТА
// ----------------------------------------------------------
// 1. Преподаватель идет по блокам сверху вниз.
// 2. У каждого блока есть пояснение.
// 3. Студент меняет только места с TODO.
// 4. Файл компилируется даже до выполнения всех заданий.
// 5. Временные заглушки помогают проходить тему по шагам.
//
// КАК ПРОХОДИТЬ
// ----------------------------------------------------------
// - Сначала запускаем файл как есть.
// - Затем заполняем TODO 1.
// - Снова запускаем.
// - Потом TODO 2.
// - И так далее.
//
// Можно проводить урок как "живую тетрадь":
// преподаватель объясняет блок,
// студенты сразу дописывают код,
// затем все вместе запускают результат.
//
// ==========================================================

Console.WriteLine("Пошаговая рабочая тетрадь: abstract class / abstract methods");
Console.WriteLine(new string('=', 72));

TeacherIntro();
Step1_Animals();
Step2_Employees();
Step3_Shapes();
Step4_Transport();
FinalReflection();

static void TeacherIntro()
{
    Console.WriteLine("\n[Вступление преподавателя]");
    Console.WriteLine("Сегодня мы разбираем абстрактные классы и абстрактные методы.");
    Console.WriteLine("Наша задача — понять, когда общий класс нужен как основа,");
    Console.WriteLine("но не должен использоваться напрямую.");
    Console.WriteLine("Мы пойдем от простого примера к более практическим.");
}

static void Step1_Animals()
{
    Console.WriteLine("\n================ ШАГ 1. Животные ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Абстрактный класс Animal задает общее правило:");
    Console.WriteLine("у каждого животного должен быть метод MakeSound(),");
    Console.WriteLine("но у каждого наследника звук свой.");

    List<Animal> animals = new List<Animal>
    {
        new Dog(),
        new Cat(),
        new Cow()
    };

    Console.WriteLine("\nРезультат:");
    foreach (Animal animal in animals)
    {
        animal.MakeSound();
    }

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите класс Cow и замените временную заглушку на настоящий ответ.");
}

static void Step2_Employees()
{
    Console.WriteLine("\n================ ШАГ 2. Сотрудники ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Абстрактный класс Employee нужен, когда у всех сотрудников");
    Console.WriteLine("есть общие данные, но разная работа.");

    List<Employee> employees = new List<Employee>
    {
        new Developer("Алексей", 150000),
        new Manager("Мария", 170000),
        new Designer("Ирина", 140000)
    };

    Console.WriteLine("\nРезультат:");
    foreach (Employee employee in employees)
    {
        employee.ShowInfo();
        employee.DoWork();
        Console.WriteLine();
    }

    Console.WriteLine("[Задание студенту]");
    Console.WriteLine("Найдите класс Designer и замените временную заглушку на осмысленную реализацию.");
}

static void Step3_Shapes()
{
    Console.WriteLine("\n================ ШАГ 3. Фигуры ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Абстрактными бывают не только методы, но и свойства.");
    Console.WriteLine("У всех фигур есть площадь, но у разных фигур она вычисляется по-разному.");

    List<Shape> shapes = new List<Shape>
    {
        new Rectangle(4, 6),
        new Circle(5)
    };

    Console.WriteLine("\nРезультат:");
    foreach (Shape shape in shapes)
    {
        Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.Area:F2}");
    }

    Console.WriteLine("\n[Задание студенту]");
    Console.WriteLine("Найдите класс Circle и замените временный return на настоящую формулу.");
}

static void Step4_Transport()
{
    Console.WriteLine("\n================ ШАГ 4. Транспорт ================");
    Console.WriteLine("[Пояснение преподавателя]");
    Console.WriteLine("Теперь создаем собственную иерархию.");
    Console.WriteLine("У всех транспортных средств есть общие свойства,");
    Console.WriteLine("но движутся они по-разному.");

    List<Transport> transports = new List<Transport>
    {
        new Car("Toyota", 180),
        new Train("Siemens", 220),
        new Bicycle("Trek", 25)
    };

    Console.WriteLine("\nРезультат:");
    foreach (Transport transport in transports)
    {
        transport.ShowInfo();
        transport.Move();
        Console.WriteLine();
    }

    Console.WriteLine("[Задание студенту]");
    Console.WriteLine("Найдите методы Move() в Car, Train, Bicycle и замените заглушки на содержательные ответы.");
}

static void FinalReflection()
{
    Console.WriteLine("\n================ ИТОГ ================");
    Console.WriteLine("Проверьте себя:");
    Console.WriteLine("1. Можно ли создать объект абстрактного класса?");
    Console.WriteLine("2. Зачем нужен абстрактный метод?");
    Console.WriteLine("3. Чем abstract отличается от virtual?");
    Console.WriteLine("4. Почему List<Employee> может хранить Developer и Manager?");
    Console.WriteLine("5. Где в реальном проекте вам пригодится такой подход?");
}

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Собака говорит: Гав");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Кошка говорит: Мяу");
    }
}

class Cow : Animal
{
    public override void MakeSound()
    {
        // TODO 1:
        // Замените заглушку на:
        // Console.WriteLine("Корова говорит: Му");
        Console.WriteLine("Корова говорит: Му");
    }
}

abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, зарплата: {Salary}");
    }

    public abstract void DoWork();
}

class Developer : Employee
{
    public Developer(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} пишет код");
    }
}

class Manager : Employee
{
    public Manager(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} управляет командой");
    }
}

class Designer : Employee
{
    public Designer(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DoWork()
    {
        // TODO 2:
        // Замените заглушку на осмысленную реализацию.
        Console.WriteLine($"{Name} создает дизайн интерфейса");
    }
}

abstract class Shape
{
    public abstract double Area { get; }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height;
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area
    {
        get
        {
            // TODO 3:
            // Верните формулу:
            // Math.PI * Radius * Radius
            return Math.PI * Radius * Radius;
        }
    }
}

abstract class Transport
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Transport(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Марка: {Brand}, скорость: {Speed}");
    }

    public abstract void Move();
}

class Car : Transport
{
    public Car(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        // TODO 4:
        Console.WriteLine($"{Brand} едет по дороге");
    }
}

class Train : Transport
{
    public Train(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        // TODO 5:
        Console.WriteLine($"{Brand} движется по рельсам");
    }
}

class Bicycle : Transport
{
    public Bicycle(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        // TODO 6:
        Console.WriteLine($"{Brand} едет по велосипедной дорожке");
}
}