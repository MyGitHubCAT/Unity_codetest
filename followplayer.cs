using UnityEngine;

public class followplayer : MonoBehaviour {


    public Transform player;
    public Vector3 offset;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        //Debug.Log(player.position);
        if (player.position != null)
        {
            transform.position = offset + player.position;//移动部件的位置到offset+ player.position处
        }
       

    }
}
