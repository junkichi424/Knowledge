using System;

public class IdInfo
{
    public int IdNumber;

    public IdInfo(int IdNumber)
    {
        this.IdNumber = IdNumber;
    }
}

public class Person
{
    public int Age;
    public string Name;
    public IdInfo IdInfo;

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepCopy()
    {
        // 値型 + string はシャローコピーでよい
        Person other = (Person)this.MemberwiseClone();

        // 参照型はnewする必要がある
        other.IdInfo = new IdInfo(IdInfo.IdNumber);
        return other;
    }
}

public class Example
{
    public static void Main()
    {
        // P1のインスタンス
        Person p1 = new Person();
        p1.Age = 11;
        p1.Name = "old";
        p1.IdInfo = new IdInfo(1234);

       
    }

    // 普通の代入の場合
    public static void GeneralSubstitution(Person p1)
    {
        // 完全に同じインスタンス
        var p2 = p1;
        p2.Age = 99;
        p2.Name = "new";
        p2.IdInfo.IdNumber = 5678;
        DisplayValues(p1);
        DisplayValues(p2);
    }

    // シャローコピーの場合
    public static void UseShallow(Person p1)
    {
        // 値型 + stringは別インスタンス、参照型は同じインスタンス
        Person p2 = p1.ShallowCopy();
        p2.Age = 99;
        p2.Name = "new";
        p2.IdInfo.IdNumber = 5678;
        DisplayValues(p1);
        DisplayValues(p2);
    }

    public static void UseDeep(Person p1)
    {
        // 別インスタンスを作成できる
        Person p2 = p1.DeepCopy();
        p2.Age = 99;
        p2.Name = "new";
        p2.IdInfo.IdNumber = 5678;
        DisplayValues(p1);
        DisplayValues(p2);
    }




    public static void DisplayValues(Person p)
    {
        Console.WriteLine("値型 + string: string: {0:s}, int: {1:d}", p.Name, p.Age);
        Console.WriteLine("参照型: {0:d}", p.IdInfo.IdNumber);
    }
}
