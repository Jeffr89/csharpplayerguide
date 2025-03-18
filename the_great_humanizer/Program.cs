
using Humanizer;

System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en");
System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en");

Console.WriteLine($"When is the feast? {DateTime.UtcNow.AddHours(30)}");
Console.WriteLine($"When is the feast? {DateTime.UtcNow.AddHours(50).Humanize()}");