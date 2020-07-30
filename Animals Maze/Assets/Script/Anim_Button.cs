using UnityEngine;
using UnityEngine.UI;

public class Anim_Button : MonoBehaviour
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