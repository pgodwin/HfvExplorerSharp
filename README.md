# HfvExplorerSharp

This is a work in progress project to build a replacement for [HfvExplorer](https://www.emaculation.com/doku.php/hfvexplorer). 

## Why?
The source code the original HFVExplorer has been lost to time. There's some features I'd like added (auto-type mapping, etc). 


### Initial focus:
 - [ ] Simple cross-platform UI to open HFV files and view files via [DiscUtils](https://github.com/DiscUtils/DiscUtils).
 - [ ] Add HFS+ Write support to DiscUtils
 - [ ] Add HFV container support to DiscUtils
 
### Long Term Plans:
 - [ ] BinHex support
 - [ ] StuffIt Expansion (eg look at how the Unarchiver code works and see if I can reimplement it in C#)
 - [ ] Extraction with Resource forks
 - [ ] Creator/Type mapping
 - [ ] Direct Drive access
 - [ ] Support other formats supported by DiscUtils
  
  
## Resources
Many resources will be called on for this project to see how things work
 - [HFS Utilities](https://www.mars.org/home/rob/proj/hfs/)
 - [HFSExplorer](http://www.catacombae.org/hfsexplorer/) Is a mature tool available today with more features than I plan to add.
 - [DiscUtils](https://github.com/DiscUtils/DiscUtils) is a C# library for reading and writing various containers and filesystems. 

## License
TBA - will be dicated by libraries, code used. Happy for MIT, BSD or similar.

 
 
 

 