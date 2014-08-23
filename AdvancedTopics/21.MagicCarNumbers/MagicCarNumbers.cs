using System;
using System.Collections.Generic;
using System.Linq;
class MagicCarNumbers
{
    private static string[] listSymbol = { "A", "B", "C", "E", "H", "K", "M", "P", "T", "X" };
    private static int weight = 0;
    private static List<string> listCarNum = new List<string>();
    static void Main(string[] args)
    {
        weight = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k < listSymbol.Length; k++)
                {
                    for (int l = 0; l < listSymbol.Length; l++)
                    {
                        Check(i, j, k, l);
                    }
                }
            }
        }

        var result = listCarNum.Distinct().ToList();
        Console.WriteLine(result.Count);
    }
    static void CheckCarNum(string carNum)
    {
        CarNumber carNumber = new CarNumber(weight);

        carNumber.CarNum = carNum;

        if (carNumber.IsMagicNum())
        {
            listCarNum.Add(carNum);
        }
    }

    static void Check(int a, int b, int x, int y)
    {
        string strCarNum;
        if (a != b)
        {
            strCarNum = "CA" + a + a + a + a + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
            strCarNum = "CA" + a + b + b + b + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
            strCarNum = "CA" + a + a + a + b + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
            strCarNum = "CA" + a + a + b + b + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
            strCarNum = "CA" + a + b + a + b + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
            strCarNum = "CA" + a + b + b + a + listSymbol[x] + listSymbol[y];
            CheckCarNum(strCarNum);
        }
    }
}

public class CarNumber
{
    string carNum;
    int weight;
    Dictionary<string, int> weightCarNumberChar = new Dictionary<string, int>();

    public CarNumber(int weight)
    {
        this.weight = weight;
        weightCarNumberChar["A"] = 10;
        weightCarNumberChar["B"] = 20;
        weightCarNumberChar["C"] = 30;
        weightCarNumberChar["E"] = 50;
        weightCarNumberChar["H"] = 80;
        weightCarNumberChar["K"] = 110;
        weightCarNumberChar["M"] = 130;
        weightCarNumberChar["P"] = 160;
        weightCarNumberChar["T"] = 200;
        weightCarNumberChar["X"] = 240;
    }

    public string CarNum
    {
        get { return carNum; }
        set { carNum = value; }
    }
    public bool IsMagicNum()
    {
        int weightCarNum = 40;

        for (int i = 2; i < 6; i++)
            weightCarNum += int.Parse(carNum[i].ToString());

        weightCarNum += GetWeight(6);
        weightCarNum += GetWeight(7);

        if (weight == weightCarNum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private int GetWeight(int position)
    {
        string str = carNum[position].ToString();
        int result = 0;

        foreach (var element in weightCarNumberChar)
        {
            if (element.Key == str)
                result = element.Value;
        }


        return result;
    }
}
