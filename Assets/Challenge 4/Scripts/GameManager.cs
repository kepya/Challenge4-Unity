using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private PlayerControllerX playerController;
    public GameObject dirtParticle;
    public bool isSpeadMode = false;
    public float score = 0f;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isSpeadMode)
            {
                isSpeadMode = false;
                playerController.speed /= 2.5f;
                dirtParticle.gameObject.SetActive(false);
            } else {
                isSpeadMode = true;
                playerController.speed *= 2.5f;
                dirtParticle.gameObject.SetActive(true);
            }
        }
        
    }

    public void addScore()
    {
        score++;
        scoreText.text = score + "";
    }
}
