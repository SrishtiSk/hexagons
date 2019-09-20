using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float _moveSpeed = 600f;
    float movement = 0f;
   
    void Update()
    {
        movement= Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown("escape")) Application.Quit();
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
       Application.Quit();
    }
}
