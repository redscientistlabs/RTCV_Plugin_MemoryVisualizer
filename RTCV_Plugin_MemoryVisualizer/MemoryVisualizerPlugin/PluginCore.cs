using MemoryVizualizer.UI;
using NLog;
using RTCV.Common;
using RTCV.NetCore;
using RTCV.PluginHost;
using RTCV.UI;
using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace MemoryVizualizer
{
    [Export(typeof(IPlugin))]
    public class PluginCore : IPlugin, IDisposable
    {
        public static RTCSide CurrentSide = RTCSide.Both;
        //public static PluginForm PluginForm = (PluginForm)null;
        internal static MemVisConnectorEMU connectorEMU = (MemVisConnectorEMU)null;
        internal static MemVisConnectorRTC connectorRTC = (MemVisConnectorRTC)null;

        public string Name => "Memory Visualizer";
        public string Description => "Allows you to view arbitrary memory as an image";

        public string Author => "NullShock78";

        public Version Version => new Version(1, 1, 0);

        public RTCSide SupportedSide => RTCSide.Both;

        public void Dispose()
        {
        }

        public bool Start(RTCSide side)
        {
            Logging.GlobalLogger.Info(string.Format("{0} v{1} initializing.", (object)this.Name, (object)this.Version));
            if (side == RTCSide.Client)
            {
                connectorEMU = new MemVisConnectorEMU();
                S.SET<PluginForm>(new PluginForm());
            }
            else if (side == RTCSide.Server)
            {
                if (S.ISNULL<OpenToolsForm>())
                {
                    ((Logger)Logging.GlobalLogger).Error(string.Format("{0} v{1} failed to start: Singleton RTC_OpenTools_Form was null.", (object)this.Name, (object)this.Version));
                    return false;
                }
                if (S.ISNULL<CoreForm>())
                {
                    ((Logger)Logging.GlobalLogger).Error(string.Format("{0} v{1} failed to start: Singleton UI_CoreForm was null.", (object)this.Name, (object)this.Version));
                    return false;
                }
                S.GET<OpenToolsForm>().RegisterTool("Memory Visualizer", "Open Memory Visualizer", () => { LocalNetCoreRouter.Route(Ep.EMU_SIDE, Commands.SHOW_WINDOW, true); });
            }
            Logging.GlobalLogger.Info(string.Format("{0} v{1} initialized.", (object)this.Name, (object)this.Version));
            CurrentSide = side;
            return true;
        }

        public bool Stop()
        {
            if (PluginCore.CurrentSide == RTCSide.Client && !S.ISNULL<PluginForm>() && !S.GET<PluginForm>().IsDisposed)
            {
                S.GET<PluginForm>().HideOnClose = false;
                S.GET<PluginForm>().Close();
            }
            return true;
        }

        public bool StopPlugin()
        {
            if (!S.ISNULL<PluginForm>() && !S.GET<PluginForm>().IsDisposed)
            {
                S.GET<PluginForm>().HideOnClose = false;
                S.GET<PluginForm>().Close();
            }

            return true;
        }
    }
}
