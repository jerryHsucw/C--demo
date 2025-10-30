using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== 程式開始執行 ===\n");
                
                var person = new Person("John", 25);
                person.Introduce();
                
                Console.WriteLine("\n=== 程式執行成功 ===");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("所有操作都成功完成！");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n=== 程式執行失敗 ===");
                Console.WriteLine($"錯誤訊息: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("\n程式執行完畢");
#if DEBUG
                Console.WriteLine("按任意鍵結束...");
                Console.ReadKey(true);
#endif
            }
        }
    }
}
