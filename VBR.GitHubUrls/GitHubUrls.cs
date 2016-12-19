using System;

namespace VBR.GitHubUrls{
    public class GitHubUrls{

        public string UserName { get; set; }
        public string RepositoryName { get; set; }
        public string HtmlUrl { get; set; }
        public string ApiUrl { get; set; }
        public string RawUrl { get; set; }
        public string UserRepo { get; set; }

        public static GitHubUrls FromHtmlUrl(string htmlUrl){
            if(string.IsNullOrEmpty(htmlUrl)){
                throw new ArgumentNullException(nameof(htmlUrl));
            }

            var url = new Uri(htmlUrl);
            var path = url.LocalPath;
            return FromUserRepoString(path);
        }

        public static GitHubUrls FromUserNameAndRepo(string username, string repo){
            if(string.IsNullOrEmpty(username)){
                throw new ArgumentNullException(nameof(username));
            }
            if(string.IsNullOrEmpty(repo)){
                throw new ArgumentNullException(nameof(repo));
            }

            var result = new GitHubUrls{
                UserName = username,
                RepositoryName = repo,
                ApiUrl = $"https://api.github.com/repos/{username}/{repo}/",
                HtmlUrl = $"https://github.com/{username}/{repo}/",
                RawUrl = $"https://raw.githubusercontent.com/{username}/{repo}/",
                UserRepo = $"{username}/{repo}"
            };
            
            return result;
        }
        
        public static GitHubUrls FromUserRepoString(string userRepo){
            if(string.IsNullOrEmpty(userRepo)){
                throw new ArgumentNullException(nameof(userRepo));
            }

            var userAndRepo = userRepo.Split(new char[]{'/'}, StringSplitOptions.RemoveEmptyEntries);
            if(userAndRepo.Length <= 0){
                throw new ArgumentException($"given ${nameof(userRepo)} with value {userRepo} is invalid", nameof(userRepo));
            }

            var user = userAndRepo[0];
            var repo = userAndRepo[1];
            
            return FromUserNameAndRepo(user, repo);
        }


    }
}