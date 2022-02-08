using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calulations : MonoBehaviour
{
    // Access Mod DataType Name;  or Name = value;

    public int numberA = 8;
    public int numberB = 12;
    public int numberC = 29;
    public float tot;
    public float numberD = 8.0f;
    public float numberE = 29.0f;

    // Start is called before the first frame update
    void Start()

    {
        Add();
        Sub();
        Mult();
        Divis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Add()
    {
        int total;

        total = numberA + numberB;
        print(numberA + " + " + numberB + " = " + total);

    }
    void Sub()
    {
        int total;

        total = numberC - numberB;
        print(numberC + " - " + numberB + " = " + total);

    }
    void Mult()
    {
        int total;

        total = numberB * numberA;
        print(numberB + " * " + numberA + " = " + total);

    }

    void Divis()
    {
        int total;
        float tot;
        total = numberC / numberA;
        tot = numberE / numberD;
        print(numberC + " / " + numberA + " = " + total);
        print(numberE + " / " + numberD + " = " + tot);
    }


}   
 