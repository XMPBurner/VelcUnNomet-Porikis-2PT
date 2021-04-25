using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject poga;
    public GameObject pogab;
    public GameObject attels;
    // Start is called before the first frame update
    public void izkritosais(){
    attels.SetActive(true);
    if(poga == true){
        attels.SetActive(false);
        pogab.SetActive(false);
        poga.SetActive(false);
    }
    }
}