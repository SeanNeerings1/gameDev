using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
  public void RestartGame()
    {
        print("de game restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
