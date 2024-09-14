using Bridge;

IDevice tv = new Tv();
var remoteControl = new AdvancedRemoteControl(tv);

remoteControl.TogglePower();
remoteControl.VolumeUp();
remoteControl.VolumeDown();
remoteControl.VolumeUp();
remoteControl.VolumeUp();

IDevice radio = new Radio();
remoteControl = new AdvancedRemoteControl(radio);

remoteControl.TogglePower();
remoteControl.VolumeUp();

Console.ReadLine();