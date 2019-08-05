
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{


    private GameObject nowmap = null;
    private GameObject insmap = null;

    void Start()
    {
          GameObject[] gos = ObjectPutManager.current.getMaps();
            //Debug.Log(gos);
            int ranint = Random.Range(0, gos.Length);
            nowmap = gos[ranint];


        //nowmap = ObjectPutManager.current.getMap("01");

        if(nowmap != null)
        {
           insmap =  GameObject.Instantiate(nowmap);
        }


    }


}
