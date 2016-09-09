# PressureSpotFixer
Hides pressure spots (white spots) on damaged screens by masking it with an image overlay. 
Demo + tutorial on how to make a fixer image: [Youtube PSF demo + tutorial](https://www.youtube.com/watch?v=wVMYFsYldGc)

## What it does do
PSF hides the pressure mark by applying an image overlay on your screen which reduces the brightness un that spot. The application is very lightweight and doesn't impact performance or battery life. 

## What it doesn't do
The application doesn't physically change your screen.

## Install & config
### Install
Download the exe and fixerDummy from the Download directory on this repository. No installation required
### Enable on startup
Just put a shortcut to the exe in your startup folder. ( to acces your startup folder, press the keys Win + R, type shell:startup, press enter)
### How to make the fixer image
See example on Youtube: [Youtube PSF demo + tutorial](https://www.youtube.com/watch?v=wVMYFsYldGc)

I used the GIMP and slowly kept adding dots by using the PaintBrush tool with the opacity very low and by setting the PaintBrush to 'incremental'. Use the Blur tool to smooth out the dots.


## Bugs
### No proper multi-monitor support. 
If you're using a laptop in a dual monitor config, there's no problem if your laptop is the leftmost screen. If it isn't, the fixer image will be shown at the wrong screen. This happens because the application saves it's position from the leftmost top corner. Just to be clear: it does work with virtual desktops (on Win10)

