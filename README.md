# What is Combat Overhaul Daggerfall Unity?

> Daggerfall Unity is an open source recreation of Daggerfall in the Unity engine created by [Daggerfall Workshop](http://www.dfworkshop.net).

This is a edit of the base script and code surrounding the combat, weapon, and attack animation system. The purpose of this mod is to bring the combat and animation system into a more modern feel without losing the charm and asthetics of the original. It took a year of breaking the code apart and reworking it in order to create this custom animatiom and raycast system, along with the numerous other features. I hope you enjoy it, and respect coders work. If you wish to use any of my code, get permissions first.

*This is currently a developer release meant largely for testing, tuning, and debugging. This is not considered an official release of any type, and I provide no support if your save/game breaks during play through.*

## Features & Roadmap

Completed
+ Completely rebuilt the weaponmanager and fpsweapon script to create 60fps smooth attack animations. Scales with your attack speed.
+ Rebuilt weaponmanager script to create 90 degree raycast detection arcs on weapon swings. On object hit, stops, and plays a recoil. Scales with your attack speed.
+ Weapons now have a bob effect when moving to simulate real life movement.
+ Every weapon has its own unique range. No longer will weapons all have the same reach.
+ Attacks have been tied to movement keys, so you now can choose your attack based on the four movement keys.
+ Weapons each have their own speed that is uniquely calculated based on their weight and range.
+ Players speed is now reduced with they unsheath a weapon and reduced further when they attack.
+ Inventory UI reads out unique weapon ranges for players.
+ A number of bug fixes and extra console commands added to improve the code and allow player manipulation.

Not Complete
- Add a toggle block system for shields.
- Add a weapon parry system for two handed wielding.
- Add unique sword sprite sizes to mimick different blade sizes.

## General Bugfix & Code Changes

+ Freed some cpu cycles by moving wasted calculations out of script loops.
+ Added a console script and console commands for enabling classic animations and modifiying values.

## Console Commands

* OffsetDistance: This is a float value that changes animation offset distance. Default value varies between .2 and .28 depending on the weapon being used. Higher values faster offset moves.
* DisableSmoothAnimations: This enables and disables the default or improved animation system.
* ChangeAttackSpeed: This subtracts or adds a certain float value from the default animation attack speed; Use .01 increments.
* ChangeHorPos: Changes start and end position of hit arc detection; starts at 45 degree and does 90 degree arc to end at 45 degrees on opposite side. (-start float -end float).
* ChangeRaycastLerp; Changes how slow or fast the hit arc is drawn. Default is .188f. Recommend .01f increments.
* ChangeMovementMods; Multiplies base movement speed for sheathed and attack animations. Default is -sheathed .85f -attack .4f. Set values to 1 to disable any movement reduction. (-sheathed float -attack float).

## Threads Related to Code

+ In-depth project and discussion on combat and animation system and related code: viewtopic.php?f=14&t=2533
+ A very in-depth breakdown of the combat system and animation system and how they work together to create what happens on the screen: viewtopic.php?f=22&t=2508
+ In-depth discussion, with visual flow chart, of the fps animation system and all related script files the control and run it: viewtopic.php?f=22&t=2554

## Links

+ [Daggerfall Workshop](http://www.dfworkshop.net/) - *Follow the development of Daggerfall Unity*
+ [Workshop Forums](http://forums.dfworkshop.net/) - *Join the community*
+ [Reddit](https://www.reddit.com/r/daggerfallunity) - *Daggerfall Unity subreddit*
+ [Twitter](https://twitter.com/gav_clayton) - *Follow lead developer on Twitter for more news*

## Versions
+ *Daggerfall Unity* - v0.10.21
+ *Daggerfall Tools for Unity* - v1.8.7
+ *Minimum Unity3D version* - 2018.2.21f1

## License

+ MIT License
