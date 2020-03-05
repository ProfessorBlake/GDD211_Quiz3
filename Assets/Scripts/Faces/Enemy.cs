using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
	public int Health;

	public virtual void TakeDamage()
	{
		Health -= 1;
		if (Health <= 0)
			Destroy(gameObject);
	}
}
