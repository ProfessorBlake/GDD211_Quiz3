using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFace : Enemy
{
	public override void TakeDamage()
	{
		base.TakeDamage();
		transform.Rotate(new Vector3(0f, 0f, 90f));
		//Rotate sprite with: transform.Rotate(new Vector3(0f, 0f, 90f));
	}
}
