cmake_minimum_required(VERSION 3.8)

enable_language(CSharp)

project(UnitConverter LANGUAGES CSharp)

include(CSharpUtilities)

add_executable(UnitConverter
	Program.cs
	Converter.cs
	Units.cs
	ErrorHandler.cs
)

set(CMAKE_DOTNET_SDK “Microsoft.NET.Sdk”)
set(CMAKE_DOTNET_TARGET_FRAMEWORK “net48”)

set_property(TARGET UnitConverter PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8")
set(CMAKE_CSharp_FLAGS "/langversion:latest")

set_property(TARGET UnitConverter PROPERTY VS_DOTNET_REFERENCES
  "Microsoft.CSharp"
  "System"
  "System.Collections.Generic"
)