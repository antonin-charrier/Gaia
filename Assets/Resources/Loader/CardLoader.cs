﻿using UnityEngine;
using System.Collections;

public class CardLoader : MonoBehaviour
{

    public const string path = "Loader/cards";

	// Use this for initialization
	void Start() 
    {
        CardContainer cc = CardContainer.Load(path);

        foreach (Card card in cc.cards)
        {
            InstantiateCard(card.name, card.level, card.power, card.lifePoints, card.description);
        }
	}

    private GameObject InstantiateCard(string name, int level, int power, int lifePoints, string description)
    {

        GameObject cardGameObject = (GameObject)Instantiate(Resources.Load("Card/Card"));
        cardGameObject.transform.SetParent(GameObject.Find("HAND").transform);
        cardGameObject.GetComponent<CardUI>().setLabels(name, level, power, lifePoints, description);

        return cardGameObject;
    }

}