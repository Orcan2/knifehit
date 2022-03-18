using UnityEngine.SceneManagement;
using UnityEngine;

public class RETRY : MonoBehaviour
{
    

    // Update is called once per frame
    public void retry()
    {
        SceneManager.LoadScene(0);
    }
}
