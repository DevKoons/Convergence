using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTabManager : MonoBehaviour
{
  
    public bool invOpen = false;  //is inventory open?
    [SerializeField] CanvasGroup inv;  //the canvas group for the inventory
    [SerializeField] CanvasGroup[] tabs;
    private int currentTab = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextTab()
    {
        tabs[currentTab].alpha = 0;
        tabs[currentTab].interactable = false;
        tabs[currentTab].blocksRaycasts = false;

        if (currentTab < tabs.Length - 1)
        {
            currentTab += 1;
        }
        else
        {
            currentTab = 0;
        }

        tabs[currentTab].alpha = 1f;
        tabs[currentTab].interactable = true;
        tabs[currentTab].blocksRaycasts = true;
    }

    public void PreviousTab()
    {
        tabs[currentTab].alpha = 0;
        tabs[currentTab].interactable = false;
        tabs[currentTab].blocksRaycasts = false;

        if (currentTab > 0)
        {
            currentTab -= 1;
        }
        else
        {
            currentTab = tabs.Length - 1;
        }

        tabs[currentTab].alpha = 1f;
        tabs[currentTab].interactable = true;
        tabs[currentTab].blocksRaycasts = true;
    }
}
