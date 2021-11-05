using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Player
{
    public class UI_HotkeyBar : MonoBehaviour
    {
        private Transform _template;
        [SerializeField] private HotkeySystemPresenter _hotkeySystemPresenter;

        // Use this for initialization
        void Start()
        {
            _template = transform.Find("toolSlotTemplate");
            _template.gameObject.SetActive(false);
            UpdateVisual();
        }

        private void SetHotkeySystem(HotkeySystemPresenter hotkeySystemPresenter)
        {
            _hotkeySystemPresenter = hotkeySystemPresenter;
        }

        private void UpdateVisual()
        {
            List<Tool> toolList = _hotkeySystemPresenter.GetToolList();
            for (int i = 0; i < toolList.Count; i++)
            {
                Tool tool = toolList[i];
                Transform toolSlotTransform = Instantiate(_template, transform);
                toolSlotTransform.gameObject.SetActive(true);
                RectTransform toolSlotRectTransform = toolSlotTransform.GetComponent<RectTransform>();
                toolSlotRectTransform.anchoredPosition = new Vector2(100f * i, 0f);

                toolSlotTransform.Find("icon").GetComponent<Image>().sprite = tool.Icon;
                toolSlotTransform.Find("numberText").GetComponent<TMPro.TextMeshProUGUI>().SetText((i + 1).ToString());

            }
        }
    }
}