using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool isGameEnd = false;
    public float GameDelayS = 2.0f;
    public GameObject LevelComplete;

    private void Update()
    {
        if(Input.GetKey("q"))
        {
            SceneManager.LoadScene(0); //返回主界面
        }
    }

    public void completegame()
    {
        Debug.Log("完成游戏");
        LevelComplete.SetActive(true);
        //LevelComplete.active = true;
    }

	public void EndGame()
    {
        if (!isGameEnd)
        {

            isGameEnd = true;
            //Debug.Log("GameOver");
            Invoke("RestartGame", GameDelayS);//延时指定时间再调用函数          
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//加载关卡（通过关卡名称来检索）；获取当前关卡名字
    }
}
