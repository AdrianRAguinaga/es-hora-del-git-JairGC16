using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Dictionary<string, int> hashtable = new Dictionary<string, int>();
        string key;
        int value;

        // Ingreso masivo de datos en la tabla hash
        for (int i = 0; i < 1000000; i++) {
            key = $"clave_{i}";
            value = i;
            hashtable.Add(key, value);
        }

        // Búsqueda de un valor en la tabla hash
        Console.Write("Ingrese una clave para buscar en la tabla hash: ");
        key = Console.ReadLine();
        if (hashtable.TryGetValue(key, out value)) {
            Console.WriteLine($"El valor de {key} es {value}");
        }
        else {
            Console.WriteLine($"La clave {key} no existe en la tabla hash");
        }

        Console.ReadKey();
    }
}