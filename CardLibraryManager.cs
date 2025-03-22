using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using System;

public class CardLibraryManager : MonoBehaviour
{
   private static CardLibraryManager instance;
    public List<CardSO> armyList0, armyList1, armyList2;
    public List<Button> armySelectionButtons;
    [SerializeField] public GameObject[] armyPanelButtons;
    //int armyListCount;    
    public int army0totalPoints;
    //public Sprite[] army0CardImages;
    ArmyManagment armyManager;
    [SerializeField] public Text army0PointsvalueText;
    /// <summary>
    /// This is where we update our army when adding cards to our library. 
    /// this script should be used when checking points and other valuable information that would pertain to adding cards to a library.
    /// </summary>
    /// 

    void Awake()
    {
        
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        if (armyList0.Count > 0 && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            if(armyManager == null)
            {
                armyManager = FindObjectOfType<ArmyManagment>();

            }
            armySelectionButtons[0].gameObject.SetActive(true);

        }
         if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(1))
        {
            armySelectionButtons[0].gameObject.SetActive(false);
        }
    }
    public void Check()
    { 
        foreach (CardSO cardSO in armyList0)
        {
            army0totalPoints += cardSO.Cost;
            Debug.Log(cardSO.Cost);
            break;
        }
    }

    public void UpdateArmyCheckArmyManagementLink()
    {
        armyManager.UpdateArmy0();
    }
}
