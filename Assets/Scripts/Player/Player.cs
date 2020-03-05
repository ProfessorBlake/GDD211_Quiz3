using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Wallet MyWallet;
	public Text MyWalletText;

	private Vector3 startPosition;

	private void Start()
	{
		startPosition = transform.position;
		MyWallet = new Wallet() { Money = 100 };
		MyWalletText.text = "$" + MyWallet.Money;
	}

	private void Update()
	{
		//Move with WASD/ARROW KEYS
		transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * 5f;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		transform.position = startPosition;

		//Add "hit enemy" function call and increase money +5
		Enemy hit = collision.gameObject.GetComponent<Enemy>();
		if(hit)
		{
			hit.TakeDamage();
			MyWallet.Money += 5;
			MyWalletText.text = "$" + MyWallet.Money;
		}
	}
}
