using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutManager : MonoBehaviour
{

    public static ObjectPutManager current = null;

    string mapprefabs = "MapPrefabs/Map";

    private void Awake()
    {
        current = this;
    }

    public GameObject[] getMaps()
    {
        
        Object[] gobjs = Resources.LoadAll("MapPrefabs");
        GameObject[] gos = new GameObject[gobjs.Length];
        for (int i =0;i<gobjs.Length; i++)
        {
            gos[i] = gobjs[i] as GameObject;
        }
        return gos;
    }

    public GameObject getMap(string name)
    {
        GameObject go = null;
        go = Resources.Load(mapprefabs + name, typeof(GameObject)) as GameObject;
        return go;
    }

}
