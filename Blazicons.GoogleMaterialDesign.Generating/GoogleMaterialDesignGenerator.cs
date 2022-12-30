using Blazicons.Generating;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.Threading;

namespace Blazicons.GoogleMaterialDesign.Generating;

[Generator]
internal class GoogleMaterialDesignGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        using var taskContext = new JoinableTaskContext();
        var taskFactory = new JoinableTaskFactory(taskContext);
        var downloader = new RepoDownloader(new Uri(Properties.Resources.DownloadAddress));
        taskFactory.Run(
            async () =>
            {
                await downloader.Download(@"^svg\/.*.svg$").ConfigureAwait(true);
            });

        var svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "svg", "outlined");
        context.WriteIconsClass("GoogleMaterialOutlinedIcon", svgFolder);

        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "svg", "filled");
        context.WriteIconsClass("GoogleMaterialFilledIcon", svgFolder);

        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "svg", "round");
        context.WriteIconsClass("GoogleMaterialRoundIcon", svgFolder);

        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "svg", "sharp");
        context.WriteIconsClass("GoogleMaterialSharpIcon", svgFolder);

        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "svg", "two-tone");
        context.WriteIconsClass("GoogleMaterialTwoToneIcon", svgFolder);

        downloader.CleanUp();
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // required by ISourceGenerator
    }
}