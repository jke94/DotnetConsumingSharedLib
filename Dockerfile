FROM ubuntu:latest
RUN apt-get update && apt-get install -y \
    cmake \
    g++ \
    && rm -rf /var/lib/apt/lists/*
COPY /Native/NativeLibrary /NativeLibrary
# COPY /HeroesClient /HeroesClient
WORKDIR /NativeLibrary/build
RUN cmake ..
RUN make
RUN make install
# WORKDIR /HeroesClient/build
# RUN cmake ..
# RUN make
CMD ["ls", "-l"]