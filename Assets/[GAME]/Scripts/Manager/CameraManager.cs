using UnityEngine;
using Game.Exceptions;
using Unity.VisualScripting;
using Game.Signals;

namespace Game.Managers
{
    public class CameraManager : MonoSingleton<CameraManager>
    {
        #region Variables

        [SerializeField] private Animator cameraAnimator;

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
            CameraSignals.cameraState += SetCameraAnimation;
        }
        private void EventUnsubscription()
        {
            CameraSignals.cameraState -= SetCameraAnimation;

        }
        #endregion

        #region Methods

        public void SetCameraAnimation(CameraAnimationState state, bool active)
        {
            cameraAnimator.SetBool(state.ToString(), active);
        }

        #endregion
    }
}
