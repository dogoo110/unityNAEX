using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPe : MonoBehaviour
{

	private tk2dSpriteAnimator anim ;
	
		
	void Awake ()
	{
		if(transform.GetComponent<tk2dSpriteAnimator>()!=null)
		anim = this.GetComponent<tk2dSpriteAnimator>();
	}
	
	
	public void playAnim(string skillid)
	{
		if(this.anim==null)
		return;        
		anim.Play(skillid);
	}
	
	
}
