using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/**
 * 动画机
 */
public class AnimManager : MonoBehaviour
{

    public static AnimManager current = null;
   　

  
    
    private void Awake()
    {
        current = this;
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="transform">Object</param>
    /// <param name="skillid">技能编号</param>
    /// <param name="animlib">动画块名称</param>
    public void PlayAnim(Anim an)
    {
             if(an.Transform.GetComponent<tk2dSpriteAnimator>()==null)
                  return;        
             tk2dSpriteAnimator anim =  an.Transform.GetComponent<tk2dSpriteAnimator>();

             anim.Play(an.Skillid);
    }
    
        

    public void PlayAnim2(Anim an)
    {
        
        if(an.Transform.GetComponent<AnimPe>()==null)
            return;        
        AnimPe anim =  an.Transform.GetComponent<AnimPe>();
        anim.playAnim(an.Skillid);
    }
    
    
}

public class Anim
{
    private Transform transform;
    private string skillid;
    private string animid;

    public Anim(Transform transform, string skillid, string animid)
    {
        this.transform = transform;
        this.skillid = skillid;
        this.animid = animid;
    }


    public Anim(Transform transform, string skillid)
    {
        this.transform = transform;
        this.skillid = skillid;
    }

    public Transform Transform
    {
        get { return transform; }
    }

    public string Skillid
    {
        get { return skillid;}

    }

    public string Animid
    {
        get { return animid;}
    }
}
