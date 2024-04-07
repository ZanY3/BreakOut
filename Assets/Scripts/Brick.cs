using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Brick : MonoBehaviour
{
	[SerializeField] int hp;
	public int score = 100;

	void Start()
	{
		transform.DOScale(Vector3.one, 1f)
			.SetDelay(Random.Range(0f, 0.5f))
			.SetEase(Ease.OutBounce)
			.ChangeStartValue(Vector3.zero);
	}

	public void Damage()
	{
		hp--;
		if (hp <= 0)
		{
			Destroy(gameObject);
			GameManager.score += score;
			transform.DOShakePosition(0.2f, 0.2f, 30);
		}
	}
}
