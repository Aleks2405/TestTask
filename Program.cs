using ClassLibraryTest;
Console.WriteLine($"Выберите цифру фигуры, площадь которой необходимо посчитать \n 1. Круг \n 2. Треугольник  \n 3. Квадрат ");
var type = Console.ReadLine();
IFigure a = null;
double[] arr;
switch (type.ToLower())
{
    case "1": a = new Circle();
        Console.WriteLine("Введите радиус круга");
        arr = new double[1];
        a.AreaOfThe(arr);
        break;      
    case "2":  a = new Square();
        Console.WriteLine(" Введите данные 3 сторон треугольника");
        arr = new double[3];
        a.AreaOfThe(arr);
        break;
    case "3": a = new Rectangle();
        arr= new double[2];
        Console.WriteLine(" Введите 2 стороны квадрата");
        a.AreaOfThe(arr);
        break;
}
if (a != null)
{
    Console.WriteLine($"Вы успешно посчитали данные по своей фигуре");
}
else
{
    Console.WriteLine($"Вы ввели не существующую фигуру из списка");
}


