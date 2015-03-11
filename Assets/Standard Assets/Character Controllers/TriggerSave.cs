using UnityEngine;
using System.Collections;

public class TriggerSave : MonoBehaviour 
{
	
	public Vector3 playerPosOnTrigger;
	
	void OnTriggerEnter(Collider col)
	{
				if (col.gameObject.tag == "Player") {
						Debug.Log ("CheckPoint ! ");
						PlayerSave ps = col.transform.GetComponent<PlayerSave> ();
						ps.setTriggerSave (this);
						playerPosOnTrigger = col.transform.position;
				}
		}
}