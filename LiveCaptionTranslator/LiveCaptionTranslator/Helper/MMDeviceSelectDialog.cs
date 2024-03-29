﻿using NAudio.CoreAudioApi;
using System.Linq;
using System.Windows.Forms;

namespace LiveCaptionTranslator.Models.Helper
{
    public static class MMDeviceSelectDialog
    {
        public static MMDevice ShowDialog(string caption, MMDeviceCollection collections)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 200;
            prompt.Text = caption;
            prompt.ControlBox = false;
            prompt.TopMost = true;

            ComboBox comboBox = new ComboBox() { Left = 10, Top = 10, Width = 200 };
            comboBox.Items.AddRange(collections.Select(item => item.FriendlyName).ToArray());
            comboBox.SelectedIndex = 0;
            Button confirmation = new Button() { Left = 10, Width = 30, Top = 50, Text = "Ok" };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();
            return collections.Where(item => item.FriendlyName == comboBox.SelectedItem.ToString()).FirstOrDefault();
        }
    }
}
