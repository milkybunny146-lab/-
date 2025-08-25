using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("歡迎來到『誰在一壘』！");
        Console.WriteLine("輸入名字或位置（輸入 exit 離開）：");

        // 建立字典
        Dictionary<string, string> players = new Dictionary<string, string>()
        {
            { "誰", "在一壘" },
            { "什麼", "二壘" },
            { "我不知道", "三壘" },
            { "為什麼", "左外野" },
            { "沒有人", "右外野" },
            { "因為", "中外野" },
            { "明天", "投手" },
            { "今天", "捕手" },
            { "我不管了", "游擊手" },
            { "天啊", "裁判" }
        };

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("遊戲結束！");
                break;
            }

            // 如果輸入是名字
            if (players.ContainsKey(input))
            {
                Console.WriteLine($"{input}  {players[input]}");
            }
            // 如果輸入是位置
            else if (players.ContainsValue(input))
            {
                foreach (var player in players)
                {
                    if (player.Value == input)
                    {
                        Console.WriteLine($"{input}  {player.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("查無此人！");
            }
        }
    }
}
