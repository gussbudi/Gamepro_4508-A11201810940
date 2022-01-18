using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPengaturGame : MonoBehaviour
{
    public int respawnTime=1;
    public void Respawning(){
        StartCoroutine(DelayedRespawn()); 
    }

    IEnumerator DelayedRespawn(){
		yield return new WaitForSeconds(respawnTime); 
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
	}
}
