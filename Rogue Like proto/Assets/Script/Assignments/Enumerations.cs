using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Color {blue, green, red, yellow, purple}; // has to have linear progression . 1, 2, 3 or so

public class Enumerations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color paint;;
        paint = Color.green;

        print(paint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
