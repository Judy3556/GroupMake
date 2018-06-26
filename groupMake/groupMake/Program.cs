using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupMake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 輸入全班資料
            string[] name = { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠", "陳昱嘉", "康珈熏", "盧奕宏", "黃博涵", "遲正雯", "世新林星彤", "許晏誠　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "世新陳柏霖", "世新許子安", "世新方若帆" };

            //定義廻圈執行次數
            int j = 1;

            // 亂數產生
            Random rand = new Random();

            // 把所有的名字放入List
            List<string> numbers = new List<string>();

            // 確定分組方式
            Console.WriteLine();
            Console.WriteLine(" 班上同學隨機分組系統");
            Console.WriteLine("請輸入每組人數");

            // 定義每組人數
            int peopleNumber = int.Parse(Console.ReadLine());

            if (peopleNumber < 2 || peopleNumber > 10)
            {
                Console.WriteLine("拒絕執行");
                Console.ReadLine();
            }
            else
            {

                for (int i = 0; i < name.Length; i++)
                {
                    numbers.Add(name[i]);
                }
            }



            // 定義組數
            int teamNumber = numbers.Count / peopleNumber;

            // 定義多出來的人數
            int noGroup = numbers.Count % peopleNumber;

            // 定義另一個多出來的人數
            int nogroup = noGroup;

            while (j <= teamNumber)
            {
                Console.WriteLine("第"+j+"組的人有");

                for (int i = 0; i <peopleNumber; i++)
                {
                    if (noGroup > 0 && nogroup==noGroup)
                    {
                        int r = rand.Next(0, numbers.Count);
                        Console.WriteLine( numbers[r] + " ");

                        //刪除選出
                        numbers.RemoveAt(r);
                        noGroup--;
                    }
                    int n = rand.Next(0, numbers.Count);
                    Console.WriteLine( numbers[n] + " ");
                    numbers.RemoveAt(n);
                }
                nogroup--;
                Console.WriteLine("");
                j++;
            }
            Console.ReadLine();

        }
    }
}
