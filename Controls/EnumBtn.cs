using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiichiCalc.Controls
{
    public partial class EnumBtn<T> : UserControl
    where T : Enum
    {
        private T _value;

        private readonly Array _enumValues = typeof(T).GetEnumValues();
        private readonly int _enumLen = typeof(T).GetEnumValues().Length;
        private readonly bool _supportsPrettyString = SupportsPrettyPrint();
        private readonly MethodInfo? _customStringMethod = GetPrettyStringMethod();
        private int _enumIdx = 0;
        private readonly bool _ownerDraw;

        public event EventHandler ValueChanged = null!;

        public T Value
        {
            get => _value;
            set => SetValue(value);
        }

        protected EnumBtn(bool ownerDraw = false)
        {
            InitializeComponent();

            _ownerDraw = ownerDraw;
            _value = (T)_enumValues.GetValue(0)!;

            if (_ownerDraw)
            {
                toggleBtn.Text = "";
            }

            SetValue(_value);

            toggleBtn.Primary = false;
        }

        protected void SetValue(T value)
        {
            _value = value;

            ValueChanged?.Invoke(null, EventArgs.Empty);

            if (!_ownerDraw)
            {
                toggleBtn.Text = GetString(value);
            }
        }

        private string GetString(T value)
        {
            if (_supportsPrettyString)
            {
                return (string)_customStringMethod!.Invoke(null, new object[] { value })!;
            }

            return value.ToString();
        }

        private void NextEnumValue()
        {
            _enumIdx = ++_enumIdx % _enumLen;

            Value = (T)_enumValues.GetValue(_enumIdx)!;
        }

        private void PrevEnumValue()
        {
            _enumIdx = --_enumIdx < 0 ? (_enumLen - 1) : _enumIdx;

            Value = (T)_enumValues.GetValue(_enumIdx)!;
        }

        private void toggleBtn_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NextEnumValue();
            }
            else if (e.Button == MouseButtons.Right)
            {
                PrevEnumValue();
            }
        }

        private static MethodInfo? GetPrettyStringMethod()
        {
            return typeof(T).Assembly.GetType($"{typeof(T).FullName}Presenter")?.GetMethod("ToPrettyString");
        }

        private static bool SupportsPrettyPrint()
        {
            return GetPrettyStringMethod() != null;
        }
    }
}
