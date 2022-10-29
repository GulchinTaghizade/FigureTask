using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using FigureApp;
using FigureApp.FigureFactory;

partial class Program
{
    const string path = @"../../../figure.txt";
    static int Main(string[] args)
    {
        Menu(Initialize());
        return 0;
    }



    static List<Figure> Initialize()
    {
        List<Figure> figlist = new List<Figure>();

        #region Square Creation
        List<Point> pointsofsqu = new()
{
    new Point(0,0),
    new Point(0,5),
    new Point(5,5),
    new Point(5,0)
};
        List<double> sidesofsqu = MathHelper.FindAllSides(pointsofsqu);
        Square sq1 = new Square(pointsofsqu, sidesofsqu);
        figlist.Add(sq1);
        #endregion

        #region Rectangle Creation
        List<Point> pointsofrect = new()
{
 new Point(0,0),
    new Point(0,10),
    new Point(10,7),
    new Point(7,0)
};
        List<double> sidesofrect = MathHelper.FindAllSides(pointsofrect);
        Rectangle rect1 = new Rectangle(pointsofrect, sidesofrect);
        figlist.Add(rect1);
        #endregion

        #region Triangle Creation

        List<Point> points = new()
{
    new Point(0,0),
    new Point(3,0),
    new Point(0,4)
};
        List<double> sides = MathHelper.FindAllSides(points);
        Triangle trg1 = new Triangle(points, sides);
        figlist.Add(trg1);

        #endregion


        Circle crc1 = new Circle(new List<Point>()
{
    new Point(0,5),
    new Point(10,5)
});
        figlist.Add(crc1);

        return figlist;
    }



    public static void Menu(List<Figure> figlist)
    {
        while (true)
        {
            Console.WriteLine("Please select one of the following number:");
            Console.WriteLine("1) Show all figures\n" +
                "2) Create a figure\n" +
                "3) Change figure\n" +
                "4) Save to file\n" +
                "5) Read from file\n" +
                "0) exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllFigures(figlist);
                    break;
                case 2:
                    CreateFigure(figlist);
                    break;
                case 3:
                    ShowAllFigures(figlist);
                    ChangeFigure(figlist);
                    break;
                case 4:
                    SaveToFile(path, figlist);
                    break;
                case 5:
                    ReadFromFile();
                    break;
                case 0:
                    SaveToFile(path,figlist);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter correct input!!!");
                    break;
            }
        }

    }

    static void ShowAllFigures(List<Figure> figures)
    {

        for (int i = 0; i < figures.Count; i++)
        {
            figures[i].FindArea();
            figures[i].FindPerimeter();
            figures[i].FindCenter();
            Console.WriteLine($"{i + 1}.{figures[i].ToString()}");

        }
    }

    static void CreateFigure(List<Figure> figures)
    {
        Console.WriteLine("Please select one of the following figure:");
        Console.WriteLine("" +
            "1)Square\n" +
            "2)Rectangle\n" +
            "3)Circle\n" +
            "4)Triangle");
        int choice = Convert.ToInt32(Console.ReadLine());
        FigureFactory figfactory = new FigureFactory();
        ICreator creator = figfactory.FigureeCreator(choice);
        figures.Add(creator.CreateFigure());
    }

    static void ChangeFigure(List<Figure> figures)
    {
        Console.WriteLine("Write the number of figure from list");
        int figChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Change Figure:");
        Console.WriteLine("1) Move Figure:");
        Console.WriteLine("2) Rotate Figure:");
        Console.WriteLine("3) Scale Figure:");
        Console.Write("Select an option: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Please insert the coordinates:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                figures[figChoice - 1].MoveFigure(x, y);
                break;
            case 2:
                Console.WriteLine("Please insert the angle:");
                double angle = Convert.ToDouble(Console.ReadLine());
                ((FigureWithSides)figures[figChoice - 1]).RotateFigure(angle);
                break;
            case 3:
                Console.WriteLine("Please insert the scale:");
                double scale = Convert.ToDouble(Console.ReadLine());
                figures[figChoice - 1].ScaleFigure(scale);
                break;
            default:
                Console.WriteLine("Please enter correct input!!!");
                break;
        }
    }

    static async void SaveToFile(string path, List<Figure> figlist)
    {
        //using var sw = new StreamWriter(path, true);
        //foreach (var line in figlist)
        //{
        //    sw.WriteAsync(line.ToString());
        //}

        #region BinarySerialization
        //Stream SaveFileStream = File.Create(path);
        //BinaryFormatter serializer = new BinaryFormatter();
        //serializer.Serialize(SaveFileStream, figlist);
        //SaveFileStream.Close();
        #endregion

        #region JSONSerialization
        //using FileStream createStream = File.Create(path);
        //await JsonSerializer.SerializeAsync(createStream, figlist);
        //await createStream.DisposeAsync();
        #endregion

    }

    static List<Figure> ReadFromFile()
    {
        Console.WriteLine("Reading saved file");
        List<Figure> figlist = new List<Figure>();
        //using (var sr = new StreamReader(path))
        //{
        //    while (!sr.EndOfStream)
        //    {
        //        var line = sr.ReadLine();
        //        Console.WriteLine(line);
        //    }
        //}

        #region BinaryDeserialization
        //Stream openFileStream = File.OpenRead(path);
        //BinaryFormatter deserializer = new BinaryFormatter();
        //List<Figure> figlist = (List<Figure>)deserializer.Deserialize(openFileStream);
        //openFileStream.Close();
        #endregion

        #region JSONDeserialization
        //using FileStream openStream = File.OpenRead(path);
        //List<Figure>? figlist =
        //    await JsonSerializer.DeserializeAsync<List<Figure>>(openStream);
        #endregion

        return figlist;
    }

}






