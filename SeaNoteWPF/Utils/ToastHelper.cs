using System;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages; 

namespace SeaNoteWPF.Utils
{
    public static class ToastHelper
    {
        private static Notifier _notifier;

        static ToastHelper()
        {
            _notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.BottomRight,
                    offsetX: 15,
                    offsetY: 15);

                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(3),
                    maximumNotificationCount: MaximumNotificationCount.FromCount(5));

                cfg.Dispatcher = Application.Current.Dispatcher;
            });
        }

        public static void ShowSuccess(string message)
        {
            _notifier.ShowSuccess(message);
        }

        public static void ShowError(string message)
        {
            _notifier.ShowError(message);
        }

        public static void ShowInfo(string message)
        {
            _notifier.ShowInformation(message);
        }

        public static void ShowWarning(string message)
        {
            _notifier.ShowWarning(message);
        }
    }
}