using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireScenes : MonoBehaviour
{
 public void CommencerJeu()
    {
        SceneManager.LoadScene("Niveau1");
    }
}
