using Game.Signals;
using UnityEngine;
using Game.Exceptions;

namespace Game.Managers
{
    public class InputManager : MonoSingleton<InputManager>
    {
        #region Variables


        #region SerializeFields

        [SerializeField] private LayerMask ground;

        #endregion


        #endregion

        #region Methods
        private void Update()
        {
            HandleUpdate();
        }


        private void HandleUpdate()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
                {
                    CoreGameSignals.onPositionClicked?.Invoke(hit.point);

                }
            }
            else if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.TryGetComponent(out BaseNPC npc))
                    {
                        npc.Interact();
                    }
                }
            }
        }
    }
    #endregion
}