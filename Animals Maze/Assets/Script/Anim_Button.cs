using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim_Button : MonoBehaviour
{
    public GameObject hen;
    public Button Buttonn;


    void Start()
    {

        Buttonn.onClick.AddListener(() =>
        {
            
            hen.transform.position = Buttonn.transform.position;


        });

    }
    void Update()
    {

            
        
    }
}
