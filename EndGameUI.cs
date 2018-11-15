using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGameUI : MonoBehaviour {

	void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//打开下一个关卡，buildindex见building setting里对应关卡标号
    }
}
