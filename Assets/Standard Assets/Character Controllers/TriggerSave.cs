using UnityEngine;
using System.Collections;

public class TriggerSave : MonoBehaviour 
{
	
	public Vector3 playerPosOnTrigger;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			Debug.Log("1231123123123123123");
			PlayerSave ps = col.transform.GetComponent<PlayerSave>();
			ps.setTriggerSave(this);
			playerPosOnTrigger = col.transform.position;
		}
	}
}