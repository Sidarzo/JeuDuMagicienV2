using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManagement : MonoBehaviour
{
    private int selectedSpell = 0;
    public void SetSelectedSpell(int idSlot)
    {
        
        selectedSpell = idSlot;
    }

    public int GetSelectedSpell()
    {
        return selectedSpell;
    }
}
