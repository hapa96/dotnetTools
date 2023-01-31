# dotnetTools
Collection of different dotent Tools.

## How to package a console applicaton as a dotnet tool

1. Create new Console Application
`dotnet new console -n <tool-name>`

2. Add the following to `.csproj`

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <PackAsTool>true</PackAsTool>
    <PackageOutputPath>.././tools</PackageOutputPath>
  </PropertyGroup>

</Project>
```

3. Create Nuget package for the tool using the following command
`dotnet pack -c release`

4. Install the tool as a local tool using the following command
`dotnet tool install --global --add-source ./tools <tool-name>`

5. Verify that the tool has been installed successfully by running the following command
`dotnet tool list -g`