#!/usr/bin/env bash
# script that inits and builds a new C# project

mkdir 1-new_project
cd 1-new_project
dotnet new console
dotnet build
