using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text redCupsLeftText;
    public Text yellowCupsLeftText;

    void Awake()
    {
        instance = this;    
    }

    public void UpdateUI(int nbRedCupsLeft, int nbYellowCupsLeft)
    {
        redCupsLeftText.text = "Red cups left: " + nbRedCupsLeft;
        yellowCupsLeftText.text = "Yellow cups left: " + nbYellowCupsLeft;
    }
}
