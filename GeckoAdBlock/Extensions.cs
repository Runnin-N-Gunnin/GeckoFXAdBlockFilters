using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GeckoAdBlock
{
    public static class Extensions
    {
        public delegate void InvokeIfRequiredDelegate<in T>(T obj) where T : ISynchronizeInvoke;

        public static void InvokeIfRequired<T>(this T obj, InvokeIfRequiredDelegate<T> action) where T : ISynchronizeInvoke
        {
            if (obj.InvokeRequired)
            {
                obj.Invoke(action, new object[] {obj});
            }
            else
            {
                action(obj);
            }
        }

        public static bool ContainsAnyOf(this string source, List<string> strings)
        {
            return strings.Any(source.Contains);
        }

        public static ListViewItem AddRow(this ListView lvw, int imageIndex, params string[] values)
        {
            ListViewItem newItem = new ListViewItem(values, imageIndex);
            lvw.Items.Add(newItem);
            return newItem;
        }

        public static void WriteLog(this RichTextBox box, string text, Color color, bool addNewLine = true)
        {
            box.BeginInvoke(new Action(() =>
            {
                box.SuspendLayout();
                box.SelectionColor = color;
                box.AppendText(addNewLine
                    ? $"{text}{Environment.NewLine}"
                    : text);
                box.ScrollToCaret();
                box.ResumeLayout();
            }));
            Debug.WriteLine(text);
        }
    }
}
