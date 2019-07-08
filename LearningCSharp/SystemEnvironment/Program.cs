using System;

namespace SystemEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Environment.CurrentDirectory - \'{Environment.CurrentDirectory}\'");
            Console.WriteLine($"Environment.Is64BitOperatingSystem \'{Environment.Is64BitOperatingSystem}\'");
            Console.WriteLine($"Environment.HasShutdownStarted - \'{ Environment.HasShutdownStarted}\'");
            Console.WriteLine($"Environment.Is64BitProcess - \'{Environment.Is64BitProcess}\'");
            Console.WriteLine($"Environment.MachineName - \'{Environment.MachineName}\'");
            Console.WriteLine($"Environment.OSVersion - \'{Environment.OSVersion}\'");
            Console.WriteLine($"Environment.ProcessorCount - \'{Environment.ProcessorCount}\'");
            Console.WriteLine($"Environment.StackTrace - \'{Environment.StackTrace}\'");
            Console.WriteLine($"Environment.SystemDirectory - \'{Environment.SystemDirectory}\'");
            Console.WriteLine($"Environment.SystemPageSize - \'{Environment.SystemPageSize}\'");
            Console.WriteLine($"Environment.UserDomainName - \'{Environment.UserDomainName}\'");
            Console.WriteLine($"Environment.UserInteractive - \'{Environment.UserInteractive}\'");
            Console.WriteLine($"Environment.UserName - \'{Environment.UserName}\'");
            Console.WriteLine($"Environment.Version - \'{Environment.Version}\'");
            Console.WriteLine($"Environment.WorkingSet - \'{Environment.WorkingSet}\'");

            Console.WriteLine($"Environment.GetLogicalDrives() - \'{Environment.GetLogicalDrives()}\'");
            Console.WriteLine($"Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic) - \'{Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic)}\'");
            Console.WriteLine($"Environment.GetFolderPath(Environment.SpecialFolder.Windows) - \'{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\'");
            Console.ReadKey();
        }
    }
}
