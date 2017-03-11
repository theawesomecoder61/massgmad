# massgmad
A utility that extracts all Garry's Mod addons (`.gma`) in a user-specified folder

![](http://i.imgur.com/a4yGpM0.png)
massgmad version 2.0 running on Windows 10

## Downloads
Go to the [releases page](https://github.com/theawesomecoder61/massgmad/releases) for the current version and a nice changelog.

## Instructions
1. Download the latest version of massgmad, assuming Java is installed on your computer.
2. Run the `.jar`, either by double-clicking it, or by executing `java -jar path\to\massgmad.jar` in your favorite terminal.
3. Click **Locate gmad** and find *gmad*. Listed below are the default locations of gmad.
  1. Windows: C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\bin\gmad.exe
  2. macOS: *Coming soon*
  3. Linux: *Coming soon*
4. Click **Locate Input Folder**. The folder must contain at least 1 `.gma` file. Once you choose an input folder, a list of all the `.gma` files will appear in massgmad.
5. Click **Locate Output Folder**. Locate a folder where massgmad can extract the `.gma` files.
6. Click **Extract All gma Files**. massgmad will begin extracting all the `.gma` files found in the input folder. Here are some precautions.
  1. **BE PATIENT**
  2. **DO NOT TOUCH/INTERACT WITH MASSGMAD**
  3. **DO NOT TOUCH/KILL ANY JAVA PROCESS**
  4. or else massgmad will not finish extracting
7. massgmad will do its extraction. Unfortunately, it can not go any faster. 

## Building
I used IntelliJ IDEA 2016.3.2 to create massgmad, so I recommend downloading (or using git) the repo and open it in IntelliJ IDEA.

If you do not have IntelliJ IDEA or too lazy to install it, you could try to grab the `.java` files and use them in your favorite Java IDE, then compile them.

## Differences from the older version
1. written in Java
2. supports folders with spaces
3. multiplatform (untested on macOS and Linux, support coming soon)
4. more stable

## Lastly
**massgmad is released under the MIT License.**

Garry's Mod is a registered trademark of Facepunch Studios. massgmad and its author are not affiliated with Facepunch Studios.
