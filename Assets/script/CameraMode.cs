using UnityEngine;
using System.Collections;

public class CameraMode : MonoBehaviour {
    public Transform player;
    int distanc = -1;
    float lite=0f;
    public float ach, dzax;
    Vector3 CameraX;
   
	// Use this for initialization
	void Start () {

        CameraX.y = gameObject.transform.position.y;
        CameraX.z = gameObject.transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        CameraX.x = player.position.x;
        if (player.position.x>dzax && player.position.x<ach)
        transform.position = new Vector3(0, lite, distanc) + CameraX;
        //transform.LookAt(player);
       
	}
}
