using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField]private TMP_Text scoreText;
    private float score;
    private float carpan;

    // Update is called once per frame
    void Update()
    {
        score +=Time.deltaTime+carpan;
        
        carpan=Time.deltaTime*50;

        scoreText.text=Mathf.Round(score).ToString();
    }
    
}
