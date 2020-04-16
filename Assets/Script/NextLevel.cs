using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void Next(int number)
    {
        SceneManager.LoadScene(number, LoadSceneMode.Single);
    }
}
