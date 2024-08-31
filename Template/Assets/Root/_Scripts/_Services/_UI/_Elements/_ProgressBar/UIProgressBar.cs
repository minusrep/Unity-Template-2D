﻿using UnityEngine.UIElements;

namespace Root._UI._Elements._ProgressBar
{
    public class UIProgressBar : UIElement<VisualElement>
    {
        public float Value
        {
            get => _fill.style.width.value.value;

            set => _fill.style.width = Length.Percent(value);
        }

        protected const string ProgressBarFill = "progress-bar-fill";

        protected VisualElement _fill;

        public UIProgressBar(VisualElement root) : base(root)
        {
            _fill = root.Q<VisualElement>(ProgressBarFill);
        }
    }
}
