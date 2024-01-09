using System.CommandLine;
var bundleCommand = new Command("bundle", "bundle code file's to a single file");
var rootCommand = new RootCommand("Root command for file bundler CLI");
bundleCommand.SetHandler(() => {
    Console.WriteLine("bundle command");
});    
rootCommand.AddCommand(bundleCommand);
rootCommand.InvokeAsync(args);
