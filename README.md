# Golden Path from the Unity3d Documentation on MLAPI

https://docs-multiplayer.unity3d.com/docs/tutorials/goldenpath_series/mlapi_starting_out/index.html

This contains up to Module Two from the Unity Golden Path on MLAPI networking library.

## To run in MacOs

Build & Run from console:

```console
$ ./Build/{build_name}.app/Contents/MacOS/GoldenPath -mlapi server -logfile - & ; ./Build/{build_name}.app/Contents/MacOS/GoldenPath -mlapi client -logfile -
```

This will open a server and client build at the same time.