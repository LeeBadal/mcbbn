# Chunk validator BBN

Chunk validator is a program written in [F#](https://learn.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp) that reads a file **input** that consists of chunks and returns the **index** where an invalid character is provided.
If no error is found, the program prints **-1**


### What is a chunk?
A chunk is a opening and closing of one the following:

**()**
**[]**
**{}**
**<>**

A chunk can be nested with other chunks, however there are cases of invalid chunks:

Examples of invalid chunks are:
* **(>** - wrong closing character at index 1
* **[<<>]** - wrong closing character at index 4
* **({}<>])** - unexpected closing character at index 4



## Prerequisites

* Docker CLI

## Basic Usage

Edit the file **"input"** to contain the sequence of Chunks you wish to run.


```bash
docker build -t bbn .
```

```bash
docker run --rm -t bbn
```
**NOTE**: Editing **input** requires you to rebuild the docker image.

### Tests
You can run a few basic tests by uncommenting **Program.fs** line 29-34

### Caveats 
* The program expects at least 1 character in the **index** file as we are not handling exceptions.
* Editing **input** requires you to rebuild the docker image as we are not mounting any volumes.