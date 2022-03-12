using System;
namespace DemoJson
{
    class Program
    {
        static void Main (string[] args)
        {
            string path = "D:/.net/DemoJson/jsconfig1.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);
            int value=0;
            for (int i = 0; i<data.typesofrice.Count; i++)
            {
                Console.WriteLine(data.typesofrice[i].Name);
                Console.WriteLine(data.typesofrice[i].Weight);
                Console.WriteLine(data.typesofrice[i].Price);
                value = data.typesofrice[i].Weight * data.typesofrice[i].Price;
                Console.WriteLine("Value of" +data.typesofrice[i].Name +"=" +value);
            }

            for (int i = 0; i < data.typesofgrain.Count; i++)
            {
                Console.WriteLine(data.typesofgrain[i].Name);
                Console.WriteLine(data.typesofgrain[i].Weight);
                Console.WriteLine(data.typesofgrain[i].Price);
                value = data.typesofgrain[i].Weight * data.typesofgrain[i].Price;
                Console.WriteLine("Value of" + data.typesofgrain[i].Name + "=" + value);
            }

            for (int i = 0; i < data.typesofwheat.Count; i++)
            {
                Console.WriteLine(data.typesofwheat[i].Name);
                Console.WriteLine(data.typesofwheat[i].Weight);
                Console.WriteLine(data.typesofwheat[i].Price);
                value = data.typesofwheat[i].Weight * data.typesofwheat[i].Price;
                Console.WriteLine("Value of" + data.typesofwheat[i].Name + "=" + value);
            }
        }
    }
}