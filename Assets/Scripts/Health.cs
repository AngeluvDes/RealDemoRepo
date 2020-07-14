using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int NumofHearts;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;

    // Start is called before the first frame update
    void Start()
    {

    }

    internal static void Destroy(int health)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < hearts.Length; i++)
        { if (health > NumofHearts)
            {
                health = NumofHearts;
            }

            if (i < health)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }

            if (i < NumofHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

         


            }

    }
    }
