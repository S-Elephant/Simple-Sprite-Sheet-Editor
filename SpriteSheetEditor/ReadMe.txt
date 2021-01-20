==============================================================================
=                                  General                                   =
==============================================================================
Created by Squirting Elephant

This application allows you to efficiently split, merge, reposition, etc.
sprites in or for sprite sheets. These operations are often performed by 2D
game creators.

The portable version still requires the .NET framework 4.0 to be installed.
Every up to date Windows PC should have it.

==============================================================================
=                               Known Issues                                 =
==============================================================================
- Crashes when splitting huge bitmaps.
- Crashes when flashing huge bitmaps or by creating a huge bitmap (your
  computer will run out of RAM).


==============================================================================
=                                 Changes                                    =
==============================================================================

Version 1.0.5 (August 18 2012):
- Added a new tab "Flash It".
- Did some code refactoring.
- Fixed a few spelling mistakes.
- Changed the font in the About-tab.

Version 1.0.4:
- Fixed readme line width.
- Added a status bar.
- Added a basic color replacer to the Split tab.
- Extended the drag&drop on the Merge tab to allow drops on the image.

Version 1.0.3:
- Added a new tab for creating/previewing maps. Supports 5 layers.
- Added a new split property.
- Added drag and drop functionality to the split and preview tabs.
- Added tooltips.

Version 1.0.2:
- Changed the about window.
- Fixed the version number in the title bar.
- Added a new button to the preview tab to preview items in the merge box.
- Added some more message boxes for when the user does something 'unlogical'.
- Added a spacing property to the Split-tab.

Version 1.0.1:
- Framesizes are now automatically detected upon inserting atleast one frame
  to the merge tab.
- Splitting now formats the numbers with leading zeros.
- Added readme.

Version 1.0.0.0:
- First public release.

Version 0.9.4
- Added multi-row spritesheet compatibility for the Merge-tab

Version 0.9.3
- Fixed bug in the split tab-page with multiple rows.

Version 0.9.2
- Added icon (public domain: http://www.wpclipart.com/art/Paintings/David
  __Napoleon_at_the_st_bernard_pass.jpg.html)
- Fixed crash on huge bitmaps.
- Replaced this textbox.