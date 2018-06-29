using System;
using System.IO;
using System.Linq;

namespace replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1){
                Console.WriteLine("Passe o caminho como parametro");
            }else{
                ReadFiles(args[0]);
            }
        }

        static void ReadFiles(string path){
            Console.WriteLine(path);
            Console.WriteLine("Carregando quantidade de arquivos na pasta.");
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.EnumerateFiles();
            //Directory.EnumerateFiles(path,SearchOption.TopDirectoryOnly);
            Console.WriteLine(files.Count());
            //foreach(var file in files){
                //Console.WriteLine(file);

            //}
        }
    }
}
