using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{

    // Refenssit:
    public TextMeshProUGUI kuolematLabel;
    private int kuolemienMaara;
    public static DeathCounter instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //P‰ivit‰ 
        kuolemienMaara--;
        OnPelaajaKuoli();

    }


    public void OnPelaajaKuoli()
    {
        //Lis‰‰ kuolemien m‰‰r‰‰n +1.
        kuolemienMaara++;

        kuolematLabel.text = "Deaths: " + kuolemienMaara.ToString();

    }



}
