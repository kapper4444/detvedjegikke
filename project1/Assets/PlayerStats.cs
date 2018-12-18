using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public playerMovement bools;

    public float stamina = 25f;
    public float maxStamina = 25f;
    public float mana = 30f;
    public float maxMana = 30f;

    private float staminaRegenTimer = 0.0f;
    private float manaRegenTimer = 0.0f;

    private const float staminaDecrease = 5f;
    private const float staminaIncrease = 2.5f;
    private const float manaIncrease = 3f;
    private const float timeToRegen = 3f;

	// Use this for initialization
	void Start () {

        //Finds the object that playerMovement is attached to

        GameObject g = GameObject.FindGameObjectWithTag("playerOne");

        bools = g.GetComponent<playerMovement>();
	    
	}

    // Update is called once per frame
    void Update() {

        //Changes the value of the bool named playerRun in the script "playerMovement"
        if (Input.GetKeyDown("left shift"))
        {

            bools.playerRun = true;


        }
        if (Input.GetKeyUp("left shift")|| stamina == 0)
        {

            bools.playerRun = false;
            bools.moveSpeed = bools.currentSpeed;
        }


        //Check if shift is being hold down if it is decrease stamina
        //and afterward regenrate stamina
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        
        if (isRunning)
        {
            stamina = Mathf.Clamp(stamina - (staminaDecrease * Time.deltaTime), 0.0f, maxStamina);

            staminaRegenTimer = 0.0f;

        }
		else if (stamina < maxStamina)
        {
            if (staminaRegenTimer >= timeToRegen)
            {
                stamina = Mathf.Clamp(stamina + (staminaIncrease * Time.deltaTime), 0.0f, maxStamina);
            }
            else
            {
                staminaRegenTimer += Time.deltaTime;
            }
           
        }
	}

}