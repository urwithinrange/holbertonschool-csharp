#!/usr/bin/env bash
# script that inits and builds a new C# project

mkdir 2-new_project
cd 2-new_project
dotnet new console
dotnet build
dotnet run
