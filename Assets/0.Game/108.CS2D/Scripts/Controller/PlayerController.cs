using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame.CS2D
{
    public class PlayerController : Controller
    {
        public FixedJoystick joystickMove;
        public FixedJoystick joystickShoot;

        protected override void Move()
        {
            base.Move();

            character.moverment.move = joystickMove.Direction;

            if (joystickShoot.Horizontal != 0)
            {
                character.moverment.rotate = joystickShoot.Direction;
            }
            else
            {
                character.moverment.rotate = joystickMove.Direction;
            }
        }

        protected override void Update()
        {
            base.Update();
            // if (Input.GetKey(KeyCode.Mouse0))
            // {
            //     Vector3 mousePos = Input.mousePosition;
            //     Debug.Log(Camera.main.gameObject.name);

            //     Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));
            // }
        }

        public void ActiveJoystickMove()
        {
            ActiveJoystick(joystickMove);
        }

        public void DeActiveJoystickMove()
        {
            DeActiveJoystick(joystickMove);
        }

        public void ActiveJoystickShoot()
        {
            ActiveJoystick(joystickShoot);
        }

        public void DeActiveJoystickShoot()
        {
            DeActiveJoystick(joystickShoot);
        }

        public void ActiveJoystick(Joystick joystick)
        {
            var images = joystick.GetComponentsInChildren<Image>();

            foreach (var item in images)
            {
                item.color = new Color(1, 1, 1, 0.2f);
            }
        }

        public void DeActiveJoystick(Joystick joystick)
        {
            var images = joystick.GetComponentsInChildren<Image>();

            foreach (var item in images)
            {
                item.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
