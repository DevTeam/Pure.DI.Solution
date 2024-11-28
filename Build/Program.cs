using HostApi;

new DotNetPack()
    .WithConfiguration("Release")
    .WithProject("Lib")
    .WithOutput(".packages")
    .WithWorkingDirectory(".")
    .Build().EnsureSuccess();

new DotNetRestore()
    .WithSources(".packages", "https://api.nuget.org/v3/index.json")
    .WithNoCache(true)
    .WithForce(true)
    .Build().EnsureSuccess();

new DotNetBuild()
    .WithConfiguration("Release")
    .WithNoRestore(true)
    .Build().EnsureSuccess();

new DotNetTest()
    .WithConfiguration("Release")
    .WithNoBuild(true)
    .Build().EnsureSuccess();

new DotNetRun()
    .WithConfiguration("Release")
    .WithProject("App")
    .WithNoBuild(true)
    .Run(timeout: TimeSpan.FromMilliseconds(500));
    
new DotNetRun()
    .WithConfiguration("Release")
    .WithProject("PackageRefApp")
    .WithNoBuild(true)
    .Run(timeout: TimeSpan.FromMilliseconds(500));