using System.IO;
using System.Text.Json;

Enemy wisp = new Enemy();

Console.WriteLine("give it a name");
wisp.Name = Console.ReadLine();

Console.WriteLine("How much hp shuld it have");
int HpInput;
int.TryParse(Console.ReadLine(), out HpInput);
wisp.Hp = HpInput;

Console.WriteLine("give it a name");
int DmgInput;
int.TryParse(Console.ReadLine(), out DmgInput);
wisp.Dmg = DmgInput;

Console.ReadLine();
