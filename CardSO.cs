using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Cards", menuName = "ScriptableObjects/Cards", order = 1)]
public class CardSO : ScriptableObject
{
    //Our card scriptable object, this is our main data source for all our cards and it's what card will pull from.
    /// <summary>
    /// It is not needed outside of adding data that cards may need. 
    /// </summary>


    [SerializeField] int cost;
    [SerializeField] GameObject cardGO;
    [SerializeField] Sprite cardImage;
    public GameObject CardGO
    {
        get { return cardGO; }
        set { cardGO = value; }
    }
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    public Sprite CardImage
    { get { return cardImage; } set {  cardImage = value; } }
}
