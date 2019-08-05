using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public static ObjectManager current = null;

    [SerializeField]
    private List<Transform> GameObjects;

    private Dictionary<string, Transform> mapobjct = new Dictionary<string, Transform>();

    private void Awake()
    {
        current = this;
    }


    private void Start()
    {
        foreach(Transform transform in GameObjects)
        {
            mapobjct.Add(transform.name, transform);
        }
    }


    public Transform getObject(string name)
    {
        Transform transform = null;

        bool exist = mapobjct.TryGetValue(name,out transform);

        return transform;
    }


    


}
