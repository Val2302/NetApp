using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace NetApp.Src.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void ClearAddress() => tbAddress.Clear();

        private void ClearOutput() => outputList.Items.Clear();

        private void Out(string text) => outputList.Items.Add(text);

        private void ShowError(string message) => outputList.Items.Add($"Error :\n{message}");

        private void Ping()
        {
            try
            {
                var uri = new Uri(tbAddress.Text);

                ClearOutput();

                var ping = new Ping();

                Out("Pinging server. Please wait...");

                var reply = ping.Send(uri.Host);

                Out($"{uri.Host} was pinged and replied: {reply.Status}.");

                if (reply.Status == IPStatus.Success)
                {
                    Out($"Reply from {reply.Address} took {reply.RoundtripTime:N0}ms");
                }
            }
            catch (Exception ex)
            {
                ShowError($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void ShowUri(Uri uri)
        {   
            Out($"===================================");
            Out($"          URL : {uri}              ");
            Out($"-----------------------------------");
            Out($" HostNameType : {uri.HostNameType} ");
            Out($"         Port : {uri.Port}         ");
            Out($"       Scheme : {uri.Scheme}       ");
            Out($"-----------------------------------");
            Out($"      IdnHost : {uri.IdnHost}      ");
            Out($"         Host : {uri.Host}         ");
            Out($"  AbsoluteUri : {uri.AbsoluteUri}  ");
            Out($" AbsolutePath : {uri.AbsolutePath} ");
            Out($"    Authority : {uri.Authority}    ");
            Out($"  DnsSafeHost : {uri.DnsSafeHost}  ");
            Out($"-----------------------------------");
            Out($"IsAbsoluteUri : {uri.IsAbsoluteUri}");
            Out($"IsDefaultPort : {uri.IsDefaultPort}");
            Out($"       IsFile : {uri.IsFile}       ");
            Out($"   IsLoopback : {uri.IsLoopback}   ");
            Out($"        IsUnc : {uri.IsUnc}        ");
            Out($"-----------------------------------");
            Out($" PathAndQuery : {uri.PathAndQuery} ");
            Out($"    LocalPath : {uri.LocalPath}    ");
            Out($"        Query : {uri.Query}        ");
            Out($"-----------------------------------");
            Out($"     Segments : {uri.Segments}     ");
            Out($"  UserEscaped : {uri.UserEscaped}  ");
            Out($"     UserInfo : {uri.UserInfo}     ");
            Out($"     Fragment : {uri.Fragment}     ");
            Out($"===================================");
        }

        private void ShowEntry(IPHostEntry hostEntry)
        {
            Out( $"=====================================" );
            Out( $"  HostEntry : {hostEntry}            " );
            Out( $"-------------------------------------" );
            Out( $"AddressList : {hostEntry.AddressList}" );
            Out( $"   HostName : {hostEntry.HostName}   " );
            Out( $"    Aliases : {hostEntry.Aliases}    " );
            Out( $"=====================================" );
        }

        private void ShowHostEntry()
        {
            try
            {
                ClearOutput();

                var uri = new Uri(tbAddress.Text);
                ShowUri(uri);
                Out("");

                var entry = Dns.GetHostEntry(uri.Host);
                ShowEntry(entry);
                Out("");

                foreach (var address in entry.AddressList)
                {
                    Out($" {address} ({address.AddressFamily})");
                }

                Out("");
            }
            catch (Exception ex)
            {
                ShowError($"{ex.GetType()} says {ex.Message}");
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                Ping();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                ShowHostEntry();
            }

            if (e.Control && e.KeyCode == Keys.Back)
            {
                ClearAddress();
            }

            if (e.Control && e.KeyCode == Keys.Delete)
            {
                ClearOutput();
            }
        }

        private void ImgPing_Click(object sender, EventArgs e)
        {
            Ping();
        }

        private void ImgClearAddress_Click(object sender, EventArgs e)
        {
            ClearAddress();
        }

        private void ImgCleanOutputList_Click(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void ImgShowHostEntry_Click(object sender, EventArgs e)
        {
            ShowHostEntry();
        }
    }
}
