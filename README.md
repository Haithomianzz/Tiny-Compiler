# Tiny Compiler

A simple, educational compiler project designed to parse and analyze a subset of a programming language. This project serves as a foundational example for understanding the initial stages of compiler design principles, specifically lexical analysis and parsing.The following GitHub usernames represent the contributors to this project: [@john29-ki](https://github.com/john29-ki), [@PeterArsanious2004](https://github.com/PeterArsanious2004), [@Ahmed-Fahmy00](https://github.com/Ahmed-Fahmy00), [@Haithomianzz](https://github.com/Haithomianzz), [@RawanHany](https://github.com/RawanHanyy), [@AhmedNaguib01](https://github.com/AhmedNaguib01).

## Project Description

The Tiny Compiler is built to process a simplified language, demonstrating the core initial stages of a typical compiler. It takes source code written in this "Tiny Language" as input and performs the necessary steps to produce an intermediate representation of its structure. This project is ideal for students and developers looking to grasp the internal workings of the front-end of compilers.

## Features

* **Lexical Analysis (Scanning):** Converts the input source code into a stream of tokens.
* **Syntax Analysis (Parsing):** Builds a parse tree or abstract syntax tree (AST) from the token stream, verifying the grammatical structure of the code.
* **Error Handling:** Basic error reporting for lexical and syntax errors.

## Technologies Used

* **C#:** The primary programming language used for developing the compiler's components.

## Setup and Installation

To get a local copy up and running, follow these simple steps.

### Prerequisites

* .NET SDK (e.g., .NET 6.0 or higher)

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Haithomianzz/Tiny-Compiler.git](https://github.com/Haithomianzz/Tiny-Compiler.git)
    ```
2.  **Navigate to the project directory:**
    ```bash
    cd Tiny-Compiler
    ```
3.  **Restore dependencies and build the project:**
    ```bash
    dotnet build
    ```

## Usage

Once built, you can run the compiler from the command line, typically by providing a source file written in the Tiny Language.

```bash
dotnet run --project YourProjectName -- your_source_file.tiny
