using UnityEngine;

namespace SimpleStateMachine
{
    public class ButtonContoller : MonoBehaviour
    {
        [SerializeField] private GameObject _panelRed;
        [SerializeField] private GameObject _panelBlue;

        private void Start()
        {
            ShowRedPanel();
        }

        public void ShowRedPanel()
        {
            ShowPanel(true);
        }

        public void ShowBluePanel()
        {
            ShowPanel(false);
        }

        private void ShowPanel(bool isActive)
        {
            _panelRed.SetActive(isActive);
            _panelBlue.SetActive(!isActive);
        }
    }
}