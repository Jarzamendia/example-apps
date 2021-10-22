using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Console;

namespace example_app
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WriteLine();
            WriteLine($"{GetVsoft()}");
          
            WriteLine("Environment:");
            WriteLine(RuntimeInformation.FrameworkDescription);
            WriteLine(RuntimeInformation.OSDescription);

            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
               // Console.WriteLine($"Counter: {++counter}");
                Console.WriteLine("Pod {0} diz: {1}", Environment.MachineName, (++counter));

                await Task.Delay(1000);
            }
        }

        private static string GetVsoft() {
                
        return @"
                 _  __     _                          _            
                | |/ /    | |                        | |           
                | ' /_   _| |__   ___ _ __ _ __   ___| |_ ___  ___ 
                |  <| | | | '_ \ / _ \ '__| '_ \ / _ \ __/ _ \/ __|
                | . \ |_| | |_) |  __/ |  | | | |  __/ ||  __/\__ \
                |_|\_\__,_|_.__/ \___|_|  |_| |_|\___|\__\___||___/
                __          __        _        _                 
                \ \        / /       | |      | |                
                 \ \  /\  / /__  _ __| | _____| |__   ___  _ __  
                  \ \/  \/ / _ \| '__| |/ / __| '_ \ / _ \| '_ \ 
                   \  /\  / (_) | |  |   <\__ \ | | | (_) | |_) |
                    \/  \/ \___/|_|  |_|\_\___/_| |_|\___/| .__/ 
                                                          | |    
                                                          |_|";
        }
    }
}
