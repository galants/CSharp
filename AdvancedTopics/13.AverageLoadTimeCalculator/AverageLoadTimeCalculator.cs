using System;
using System.Collections.Generic;
using System.Linq;

internal class AverageLoadTimeCalculator
{
    private static void Main(string[] args)
    {
        List<ConnectData> connectData = new List<ConnectData>();
        string str = Console.ReadLine();

        while (str != string.Empty)
        {
            string[] strArr = str.Split(new char[] {' '});
            ConnectData data = new ConnectData(strArr[2], double.Parse(strArr[3]));

            connectData.Add(data);
            str = Console.ReadLine();
        }

        var result = from i in connectData
            group i by i.Url
            into g
            select new {Url = g.Key, LoadTime = g.Average(t => t.LoadTime)};
        //new { Group = g.Key, ItemCount = g.Count() };

        foreach (var element in result)
            Console.WriteLine("{0} -> {1}", element.Url, element.LoadTime);
    }
}

public class ConnectData
{
    private string url;
    private double loadTime;

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public double LoadTime
    {
        get { return loadTime; }
        set { loadTime = value; }
    }

    public ConnectData(string strUrl, double ts)
    {
        url = strUrl;
        loadTime = ts;
    }
}