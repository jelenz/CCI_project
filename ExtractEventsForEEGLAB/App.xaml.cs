﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CCIUtilities;

namespace ExtractEvents
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
#if DEBUG
            e.Handled = false;
#else
            Exception ex = e.Exception;
            ErrorWindow ew = new ErrorWindow();
            ew.Message = "Sender: "+sender.ToString()+"\r\nIn " + ex.TargetSite + ": " + ex.Message +
                ";\r\n" + ex.StackTrace;
            ew.ShowDialog();
            Environment.Exit(-1);
#endif
        }
    }
}
