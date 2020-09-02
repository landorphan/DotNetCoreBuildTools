namespace dotnetmap.Commands
{
    using System.Collections.Generic;
    using System.CommandLine;
    using System.IO;
    using Landorphan.BuildMap.Serialization;

    public abstract class DisplayBase : ActUponBase
    {
        protected DisplayBase(string name, string description) : base(name, description)
        {
            OutputFormat = new Option<WriteFormat>(
                "--format",
                "The format to use when outputting the map. " +
                "NOTE: The Table and Text format can not be used as an input to further dotnetmap invocations.");
            OutputFormat.Argument.SetDefaultValue("Table");
            AddOption(OutputFormat);

            ItemsToDisplay = new Option<List<string>>(
                new[] {"--items", "-i"},
                "The items to display in the output.  This is only utilized for the Text or Table formats.");
            ItemsToDisplay.Argument.SetDefaultValue("All");
            AddOption(ItemsToDisplay);

            OutputFile = new Option<FileInfo>(
                new[] {"--output", "-o",},
                "The output location (if not specified output will go to standard out.");
            AddOption(OutputFile);
        }

        protected override string DescriptionMapFile => "The path to the map file to display.";
        protected Option<List<string>> ItemsToDisplay { get; set; }
        protected Option<FileInfo> OutputFile { get; set; }
        protected Option<WriteFormat> OutputFormat { get; set; }
    }
}
