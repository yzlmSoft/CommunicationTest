using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationTest
{
    public static class ControlUtils
    {
        public static async Task InvokeAsync(this Control ctrl, Action action)
        {
            if (ctrl.Disposing || ctrl.IsDisposed || !ctrl.IsHandleCreated)
                return;
            if (!ctrl.InvokeRequired)
            {
                action.Invoke();
                return;
            }
            await Task.Factory.FromAsync(ctrl.BeginInvoke(new Action(() =>
            {
                if (ctrl.Disposing || ctrl.IsDisposed || !ctrl.IsHandleCreated)
                    return;
                action?.Invoke();
            })), ctrl.EndInvoke);
        }
        public static async Task InvokeAsync<T>(this Control ctrl, Action<T> action, T t)
        {
            if (ctrl.Disposing || ctrl.IsDisposed || !ctrl.IsHandleCreated)
                return;
            if (!ctrl.InvokeRequired)
            {
                action.Invoke(t);
                return;
            }
            await Task.Factory.FromAsync(ctrl.BeginInvoke(new Action<T>(c =>
            {
                if (ctrl.Disposing || ctrl.IsDisposed || !ctrl.IsHandleCreated)
                    return;
                action?.Invoke(c);
            }), t), ctrl.EndInvoke);
        }
    }
}
