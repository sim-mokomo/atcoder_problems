cmake_minimum_required(VERSION 3.12)
project(Atcorder)

set(CMAKE_CXX_STANDARD 14)

add_executable(Atcorder
        Problems/obj/Debug/netcoreapp2.0/Problems.AssemblyInfo.cs
        Problems/obj/Debug/netcoreapp2.0/Problems.AssemblyInfoInputs.cache
        Problems/obj/Problems.csproj.nuget.cache
        Problems/obj/Problems.csproj.nuget.g.props
        Problems/obj/Problems.csproj.nuget.g.targets
        Problems/obj/project.assets.json
        Problems/obj/project.packagespec.json
        Problems/Problems.csproj
        Problems/Program.exe
        Problems/Tutorial.cs
        Problems/Tutorial.exe
        Atcorder.sln)
