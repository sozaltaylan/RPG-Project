using Game.Signals;
using UnityEngine;
using Game.Exceptions;

namespace Game.Managers
{
    public class InputManager : MonoSingleton<InputManager>
    {
        #region Variables

        private bool isActive = true;

        #region SerializeFields

        [SerializeField] private LayerMask ground;

        #endregion


        #endregion

        #region Events


        private void OnEnable()
        {
            EventSubscription();
        }
        private void OnDisable()
        {
            EventUnsubscription();
        }

        private void EventSubscription()
        {
            DialogueSignals.onPlayerNavigationDisable += iSActiveOrNot;
        }

        private void EventUnsubscription()
        {
            DialogueSignals.onPlayerNavigationDisable -= iSActiveOrNot;

        }


        #endregion
        #region Methods
        private void Update()
        {
            HandleUpdate();
        }


        private void HandleUpdate()
        {
            if (isActive)
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
                        if (hit.collider.TryGetComponent(out FriendlyNPCBase friendlyNpc))
                        {
                            friendlyNpc.Interact();
                        }
                    }
                }
            }
            else if (!isActive)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {

                    if (DialogueManager.Instance.ChechkDialogue())
                    {
                        DialogueSignals.onPressSpace?.Invoke();
                    }

                }
            }

        }


        public void iSActiveOrNot(bool active)
        {
            isActive = active;
        }

    }


    #endregion
}