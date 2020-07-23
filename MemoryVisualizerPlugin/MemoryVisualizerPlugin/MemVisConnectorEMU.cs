using MemoryVisualizerPlugin.UI;
using NLog;
using RTCV.Common;
using RTCV.CorruptCore;
using RTCV.NetCore;
using System;
using System.Windows.Forms;

namespace MemoryVisualizerPlugin
{
    internal class MemVisConnectorEMU : IRoutable
    {
        public MemVisConnectorEMU()
        {
            LocalNetCoreRouter.registerEndpoint(this, Ep.EMU_SIDE);
        }

        public object OnMessageReceived(object sender, NetCoreEventArgs e)
        {
            NetCoreAdvancedMessage message = e.message as NetCoreAdvancedMessage;
            switch (e.message.Type)
            {
                case Commands.SHOW_WINDOW:
                    try
                    {
                        SyncObjectSingleton.FormExecute(() =>
                        {
                            if (((Control)S.GET<MemoryVisualizer>()).IsDisposed)
                            {
                                Loader.PluginForm = new MemoryVisualizer();
                                S.SET<MemoryVisualizer>(Loader.PluginForm);
                            }
                            ((Control)S.GET<MemoryVisualizer>()).Show();
                            ((Form)S.GET<MemoryVisualizer>()).Activate();
                        });
                        break;
                    }
                    catch
                    {
                        Logging.GlobalLogger.Error("MemVisConnectorEMU: SHOW_WINDOW failed Reason:\r\n" + e.ToString());
                        break;
                    }
                //case Commands.BYTESGET:
                //    try
                //    {
                //        Tuple<long, long, string> objectValue = (Tuple<long, long, string>)message.objectValue;
                //        e.setReturnValue((object)this.GetByteArr(objectValue.Item1, objectValue.Item2, objectValue.Item3));
                //        break;
                //    }
                //    catch (Exception ex)
                //    {
                //        if (!(ex is ArgumentNullException))
                //        {
                //            NullReferenceException referenceException = ex as NullReferenceException;
                //            break;
                //        }
                //        break;
                //    }
            }
            return e.returnMessage;
        }

        //private byte[] GetByteArr(long start, long end, string domain)
        //{
        //    MemoryInterface memoryInterface = MemoryDomains.GetInterface(domain);
        //    return end >= memoryInterface.get_Size() ? (byte[])null : memoryInterface.PeekBytes(start, end, true);
        //}
    }
}
