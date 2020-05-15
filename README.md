# Unity 2D Orthographic Camera Follow Script

This is a dead simple 2D camera follow script that can be used for top down or
side scrolling games. The script can be attached to your Main camera. Then,
you'll want to create a GameObject hierarchy in the Unity editor that looks
like:

```
ParentGameObject
├── PlayerObjectThatMoves
├── Main Camera
├── ....other GameObjects ...
```

You'll then want to set `targetTransform` in the Unity editor to your object
that moves in this hiearchy. You can tweak `followSpeed` in the editor to adjust
how fast the camera follows the target.
