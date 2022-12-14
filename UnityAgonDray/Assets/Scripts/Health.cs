using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 100;
    public int maxHealth = 100;

    public HealthBar healthBar;
    public AudioSource Hurt;

    void Start()
    {
        curHealth = maxHealth;
        Hurt = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(curHealth == 0)
        {
            dead();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trap")
        {
            DamagePlayer(10);
            Hurt.Play();
        }
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }
    public void dead()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Main_Menu");

    }
}
