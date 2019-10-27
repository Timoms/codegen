# Codegen

University Project for explaining a codegenerator (part of compiler). Its created with C# as a console application.

The main goal is to show the audience how assembly code is generated out of three-adress-code.

## Accepted input

The code.exe accepts a file called _'z.dat'_ in the root of the project. Its filled with three-adress-code, **one per line.**

There is no "input" command, just put a text file named as mentioned above and the program will show you the generated output.

## Example Input

    p:=3 q:=p+4

There is no real "default" set of commands to use.
This generator is only used to demonstrate the basics of a codegenerator.
I've tried to visualize used registers, might need some work to be done but in general it should work with some tweaks.

## Can I use this project?

Sure, go ahead and make it yours.
I really don't need any credits, but if you want you can always mention me in your presentation.
If you have any questions about a compiler (or the codegenerator itself) feel free to ask.

Check the PDF in the `paper` folder to find out more about how the mentioned part of the compiler works.
