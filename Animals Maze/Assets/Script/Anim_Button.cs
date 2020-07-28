using UnityEngine;
using UnityEngine.UI;

public class Anim_Button : MonoBehaviour
{
    public GameObject hen;
    public Button button;

    void Start()
    {

        button.onClick.AddListener(() =>
        {
            hen.transform.position = button.transform.position;
        });

    }
}