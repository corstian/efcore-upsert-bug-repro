using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace efcore_upsert_experiments
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var context = new UpsertDbContext())
            {
                context.Database.Migrate();
            }

            using (var context = new UpsertDbContext()) {
                Console.WriteLine("Hello World!");

                var t = new TSomething()
                {
                    Id = -1,
                    False = true
                };

                await context.TSomethings
                    .Upsert(t)
                    .RunAsync();

                Console.WriteLine(t.Id);

                Console.ReadKey();
            }
        }
    }
}
