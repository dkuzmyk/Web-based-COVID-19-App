using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            
						var host = new WebHostBuilder()
							.UseKestrel()
							.UseUrls("http://*:3000")
							.UseContentRoot(Directory.GetCurrentDirectory())
							.UseStartup<Startup>()
							.Build();

						host.Run();

            //get input values:
                string input;
                //int year;
                date startdate;
                char region;
                bool isIntegerInput;
            System.Console.Write("Enter State Dater> ");
      input = System.Console.ReadLine();
      
      isIntegerInput = System.Int32.TryParse(input, out startdate);
      //isIntegerInput = System.Int32.TryParse(input, out region);

          //Build SQL based on user's input here
      string sql;
      if (isIntegerInput)
      {
          if ( 20200304< startdate && startdate < 20200401)
          {
            //
            // area:
            // 
            sql = string.Format(@"
SELECT state, Count(*) 
FROM us_states_covid19_daily 
GROUP BY state;",
startdate);
          }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
