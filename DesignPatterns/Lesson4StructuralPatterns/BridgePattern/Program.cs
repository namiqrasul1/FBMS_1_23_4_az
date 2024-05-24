using BridgePattern;

TV tv = new();
RemoteController controller = new(tv);

Console.WriteLine(tv.IsEnabled);
controller.TogglePower();
Console.WriteLine(tv.IsEnabled);

Console.WriteLine(tv.Volume);
controller.VolumeUp();
controller.VolumeUp();
controller.VolumeUp();
controller.VolumeUp();
Console.WriteLine(tv.Volume);