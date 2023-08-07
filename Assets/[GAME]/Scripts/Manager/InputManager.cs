using Game.Signals;
using UnityEngine;
using Game.Exceptions;

namespace Game.Managers
{
    public class InputManager : MonoSingleton<InputManager>
    {
        #region Variables


        #region SerializeFields

        [SerializeField] private LayerMask layer;

        #endregion


        #endregion
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

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
                {
                    CoreGameSignals.onPositionClicked?.Invoke(hit.point);

                }
            }
        }
    }
}