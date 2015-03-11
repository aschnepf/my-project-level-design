
using UnityEngine;
using System.Collections;

public class TeleportationPad : MonoBehaviour
{
	
	public Transform player;
	
	void Start()
	{
		//On Récupère le Player lorsque l'Objet est instancié.
		player = GameObject.FindWithTag("Player").transform;
	}
	
	
	void OnTriggerEnter (Collider obj)
	{
		// Si la personne qui entre dans le Trigger est le Player
		if (obj.gameObject.tag == "Player")
		{
			Debug.Log("teleporteur");
			// Récupère position actuelle du player
			Vector3 newPosition = player.position;
			// Ajoute offset sur axe des X
			newPosition += new Vector3(+98f,+110,-380);
			// Update nouvelle position du player
			player.position = newPosition;
		}
	}
}