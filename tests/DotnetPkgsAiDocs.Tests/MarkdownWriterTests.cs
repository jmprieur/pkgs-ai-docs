using DotnetPkgsAiDocs.Output;
using DotnetPkgsAiDocs.Analysis;
using Xunit;

namespace DotnetPkgsAiDocs.Tests;

public class MarkdownWriterTests
{
    [Fact]
    public void WriteDependencyGraphPerTfm_ProducesFilePerTfm()
    {
        var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(tempDir);
        try
        {
            var deps = new List<ResolvedDependency>
            {
                new("Microsoft.Extensions.Logging", "8.0.0", ">= 8.0.0")
            };
            var results = new List<DependencyResult>
            {
                new("TestPackage", "1.0.0", "net8.0", deps),
                new("TestPackage", "1.0.0", "net9.0", deps)
            };

            var files = MarkdownWriter.WriteDependencyGraphPerTfm(tempDir, results, []);

            Assert.Equal(2, files.Count);
            Assert.Contains(files, f => f.EndsWith("dependencies-net8.0.md"));
            Assert.Contains(files, f => f.EndsWith("dependencies-net9.0.md"));

            var content = File.ReadAllText(files.First(f => f.Contains("net8.0")));
            Assert.Contains("# Transitive Dependency Graph", content);
            Assert.Contains("## TestPackage 1.0.0", content);
            Assert.Contains("Microsoft.Extensions.Logging >= 8.0.0", content);
        }
        finally
        {
            Directory.Delete(tempDir, recursive: true);
        }
    }

    [Fact]
    public void WritePublicApiPerTfm_ProducesFilePerTfm()
    {
        var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(tempDir);
        try
        {
            var results = new List<PublicApiResult>
            {
                new("TestPackage", "1.0.0", "net8.0", new[] { "TestNamespace.TestClass (class)", "TestNamespace.TestClass.DoSomething() -> void" })
            };

            var files = MarkdownWriter.WritePublicApiPerTfm(tempDir, results);

            Assert.Single(files);
            Assert.Contains(files, f => f.EndsWith("public-api-net8.0.md"));

            var content = File.ReadAllText(files[0]);
            Assert.Contains("# Public API Surface", content);
            Assert.Contains("## TestPackage 1.0.0", content);
            Assert.Contains("TestNamespace.TestClass (class)", content);
            Assert.Contains("TestNamespace.TestClass.DoSomething() -> void", content);
        }
        finally
        {
            Directory.Delete(tempDir, recursive: true);
        }
    }
}
