using System;
using System.IO;

namespace Amazonia.DAL.Infraestrutura
{
    public class AmazoniaException : Exception
    {
        public AmazoniaException(string tipoErro)
        {
            var path = @"C:\Rumos\Academia Full Stack Developer\Amazonia.pt\";
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);                
            }

            var log = $"{DateTime.Now} :: {tipoErro}";
            File.WriteAllText($@"{path}log.txt", log);
        }
    }
}
