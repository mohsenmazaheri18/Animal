using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonbtn: MonoBehaviour
{
    public GameObject hen;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            hen.transform.position = button.transform.position;
        });

    }
}
