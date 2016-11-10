using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {


    public Collider Coll;
    public GameObject Laser;
    void Start () {

        Coll = Laser.GetComponent<Collider>();
	}
	
	
	void Update () {
        
        if (SteamVR_Controller.Input(4).GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Laser.SetActive(true);
        }
        if (SteamVR_Controller.Input(4).GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Laser.GetComponent<Laser_Script>().ready_to_tp = true;
        }
    }
}
