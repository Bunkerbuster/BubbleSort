# Bubble Sort Algorithm

![Bubble Sort](bubble-sort.png)

A simple implementation of the Bubble Sort algorithm in C#. Bubble Sort is a straightforward sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order.

## Table of Contents
- [About](#about)
- [Usage](#usage)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Example](#example)
- [Contributing](#contributing)
- [License](#license)

## About

This project provides a basic example of the Bubble Sort algorithm implemented in C#. It's meant for educational purposes and to demonstrate how the algorithm works.

## Usage

Bubble Sort is a simple sorting algorithm that can be used to sort arrays of data in ascending or descending order. You can use the provided implementation as a reference or a starting point for your own sorting needs.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

To run this project, you need to have:

- [.NET SDK](https://dotnet.microsoft.com/download) installed.

### Installation

1. Clone this repository to your local machine using your terminal or command prompt:

```bash
git clone https://github.com/Bunkerbuster/bubble-sort.git
```


### Example

Here's an example of how to use the Bubble Sort algorithm in C#:

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

// Sort the array using Bubble Sort
BubbleSortArray(arr);

```bash
 //if the j value of the array is bigger (J = bigger, then J+1) then the next J value (j  + 1 value) 
 // {64,34}
 // we swap the values's
 //In this case 64 is bigger then 34, en we need to swap these places
 if (UnsortedArray[j] > UnsortedArray[j + 1])
 {
    // Swap arr[j] and arr[j + 1]
    // we create a temp int, so we can place the the swapped value for save keeping
    // we store int temp = 64
    int temp = UnsortedArray[j];
    // we swapping the values, the next value smaller then j > j+1
    // 64 is replace with 34
    // j = j+1
    UnsortedArray[j] = UnsortedArray[j + 1];
    // we replace the value of j+1 with the value of the temp
    // j+1 = temp
    // 34 is replced with 64
    UnsortedArray[j + 1] = temp;
    // the result is
    // {34,64}
 }
```
