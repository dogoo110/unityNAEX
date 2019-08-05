using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager current = null;

    private void Awake()
    {
        current = this;
    }

  
    /// <summary>
    /// 播放场景音乐《连续》，以资源文件夹作为根目录
    /// </summary>
    /// <param name="path">路径最后没有“/”</param>
    /// <param name="auidoname">名称</param>
    public void PlayMainAudio(string path,string auidoname)
    {
        AudioClip clip = Resources.Load("audio"+path+"/"+ auidoname, typeof(AudioClip)) as AudioClip;
        AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.loop = true;
        audioSource.Play();
        
    }


    /// <summary>
    /// 播放场景音乐《一声》，以资源文件夹作为根目录
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="auidoname">名称</param>
    public void PlayMainAudioOneshot(string path, string auidoname)
    {
        AudioClip clip = Resources.Load("audio" + path + "/" + auidoname, typeof(AudioClip)) as AudioClip;
        AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip);
    }



    /// <summary>
    /// 播放音乐《一声》，以资源文件夹作为根目录
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="auidoname">名称</param>
    public void PlayMainAudioOneshot(Transform transform,string path,string auidoname)
    {
        AudioClip clip = Resources.Load("audio" + path + "/" + auidoname, typeof(AudioClip)) as AudioClip;
        AudioSource audioSource = transform.GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip);
    }
}
