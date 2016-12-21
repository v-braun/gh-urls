# VBR.GitHubUrls 
> resolves API, HTML and RAW Urls for GitHub repositories

By [v-braun - www.dev-things.net](http://www.dev-things.net). 


[![AppVeyor](https://img.shields.io/appveyor/ci/v-braun/gh-urls.svg?style=flat-square)](https://ci.appveyor.com/project/v-braun/gh-urls)
[![NuGet](https://img.shields.io/nuget/v/VBR.GitHubUrls.svg?style=flat-square)](https://www.nuget.org/packages/VBR.GitHubUrls/)


## Installation

### PowerShell

```PowerShell
Install-Package VBR.GitHubUrls
```

### project.json

```json
  "dependencies": {
    "VBR.GitHubUrls": "*"
  }
```

## Usage
See the *VBR.GitHubUrls.Tests* Project.

```cs
using VBR.GitHubUrls;

static Main(){

    GitHubUrls urls;
    urls = GitHubUrls.FromHtmlUrl("https://github.com/dotnet/core/");
    // or:
    urls = GitHubUrls.FromUserRepoString("dotnet/core/");
    // or:
    urls = GitHubUrls.FromUserNameAndRepo("dotnet", "core");

    // urls:
    // UserName = dotnet,
    // RepositoryName = core,
    // ApiUrl = $"https://api.github.com/repos/dotnet/core/",
    // HtmlUrl = $"https://github.com/dotnet/core/",
    // RawUrl = $"https://raw.githubusercontent.com/dotnet/core/",
    // UserRepo = $"dotnet/core"
    
}

```


### Known Issues

If you discover any bugs, feel free to create an issue on GitHub fork and
send me a pull request.

[Issues List](https://github.com/v-braun/gh-urls/issues).

## Authors

![image](https://avatars3.githubusercontent.com/u/4738210?v=3&s=50)  
[v-braun](https://github.com/v-braun/)



## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request


## License

See [LICENSE](https://github.com/v-braun/gh-urls/blob/master/LICENSE).
