using smartphone.Models;

// Create a new instance of the Game class
Smartphone android = new Android(
  numero:"123456789",
  imei: "123456789012345",
  modelo: "Nokia C21 Plus",
  memoria: 128
);

Smartphone ios = new Ios(
  numero: "987654321",
  imei: "543210987654321",
  modelo: "IPhone 15",
  memoria: 256
);

// Call methods on the Android instance
android.Ligar();
android.ReceberLigacao();

android.InstalarApp("WhatsApp");
Console.WriteLine();

// Call methods on the iOS instance}
ios.Ligar();
ios.ReceberLigacao();
ios.InstalarApp("Telegram");
