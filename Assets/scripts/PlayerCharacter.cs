using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour {

	public GameObject[] projecTiles;
	private int _health = 3;
	[SerializeField] 
	private Text _healthText;
	
	private void Start()
	{
		_healthText.text = "Health: " + _health.ToString();
	}
	void Update () 
	{

		if(Input.GetKeyDown(KeyCode.A)){
			Instantiate(projecTiles[0], transform.position, Quaternion.identity);
		} 
		else if(Input.GetKeyDown(KeyCode.S)){
			Instantiate(projecTiles[1], transform.position, Quaternion.identity);
		}
		else if(Input.GetKeyDown(KeyCode.D)){
			Instantiate(projecTiles[2], transform.position, Quaternion.identity);
		}
	}
	public void HandleDamage()
	{
		_health--;
		_healthText.text = "Health: " + _health.ToString();
		if(_health == 0)
		{
			SceneManager.LoadScene(0);
		}
	}

}
