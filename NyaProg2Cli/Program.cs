using System;

namespace NyaProg2Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Указываем название скрипта и параметры
            // <project> <script> [params]
            // ./NyaProg2Cli dimmer program cpu=mega1280
            // ./NyaProg2Cli dimmer configure mac=12:12:33:44:33:22 block=12 ip=192.168.0.12
            // ./NyaProg2Cli dimmer erase
            // ./NyaProg2Cli dimmer unlock
            // ./NyaProg2Cli list
            // ./NyaProg2Cli help


            if(args.Length > 1)
            {
                string project = args[0];
            }
            else
            {
                switch(args[0])
                {
                    case "list":
                        ListProjects();
                        break;
                    case "help":
                        ShowHelp();
                        break;
                }
            }
        }

        /// <summary>
        /// Список проектов
        /// </summary>
        static void ListProjects()
        {

        }

        /// <summary>
        /// Показать справку
        /// </summary>
        static void ShowHelp()
        {
            Console.WriteLine("help - show help");
            Console.WriteLine("list - project list");
        }
    }
}
