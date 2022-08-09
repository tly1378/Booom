using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public Image image;
    public GameObject buttons;

    private void OnEnable()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            enabled = false;
            StartCoroutine(Switch(1f, ()=> { 
                buttons.SetActive(true);
                Player.player.enabled = false;
            }));
        }
    }

    public void Back()
    {
        buttons.SetActive(false);
        Player.player.enabled = true;
        StartCoroutine(Switch(-1, () => { }));
        enabled = true;
    }

    private IEnumerator Switch(float speed, Action p)
    {
        float alpha;
        if (speed < 0)
            alpha = 1;
        else
            alpha = 0;
        while (alpha >= 0 && alpha <= 1)
        {
            alpha += Time.deltaTime * speed;
            Color color = image.color;
            color.a = alpha;
            image.color = color;
            yield return null;
        }
        p.Invoke();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
