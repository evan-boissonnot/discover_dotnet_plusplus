using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urlList = new[] { "http://www.google.fr", "http://devtobecurious.com", "http://apprendreparplaisir.fr" };

            var client = new HttpClient();
            var builder = new StringBuilder();

            Task[] taskList = new Task[3];

            for (int i = 0; i < urlList.Length; i++)
            {
                string url = urlList[i];

                taskList[i] = client.GetStringAsync(url).ContinueWith(request =>
                {
                    Console.WriteLine("Continue : " + i); // Here, value of i is 3 because of the time and context of i
                    return (builder.Append(request.Result)).ToString();
                });
            }

            Task.WaitAll(taskList);

            Console.WriteLine(builder.ToString());
        }
    }
}
