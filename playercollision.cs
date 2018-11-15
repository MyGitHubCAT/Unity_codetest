using UnityEngine;

public class playercollison : MonoBehaviour {

    // Use this for initialization
    public playermovment movement;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")根据碰撞物体的标签（tag）筛选
        {
            
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
