using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCheck : MonoBehaviour
{
   
    public void StartGmage2()
    {
        Playground.playerEnter = true;
    }
    public void StartGmage3()
    {
        Instruction2.playerEnter3 = true;
    }
    public void StartGmage4()
    {
        Instruction4.playerEnter4 = true;
    }
    public void StartGmage5()
    {
        Instruction5.playerEnter5 = true;
    }
}
