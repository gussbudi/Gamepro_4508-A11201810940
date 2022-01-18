using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Enemy" || target.gameObject.tag == "Deadly") { 
			Die(); 
		}
	}

	void Die(){		
		GameObject go = GameObject.Find("SettingGame"); 
        ScriptPengaturGame pg = (ScriptPengaturGame)go.GetComponent(typeof(ScriptPengaturGame));
		pg.Respawning(); 
		Destroy (gameObject); 
	}
}
