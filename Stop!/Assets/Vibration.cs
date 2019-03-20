namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Vibration : MonoBehaviour
    {


        private void Update()
        {
            void OnCollisionEnter(Collision Collision)
            {

                GetComponent<VRTK_ControllerHaptics>().enabled = true;

            }

            void OnCollisionExit(Collision other)
            {
                GetComponent<VRTK_ControllerHaptics>().enabled = false;
            }
        }

        
    }
}