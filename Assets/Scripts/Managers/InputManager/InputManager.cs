using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //PUBLIC
    public static InputManager _INPUT_MANAGER; //SINGELTON

    //PRIVATE
    private InputActions playerInputs;

    //VARIABLES


    private void Awake()
    {
        if (_INPUT_MANAGER != null && _INPUT_MANAGER != this)
        {
            Destroy(this.gameObject); //Destruir si ya existe uno
        }
        else
        {
            //Activar InputActions
            playerInputs = new InputActions();
            playerInputs.Player.Enable();

            //ACTIONS
            //MOVE BY CLICK
            playerInputs.Player.Move.performed += GetMovePosition;

            //Dont destroy on load para cambiar de escenas
            _INPUT_MANAGER = this;
            DontDestroyOnLoad(this);
        }
    }

    private void GetMovePosition(InputAction.CallbackContext context)
    {

    }
}
