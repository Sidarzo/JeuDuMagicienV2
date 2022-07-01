using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManagement : MonoBehaviour
{
    private int selectedSpell = 0;
    public void SetSelectedSpell(Button button)
    {
        Debug.Log(button.name);
        selectedSpell = 1;
    }

    public int GetSelectedSpell()
    {
        return selectedSpell;
    }
}
