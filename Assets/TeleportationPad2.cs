
using UnityEngine;
using System.Collections;

public class TeleportationPad2 : MonoBehaviour
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
			Debug.Log("teleporteur2");
			// Récupère position actuelle du player
			Vector3 newPosition = player.position;
			// Ajoute offset sur axe des X
			newPosition += new Vector3(-150f,-90,+220);
			// Update nouvelle position du player
			player.position = newPosition;
		}
	}
}