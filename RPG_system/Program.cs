using System.Security.Cryptography;
using Characters;
using RPG_system;
using System;
using System.Collections.Concurrent;

Character c1 = new Character("Albert", new Fairy(), new Warrior());
Character c2 = new Character("Stefan", new Elf(), new Warrior());

Console.WriteLine(c1.ToString());
