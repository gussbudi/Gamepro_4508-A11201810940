using UnityEngine;
using System.Collections;
public class BulletScript : MonoBehaviour {
	public int lifetime = 2;
	private float timer;
	void OnCollisionEnter2D(Collision2D target){ 
		if (target.gameObject.tag=="Enemy"){ 
			Destroy(target.gameObject); 
		}
		Destroy (gameObject); 
	}

	void Update(){
		timer += Time.deltaTime; 
		if(timer > lifetime){ 			
			timer = 0; 
			Destroy(gameObject); 
		}
	}
}
