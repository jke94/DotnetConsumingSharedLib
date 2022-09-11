cmake_minimum_required(VERSION 3.12)
project (NativeLibrary)
set(CMAKE_CXX_STANDARD 20)

include_directories(${CMAKE_CURRENT_SOURCE_DIR}/include)
add_library(NativeLibrary SHARED src/NativeLibrary.cpp src/NativeLogic.cpp)

install(TARGETS NativeLibrary DESTINATION /usr/lib)
install(FILES include/NativeLibrary.h DESTINATION include)