using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimation : MonoBehaviour
{
	private float time = 0.5f;
	private Vector3 cardSet;

	void Start()
	{
		cardSet = new Vector3(0.0f, -0.5f, -0.2f);
	}

	public void MovingAnimation(GameObject card, Transform destination)
	{
		LeanTween.move(card, destination.position + cardSet, time);
		Debug.Log(time);
		Debug.Log(time);
	}
}