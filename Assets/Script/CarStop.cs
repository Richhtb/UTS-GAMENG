using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarStop : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Inisialisasi jika diperlukan
    }

    // Update is called once per frame
    void Update()
    {
        // Logika per frame jika diperlukan
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("GameOver"); 
    }
}