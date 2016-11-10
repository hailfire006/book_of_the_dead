using UnityEngine;
using System.Collections;

public class Laser_Script : MonoBehaviour {
	public GameObject cam_rig;
	public GameObject player;
    public bool ready_to_tp;
    public Vector3 tp_spot;
	void Start () {
    	
	}
	void OnTriggerEnter(Collider Hit)
    {

		if (Hit.name.StartsWith("teleport_spot"))
        {
            tp_spot = new Vector3(Hit.transform.position.x, Hit.transform.position.y, Hit.transform.position.z);
		}
    }
    void OnTriggerExit(Collider Hit)
    {
        if (Hit.name.StartsWith("teleport_spot"))
        {
            tp_spot = new Vector3(0, 0, 0);
        }
    }

	void LateUpdate () {
        if (ready_to_tp)
        {
            if (tp_spot != new Vector3(0, 0, 0))
            {
                cam_rig.transform.position = tp_spot;
                player.transform.position = tp_spot;
            }
            ready_to_tp = false;
            gameObject.SetActive(false);
        }
	}
}
