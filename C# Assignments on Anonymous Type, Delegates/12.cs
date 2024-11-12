using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
  public class Download
    {
        public static async Task DownloadDataAsyn(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.WriteLine("started to download");
                    string data = await client.GetStringAsync(url);
                    //gets data
                    Console.WriteLine("Download complete. Length" + data.Length);
                    //display  length of  data
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                //catch http request exception
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public static async void Call(string url)
        {
            await DownloadDataAsyn(url);
        }
    }
}
