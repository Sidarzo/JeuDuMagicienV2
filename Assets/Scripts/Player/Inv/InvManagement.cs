using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManagement : MonoBehaviour
{
    private int selectedSpell = 0;

    public List<Item> itemInInv;
    public Button[] buttonsInv;


    private void Awake()
    {
        for(int i = 0; i < itemInInv.Count; i++)
        {
            buttonsInv[i].GetComponent<Image>().sprite = itemInInv[i].sprite;
        }
    }
    public void SetSelectedSpell(int idSlot)
    {
        if(itemInInv.Count > idSlot)
        {
            selectedSpell = idSlot;
        }

    }

    public int GetSelectedSpell()
    {
        Debug.Log(itemInInv[selectedSpell].description);
        return selectedSpell;
    }
}
