using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    //public GameManager GMUI;
    public Transform playerTransform;
    public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {     
        if (/*GMUI.isGameEnd*/FindObjectOfType<GameManager>().isGameEnd)
        {
            scoreText.text = "Game Over";
        }
        if (/*!GMUI.isGameEnd*/!FindObjectOfType<GameManager>().isGameEnd)
        {
            scoreText.text = playerTransform.position.z.ToString("0");
        }
	}
}
