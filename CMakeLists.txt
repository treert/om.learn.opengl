cmake_minimum_required(VERSION 3.0)

project(LearnOpenGL)

set(PROJECT_VERSION_MAJOR "3")
set(PROJECT_VERSION_MINOR "2")
set(PROJECT_VERSION_PATCH "1")
set(PROJECT_VERSION_EXTRA "")
set(PROJECT_VERSION "${PROJECT_VERSION_MAJOR}.${PROJECT_VERSION_MINOR}")
set(PROJECT_VERSION_FULL "${PROJECT_VERSION}.${PROJECT_VERSION_PATCH}${PROJECT_VERSION_EXTRA}")





AUX_SOURCE_DIRECTORY(src v_SRC)

add_executable(demo ${v_SRC})


INCLUDE_DIRECTORIES(include)
INCLUDE_DIRECTORIES("$ENV{XLibrary}/OpenGL/Libs/include")

find_library(v_glfw3 glfw3 $ENV{XLibrary}/OpenGL/Libs/lib)
if(NOT v_glfw3)
message(FATAL_ERROR "glfw3 not found")
endif()

TARGET_LINK_LIBRARIES(demo ${v_glfw3} opengl32)