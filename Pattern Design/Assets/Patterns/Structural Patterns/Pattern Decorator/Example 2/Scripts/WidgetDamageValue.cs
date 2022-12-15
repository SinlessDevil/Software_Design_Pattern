using UnityEngine;

namespace Decorator.Example2
{
    public class WidgetDamageValue : MonoBehaviour
    {
        [SerializeField] private TMPro.TMP_Text _textValue;

        public void SetValue(string newValue)
        {
            _textValue.text = newValue;
        }

        public void SetColor(Color color)
        {
            _textValue.color = color;
        }

        private void Handle_AnimationOver()
        {
            Destroy(gameObject);
        }
    }
}