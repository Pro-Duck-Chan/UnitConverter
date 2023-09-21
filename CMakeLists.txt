cmake_minimum_required(VERSION 3.8)

project("UnitConverter" CSharp)

set_property(DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR} PROPERTY VS_STARTUP_PROJECT UnitConverter)

add_subdirectory(UnitConverter)