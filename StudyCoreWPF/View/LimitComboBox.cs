using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace StudyCoreWPF.View
{
    public class LimitComboBox : ComboBox
    {
        public int MaxInputLength
        {
            get => (int) GetValue(MaxInputLengthProperty);
            set => SetValue(MaxInputLengthProperty, value);
        }

        public static readonly DependencyProperty MaxInputLengthProperty = DependencyProperty.Register(
            nameof(MaxInputLength), typeof(int), typeof(LimitComboBox), new FrameworkPropertyMetadata(0));

        public override void OnApplyTemplate()
        {
            if (this.GetTemplateChild("PART_EditableTextBox") is TextBox inputBox && MaxInputLength > 0)
            {
                inputBox.MaxLength = MaxInputLength;
            }
        }

        static LimitComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LimitComboBox),
                new FrameworkPropertyMetadata(typeof(ComboBox)));
        }
    }
}