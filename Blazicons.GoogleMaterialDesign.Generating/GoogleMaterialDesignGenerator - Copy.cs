//using Blazicons.Generating;
//using CodeCasing;
//using Microsoft.CodeAnalysis;
//using Microsoft.VisualStudio.Threading;

//namespace Blazicons.GoogleMaterialDesign.Generating;

//[Generator]
//internal class GoogleMaterialDesignGenerator : ISourceGenerator
//{
//    public void Execute(GeneratorExecutionContext context)
//    {
//        using var taskContext = new JoinableTaskContext();
//        var taskFactory = new JoinableTaskFactory(taskContext);
//        var downloader = new RepoDownloader(new Uri("https://github.com/google/material-design-icons/archive/refs/heads/master.zip"));
//        taskFactory.Run(
//            async () =>
//            {
//                await downloader.Download("symbols\\/web\\/[^\\/]*\\/[^\\/]*\\/\\w*\\.svg$").ConfigureAwait(true);
//            });

//        var svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "assets");
//        context.WriteIconsClass("GoogleMaterialIcon", svgFolder, "*_24px.svg", GetPropertyName, x => FileNameFilter(x, "_24px.svg"));

//        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "assets");
//        context.WriteIconsClass("GoogleMaterialFilledIcon", svgFolder, "*_24px.svg", GetPropertyName, x => FileNameFilter(x, "_fill1_24px.svg"));

//        downloader.CleanUp();
//    }

//    public void Initialize(GeneratorInitializationContext context)
//    {
//    }

//    private bool FileNameFilter(string fullFileName, string suffix)
//    {
//        var fileName = Path.GetFileName(fullFileName);
//        var iconFolder = Path.GetFileName(Path.GetDirectoryName(fullFileName));

//        return fileName == $"{iconFolder}{suffix}";
//    }

//    private string GetPropertyName(string fileName)
//    {
//        const string replaceTarget = "_24px";
//        var result = Path.GetFileNameWithoutExtension(fileName);
//        result = result.Replace(replaceTarget, string.Empty);
//        return result.ToPascalCase();
//    }
//}