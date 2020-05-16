# clean
rm -f *.nupkg

# clean android build
MSBuild FluentUI.Android/FluentUI.Android.csproj /t:Clean /p:Configuration=Release

# clean ios build
MSBuild FluentUI.iOS/FluentUI.iOS.csproj /t:Clean /p:Configuration=Release

# clean visual build
MSBuild FluentUI.Visual/FluentUI.Visual.csproj /t:Clean /p:Configuration=Release

# build android project
MSBuild FluentUI.Android/FluentUI.Android.csproj  /p:Configuration=Release -t:pack

# build ios project
MSBuild FluentUI.iOS/FluentUI.iOS.csproj  /p:Configuration=Release -t:pack

# build Xamarin.Forms.Visual
MSBuild FluentUI.Visual/FluentUI.Visual.csproj  /p:Configuration=Release -t:pack
