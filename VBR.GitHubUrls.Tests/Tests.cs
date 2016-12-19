using Xunit;
using VBR.GitHubUrls;
namespace VBR.GitHubUrls.Tests{

    public class GitHubUrlsTests{
        
        string usr = "dotnet";
        string repo = "core";
        string api = "https://api.github.com/repos/dotnet/core/";
        string html = "https://github.com/dotnet/core/";
        string raw = "https://raw.githubusercontent.com/dotnet/core/";
        string userRepo = "dotnet/core";

        private void AssertResult(GitHubUrls result){
            Assert.NotNull(result);
            Assert.Equal(usr, result.UserName);
            Assert.Equal(repo, result.RepositoryName);
            Assert.Equal(api, result.ApiUrl);
            Assert.Equal(html, result.HtmlUrl);
            Assert.Equal(raw, result.RawUrl);
        }
        [Fact]
        public void TestFromHtmlUrl(){
            var result = GitHubUrls.FromHtmlUrl(html);

            AssertResult(result);
        }

        [Fact]
        public void TestFromUserNameAndRepo(){
            var result = GitHubUrls.FromUserNameAndRepo(usr, repo);
            AssertResult(result);
        }

        [Fact]
        public void TestFromUserRepoString(){
            var result = GitHubUrls.FromUserRepoString(userRepo);
            AssertResult(result);
        }
    }
}