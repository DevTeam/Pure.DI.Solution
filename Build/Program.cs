using HostApi;

new DotNetPack()
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
    .WithNoRestore(true)
    .Build().EnsureSuccess();

new DotNetTest()
    .WithNoBuild(true)
    .Build().EnsureSuccess();

new DotNetRun()
    .WithProject("App")
    .WithNoBuild(true)
    .Run(timeout: TimeSpan.FromMilliseconds(500));
    
new DotNetRun()
    .WithProject("PackageRefApp")
    .WithNoBuild(true)
    .Run(timeout: TimeSpan.FromMilliseconds(500));