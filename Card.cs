using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] GameObject champInfoImage;
    [SerializeField] CardSO card;
    [SerializeField] Text cost;
    CardLibraryManager cardLibraryManager;
    [SerializeField] Button buttonName;


    void Start()
    {
        buttonName.name = card.name;
        buttonName.GetComponentInChildren<Text>().text = card.name;

        cardLibraryManager = FindObjectOfType<CardLibraryManager>();
    }

    public void GenerateCardsInfo()
    {
        //Generates the cards info from a card attached to the button object.
        //it will then set the card panel we want to active. 

        //This needs to be updated with an image value.
        champInfoImage.gameObject.SetActive(true); 
        cost.text = this.GetComponent<Card>().CardScriptrableObject.Cost.ToString();
    }
    public void AddToArmy0()
    {
        //Assigned to the add to army button and it will add the proper card which we assign through the buttons on click and dragging the proper card in.

        //Our UI is messy cleaning it up would help understanding a lot. Ask noah later about suggestions on cleanup. 
        cardLibraryManager.armyList0.Add(card);
        cardLibraryManager.Check();
    }
 
    public CardSO CardScriptrableObject
    {
        get { return card; }
        set { card = value; }
    }
}
