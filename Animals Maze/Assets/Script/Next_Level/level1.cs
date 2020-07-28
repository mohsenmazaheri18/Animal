using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{

    public void next1()
    {
        Application.LoadLevel("Mission2");
    }
    public void next2()
    {
        SceneManager.LoadScene("Hard_Levels");
    }
    public void home()
    {
        Application.LoadLevel("home");
    }
    public void reset1()
    {
        Application.LoadLevel("Mission1");
    }
    public void reset2()
    {
        Application.LoadLevel("Mission2");
    }
    public void reset3()
    {
        Application.LoadLevel("Mission3");
    }
}
