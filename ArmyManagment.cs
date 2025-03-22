using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ArmyManagment : MonoBehaviour
{


    [SerializeField] bool updated;
    [SerializeField] GameObject parentCanvas;
    [SerializeField] int pointsCost;

    CardLibraryManager clm;
    GameObject libraryCanvas;
    [SerializeField] CardSO Carddata;


    [SerializeField] public Text army0PointsCost;


    [SerializeField] public GameObject[] statBlockChildImage;
    [SerializeField] private int buttonIndex; // Index of the card tied to this button

    public int PointsCost
    {
        get { return pointsCost; }
        set { pointsCost = value; }
    }

    private void Awake()
    {


    }
    private void Update()
    {


    }
    void Start()
    {
        clm = FindObjectOfType<CardLibraryManager>();
        libraryCanvas = GameObject.Find("LibraryCanvas");
        army0PointsCost = clm.army0PointsvalueText;
        parentCanvas = GameObject.Find("LibraryCanvas");

    }
    //This pulls our points cost and our card names from the library manager.
    //This call will be used on the proper button in our Create Army Scene.
    public void UpdateArmy0()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "CreateArmy" && !updated)
        {

            //Updates points cost from library manager
            pointsCost = clm.army0totalPoints;

            clm.army0PointsvalueText.text = pointsCost.ToString();
            Debug.Log(clm);

            //Manually assigns each button a name depending on the card in our army list at that position. 
            //Now we have to pull these from the card library. 
            //it is where we will set them
            clm.armyPanelButtons[0].name = clm.armyList0[0].name;
            clm.armyPanelButtons[0].GetComponentInChildren<Text>().text = clm.armyList0[0].name;


            clm.armyPanelButtons[1].name = clm.armyList0[1].name;
            clm.armyPanelButtons[1].GetComponentInChildren<Text>().text = clm.armyList0[1].name;

            clm.armyPanelButtons[2].name = clm.armyList0[2].name;
            clm.armyPanelButtons[2].GetComponentInChildren<Text>().text = clm.armyList0[2].name;

            clm.armyPanelButtons[3].name = clm.armyList0[3].name;
            clm.armyPanelButtons[3].GetComponentInChildren<Text>().text = clm.armyList0[3].name;
        }
    }
    //This loads the porper card image according to the panel we press.
    public void LoadCard()
    {
        if (clm.armyPanelButtons[0])
        {
            statBlockChildImage[0].SetActive(true);
            statBlockChildImage[0].GetComponentInChildren<RawImage>().texture = clm.armyList0[0].CardImage.texture;
            //LoadStatBlock
            //Which will be a picture
        }
        if (clm.armyPanelButtons[1])
        {
            statBlockChildImage[1].SetActive(true);
            statBlockChildImage[1].GetComponentInChildren<RawImage>().texture = clm.armyList0[0].CardImage.texture;
            //LoadStatBlock
            //Which will be a picture
        }
        if (clm.armyPanelButtons[2])
        {
            statBlockChildImage[2].SetActive(true);
            statBlockChildImage[2].GetComponentInChildren<RawImage>().texture = clm.armyList0[0].CardImage.texture;
            //LoadStatBlock
            //Which will be a picture
        }
        if (clm.armyPanelButtons[3])
        {
            statBlockChildImage[3].SetActive(true);
            statBlockChildImage[3].GetComponentInChildren<RawImage>().texture = clm.armyList0[0].CardImage.texture;
            //LoadStatBlock
            //Which will be a picture
        }
        //cardLibraryManager.armyList0.Clear();
    }

       // Reference to the CardLibraryManager

    // Method to remove a card from the army list
    public void RemoveFromArmy0()
    {
        // Ensure clm is initialized and index is valid
        if (clm == null || buttonIndex < 0 || buttonIndex >= clm.armyList0.Count)
        {
            Debug.LogWarning("Invalid setup or index out of range.");
            return;
        }

        // Remove the card and update points
        var removedCard = clm.armyList0[buttonIndex];
        clm.armyList0.RemoveAt(buttonIndex);
        clm.army0totalPoints -= removedCard.Cost; // Assuming PointsCost is part of CardSO
        clm.army0PointsvalueText.text = clm.army0totalPoints.ToString();
       

        // Update the remaining buttons in the library
        for (int i = 0; i < clm.armyPanelButtons.Length; i++)
        {
            if (i > clm.armyList0.Count)
            {
                clm.armyPanelButtons[i].name = clm.armyList0[i].name;
                clm.armyPanelButtons[i].GetComponentInChildren<Text>().text = clm.armyList0[i].name;
                clm.armyPanelButtons[i].SetActive(false);
            }
            else
            {
                clm.armyPanelButtons[i].name = string.Empty;
                clm.armyPanelButtons[i].GetComponentInChildren<Text>().text = string.Empty;
                clm.armyPanelButtons[i].SetActive(true);
            }
        }

        Debug.Log($"Removed card: {removedCard.name}. Updated points: {clm.army0totalPoints}");
    }

}
