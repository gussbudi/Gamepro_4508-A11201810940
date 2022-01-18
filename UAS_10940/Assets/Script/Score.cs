using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    //void Start()
    //{
    //    ScoreNum = 0;
    //    MyscoreText.text = "Musuh Meninggal : " + ScoreNum;
    //}

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.tag == "Enemy")
        {
            ScoreNum += 1;
            Destroy(Enemy.gameObject);
            MyscoreText.text = "Musuh Meninggal : " + ScoreNum;
        }
    }
}
