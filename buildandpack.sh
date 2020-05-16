# clean
rm -f *.nupkg

# clean android build
MSBuild FluentUI.Android/FluentUI.Android.csproj /t:Clean /p:Configuration=Release

# clean ios build
MSBuild FluentUI.iOS/FluentUI.iOS.csproj /t:Clean /p:Configuration=Release

# build android project
MSBuild FluentUI.Android/FluentUI.Android.csproj  /p:Configuration=Release

# build ios project
MSBuild FluentUI.iOS/FluentUI.iOS.csproj  /p:Configuration=Release
