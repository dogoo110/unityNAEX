using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.current.PlayMainAudio("", "Battle4");
        AudioManager.current.PlayMainAudioOneshot("","leiqie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
