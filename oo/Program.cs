// Song s1 = new Song(name: "Vampiro", artist: "Matuê", duration: 3, available: true);
// Song s2 = new Song("Urubus", "Matuê", 3, true);

// Album albumTuê = new Album();

// albumTuê.AddSong(s1);
// albumTuê.AddSong(s2);

// Console.WriteLine(albumTuê.GetAlbum());

using OO.Models;
using OO.Heranca;

Episode ep1 = new(25, 1, "Pink e Pill");
ep1.AddGuest("Breier");
ep1.AddGuest("Tenente Breno");
System.Console.WriteLine(ep1.Summary);

Maltes megan = new Maltes("Megan", "Branca", true);