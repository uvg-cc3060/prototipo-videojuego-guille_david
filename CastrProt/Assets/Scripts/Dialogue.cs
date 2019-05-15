using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string nombre;

    [TextArea(2,5)]
    public string[] oraciones;

}
