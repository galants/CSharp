using System;
using System.Collections.Generic;
using System.Threading;
class FallingRocks
{
    static void Main(string[] args)
    {
        int width = 50;
        int height = 20;

        Console.Title = "Falling Rocks";
        Console.SetWindowSize(width, height);
        Console.SetBufferSize(width, height);
        Console.SetWindowSize(width, height);
        Console.CursorVisible = false;

        Area area = new Area(0, 0, width - 6, height);
        Player player = new Player(width - 6, height);

        do
        {
            Thread.Sleep(150);
            area.MoveElements();
            area.PrintElements();
            player.PrintPlayer();
        } while (!FallingRocks.IsGameOver(area.GetElements(), player, height));
    }

    private static bool IsGameOver(List<Element> elements, Player player, int height)
    {
        bool isGameOver = false;
        foreach (Element element in elements)
        {
            if ((element.Y == height - 1) && ((element.X - player.GetPlayer().X <= 2)&&(element.X - player.GetPlayer().X >=0)))
                isGameOver = true;
        }
        return isGameOver;
    }
}

public class Area
{
    private int startX;
    private int startY;
    private int width;
    private int height;

    private List<Element> elements;
    private List<Element> frame;

    public Area(int startX, int startY, int width, int height)
    {
        this.startX = startX;
        this.startY = startY;
        this.width = width;
        this.height = height;
        elements = new List<Element>();
        frame = setFrame();
    }
    public List<Element> GetElements()
    {
        return elements;
    }
    private List<Element> setFrame()
    {
        List<Element> frameElements = new List<Element>();


        for (int i = 0; i < height; i++)
        {
            Element el = new Element(width, i, "|");
            frameElements.Add(el);
        }

        return frameElements;
    }
    private List<Element> GenerateElement()
    {
        List<Element> newElements = new List<Element>();
        int countAddElements = Element.rnd.Next(1, width / 17);

        for (int i = 0; i < countAddElements; i++)
        {
            Element element = new Element(Element.rnd.Next(1, width - 1), 1);
            newElements.Add(element);
        }

        return newElements;
    }
    public void MoveElements()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i].Y++;
        }
        elements.RemoveAll(IsLastRow);
        List<Element> newElements = GenerateElement();
        elements.AddRange(newElements);
    }

    private bool IsLastRow(Element ele)
    {
        return ele.Y == height;
    }
    public void PrintElements()
    {
        Console.Clear();

        foreach (Element element in frame)
        {
            element.PrintElement();
        }

        foreach (Element element in elements)
        {
            element.PrintElement();
        }
    }
}

public class Element
{
    private string str;
    private string color;
    private int x;
    private int y;
    private string[] colors = { "Gray", "Blue", "Green", "Red", "Yellow", "Magenta", "Cyan", "DarkGreen", "DarkGray", "DarkBlue", "DarkRed", "DarkYellow" };
    public string[] strs = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "-" };
    public static Random rnd = new Random();

    public Element()
    {
        int rndNum = rnd.Next(0, strs.Length);
        this.Str = strs[rndNum];
        this.color = colors[rndNum];
    }
    public Element(int x, int y)
    {
        int rndNum = rnd.Next(0, strs.Length);
        this.Str = strs[rndNum];
        this.color = colors[rndNum];
        this.X = x;
        this.Y = y;
    }
    public Element(int x, int y, string str)
    {
        this.Str = str;
        this.X = x;
        this.Y = y;
        this.color = "White";
    }

    public string Str
    {
        get { return str; }
        set { str = value; }
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public void PrintElement()
    {
        try
        {
            Type type = typeof(ConsoleColor);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, color);
            Console.Write(str);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
}

public class Player
{
    private int width;
    private int height;
    private Element player;

    public Player(int width, int height)
    {
        this.width = width;
        this.height = height;
        player = new Element(width / 2, height - 1, "(0)");
    }
    public Element GetPlayer()
    {
        return player;
    }
    protected void MoveLeft()
    {
        if (player.X > 1)
            player.X--;
    }
    protected void MoveRight()
    {
        if (player.X < width - 2)
            player.X++;
    }
    public void PrintPlayer()
    {
        MovePlayer();
        player.PrintElement();
    }
    protected void MovePlayer()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.LeftArrow)
                MoveLeft();
            if (key.Key == ConsoleKey.RightArrow)
                MoveRight();
        }
    }
}
