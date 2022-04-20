using System;


// Аптека
public class Apteka
{
    // Название аптеки
    public string Name { set; get; }

    // Адрес
    public string Location { set; get; }

    // Препараты
    public List<Preparat> med;
}

// Препараты
public class Preparat
{
    // Название
    public string PreparatName { set; get; }

    // Цена
    public float PreparatPrice { set; get; }
   // public void Preparat(in int a)
    
}
//Самое дорогое лекарство 
public void MaxPrice()
{
    var res = float.MinValue;

    foreach (var it in Preparat)
    {
        if (it.PreparatPrice < res) { res = it.PreparatPrice; }
    }
    return res;
}

// инициализация полей значениями по умолчанию - доступна с C#10

//public string name = "Preparat";
//public int age = 1;