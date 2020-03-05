using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFace : Enemy
{
	public override void TakeDamage()
	{
		base.TakeDamage();
		transform.localScale *= 0.75f;
	}
}
