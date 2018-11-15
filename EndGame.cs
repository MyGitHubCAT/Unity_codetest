using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager MyGameManager;

    private void OnTriggerEnter()
    {
        MyGameManager.completegame();
    }

}
	
