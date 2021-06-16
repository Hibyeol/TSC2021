using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimation : MonoBehaviour
{
	private float time = 0.5f;
	private Vector3 cardSet;
	private Vector3 cardSetAce;

	void Start()
	{
		cardSet = new Vector3(0.0f, -0.25f, -0.01f);
		cardSetAce = new Vector3(0.0f, 0.0f, -0.01f);
	}

	public void MovingAnimation(GameObject card, Transform destination)
	{
		if(destination.GetComponent<Selectable>().top)
		{
			LeanTween.move(card, destination.position + cardSetAce, time);
		}
		else if(destination.CompareTag("Bottom")){
			LeanTween.move(card, destination.position, time);
		}
		else
		{
			LeanTween.move(card, destination.position + cardSet, time);
		}
		card.transform.parent = destination;
	}
}