using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    public string scene;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals("player"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
