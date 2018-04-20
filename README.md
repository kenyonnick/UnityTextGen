# UnityTextGen
Generate 3D text and symbolic structures using prefabs in Unity

## Purpose
Using this tool, you can generate 3D text procedurally using a lexicon of prefabs for each character you need.
The script works in Edit mode in Unity.

## Requirements
- You will need the Unity game engine, as the code is written for use in Unity
- You will need prefabs for the 3D characters used in your lexicon

## Use
Create two separate empty game objects.
### Setting up the _TextGenLex_
1. Place the _TextGenLex_ script on one of the game objects.
2. Populate the lex with the prefabs you have for your characters, and label each one with the character it represents.
### Using _TextGen3D_
- Type the text you wish to generate into the _text_ field.
- 3D text will appear using the prefabs you assigned to each character
- You can adjust the spacing of characters
- The text is placed as the child of a game object named with the text in the _text_ field (ex. "Pizza"). The game object named "Pizza" is a child of the empty game object that you placed the _TextGen3D_ script on.
- You can duplicate the game object named "Pizza" and place it elsewhere in your hierarchy, and it will not be impacted by changes made in _TextGen3D_.

This should allow you to quickly generate game objects with 3D text as children for the quick population of game scenes with 3D textual information. You can also use this to generate text from alien or symbolic languages by assigning 3D symbols instead of 3D characters to the lex.
