
using UnityEngine;

public class playermovment : MonoBehaviour {

    // Use this for initialization

    public Rigidbody rb;//声明刚体
    public float forwardforce = 1000f;
    public float sideforce = 500f;
   
      
    void Start ()
    {
        Debug.Log("hello world");
        rb.useGravity = true;
        ;
	}

    // Update is called once per frame
    void Update ()//电脑的每一帧，与电脑FPS有关，FPS越高，处理频率越高
    {
       
    }
    private void FixedUpdate()//固定时间间隔，不受帧率影响，处理刚体物理属性应该用fixedupdata热不是updata
    {
        
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if(Input.GetKey("d"))//判定键盘输入d
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);//施加一个X正方向的作用力
        }
        if (Input.GetKey("a"))//判定键盘输入da
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//施加一个X负方向的作用力
        }
        if(transform.position.y < -1f)
        {
            
            FindObjectOfType<GameManager>().EndGame();//搜索游戏中GameManager类
        }
    }
}
