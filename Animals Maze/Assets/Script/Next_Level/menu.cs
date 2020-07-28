using UnityEngine;


public class menu : MonoBehaviour
{

    public void rank_1()
    {
       Application.LoadLevel("Mission1");
    }
    public void rank_2()
    {
        Application.LoadLevel("Mission2");
    }
    public void rank_3()
    {
        Application.LoadLevel("Mission3");
    }
    public void exit()
    {
        Application.Quit();
    }
}
