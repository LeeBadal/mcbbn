# Chunk validator BBN

Chunk validator is a program written in [F#](https://learn.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp) that reads a file **input** that consists of chunks and returns the **index** where an invalid character is provided.


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

Clone the repo and navigate to the **bbn** directory

Edit the file **"input"** to contain the sequence of Chunks you wish to run.


```bash
docker build -t bbn .
```

```bash
docker run --rm -t bbn
```

### Tests
You can run a few tests cases by using 