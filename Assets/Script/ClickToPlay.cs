using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickToPlay : MonoBehaviour
{
    public Button tombolMulai;

    void Start()
    {
       
    }

    public void ClicktoPlay()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
