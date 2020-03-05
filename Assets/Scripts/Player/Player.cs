using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Text MyWalletText;

	private Vector3 startPosition;

	private void Start()
	{
		startPosition = transform.position;			//Save start positon
	}

	private void Update()
	{
		transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * 5f;	//Movement
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		transform.position = startPosition;	//Reset position

		//Add "hit enemy" function call, increase money +$5, update UI text.
	}
}
