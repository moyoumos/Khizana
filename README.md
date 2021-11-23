# Khizana
Redox is a Unix-like microkernel operating system written in the programming language Rust, which has a focus on safety, stability, and performance.[4][5][6] Redox aims to be secure, usable, and free. Redox is inspired by prior kernels and operating systems, such as SeL4, MINIX, Plan 9, and BSD. It is similar to GNU and BSD, but is written in a memory-safe language.[7] It is free and open-source software distributed under an MIT License.


Contents
1	Design
2	Components
3	Command-line applications
4	Graphical applications
5	History
6	References
7	External links
Design
The Redox operating system is designed to be secure.[4] This is reflected in two design decisions:

Using the programming language Rust for implementation
Using a microkernel design, similar to MINIX
Components
Redox provides packages (memory allocator, file system, display manager, core utilities, etc.) that together make up a functional operating system. Redox relies on an ecosystem of software written in Rust by members of the project.

Redox kernel – derives from the concept of microkernels, with inspiration from MINIX
Ralloc – memory allocator
TFS file system – inspired by the ZFS file system
Ion shell – the underlying library for shells and command execution in Redox, and the default shell
pkgutils – package manager
Orbital windowing system – display and window manager, sets up the orbital: scheme, manages the display, and handles requests for window creation, redraws, and event polling
relibc – C standard library
Command-line applications
Redox supports command-line interface (CLI) programs, including:

Sodium – vi-like editor that provides syntax highlighting
Rusthello – advanced Reversi AI; is highly concurrent, serving as proof of Redox's multithreading abilities; supports various AI strategies, such as brute forcing, minimax, local optimizations, and hybrid AIs
Graphical applications
Redox supports graphical user interface (GUI) programs, including:

NetSurf – a lightweight web browser which uses its own layout engine
Calculator – a software calculator which provides functions similar to the Windows Calculator program
Editor – simple text editor, similar to Microsoft Notepad
File Browser – a file manager that displays icons, names, sizes, and details for files; uses the launcher command to open files when they are clicked
Image Viewer – Image viewer for simple file types
Pixelcannon – 3D renderer, can be used to benchmark the Orbital desktop
Orbterm – ANSI type terminal emulator
