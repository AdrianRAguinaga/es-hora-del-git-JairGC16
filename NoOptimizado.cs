using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Dictionary<string, int> hashtable = new Dictionary<string, int>();
        string key;
        int value;

        // ingreso masivo de datos en la tabla hash
        for (int i = 0; i < 1000000; i++) {
            key = "clave_" + i.ToString();
            value = i;
            hashtable.Add(key, value);
        }

        // buscar un valor en la tabla hash
        Console.Write("Ingrese una clave para buscar en la tabla hash: ");
        key = Console.ReadLine();
        if (hashtable.ContainsKey(key)) {
            value = hashtable[key];
            Console.WriteLine("El valor de {0} es {1}", key, value);
        }
        else {
            Console.WriteLine("La clave {0} no existe en la tabla hash", key);
        }

        Console.ReadKey();
    }
}