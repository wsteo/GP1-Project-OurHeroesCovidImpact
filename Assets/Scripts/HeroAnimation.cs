using UnityEngine;
using System.Collections;

public class HeroAnimation : MonoBehaviour {

	public GameObject Heroes;
	public Animation anim;
	public string idle, attack;

	void Start(){
		anim = GetComponent<Animation> ();
	}

	public void IdleAnimation(){
		anim.Play("Army Idle");
	}

	public void AttackAnimation(){
		anim.Play("Army Attack");
	}
}