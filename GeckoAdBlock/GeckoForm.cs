using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Gecko;
using Gecko.Events;

namespace GeckoAdBlock
{
    public partial class GeckoForm : Form
    {
        // Properties for GeckoFX
        private GeckoWebBrowser geckoWB;
        private string UA = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:81.0) Gecko/20100101 Firefox/81.0";
        private readonly string referer = string.Empty;

        // Statistics
        private int numberOfBlockedDomains;

        // AdBlock Filters Class
        private FilterLists filterLists;

        public GeckoForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Xpcom.Initialize(Environment.CurrentDirectory + "\\Firefox");
            SetPreferences();
            geckoWB = new GeckoWebBrowser
            {
                Dock = DockStyle.Fill,
                UseHttpActivityObserver = true
            };

            geckoWB.ConsoleMessage += GeckoWebBrowserOnConsoleMessage;
            geckoWB.DocumentCompleted += GeckoWebBrowserOnDocumentCompleted;
            geckoWB.ObserveHttpModifyRequest += GeckoOnObserveHttpModifyRequest;
            geckoWB.NSSError += GeckoWebBrowserOnError;
            panelWB.Controls.Add(geckoWB);

            InitializeAdBlockFilterLists(); // <=
        }

        // Navigation Buttons
        private void btnNavigate_Click(object sender, EventArgs e) => Navigate(txtUrl.Text);
        private void btnBack_Click(object sender, EventArgs e) => geckoWB.GoBack();
        private void btnFwd_Click(object sender, EventArgs e) => geckoWB.GoForward();

        // AdBlock Filters
        private void InitializeAdBlockFilterLists()
        {
            filterLists = new FilterLists();

            // [OPTIONAL] Custom Domain/Keyword Filter List
            filterLists.AddCustomDomainOrKeyword("example.org"); // Single entry
            filterLists.AddCustomDomainsOrKeywords("chartbeat", "website.com", "fingerprint", "pubid", "onclickgenius", "trackjs", "uuid", "collector", "id?", "id="); // Multiple entries

            // Load Filter Lists
            filterLists.LoadFilterLists();

            // Update UI
            lblNumOfFltLists.Text = $@"Lists: {filterLists.NumberOfFilterLists()}";
            lblNumOfDomains.Text  = $@"Domains: {filterLists.NumberOfEntries()}";
        }

        private void Navigate(string url)
        {
            if (string.IsNullOrWhiteSpace(txtUrl.Text)) return;
            richTxtBoxConsole.WriteLog($@"Navigating to {url}", Color.FromKnownColor(KnownColor.Info));
            geckoWB.Navigate(url, GeckoLoadFlags.BypassHistory, referer, null);
        }

        private void GeckoWebBrowserOnDocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e) => txtUrl.Text = e.Uri.ToString();

        private void OnBlockUpdateUI(string blockedurl)
        {
            numberOfBlockedDomains++;
            grpBoxBlocked.InvokeIfRequired(o =>
            {
                o.Text = $@"Blocked Domain(s): {numberOfBlockedDomains}";
            });
            lstViewBlocked.InvokeIfRequired(o =>
            {
                o.AddRow(0, blockedurl);
            });
        }

        // Intercept Request(s)
        private void GeckoOnObserveHttpModifyRequest(object sender, GeckoObserveHttpModifyRequestEventArgs e)
        {
            string requesturl = e.Channel.Uri.ToString();

            if (requesturl.ContainsAnyOf(filterLists.FilterList) || requesturl.ContainsAnyOf(filterLists.FilterListCustom))
            {
                richTxtBoxConsole.WriteLog($@"[AdBlock]: {requesturl}", Color.DeepPink);
                e.Cancel = true;
                OnBlockUpdateUI(requesturl);
            }
            else
            {
                //Debug.WriteLine($@"Allow: {requesturl}");
                e.Cancel = false;
            }
        }

        private void GeckoWebBrowserOnConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            richTxtBoxConsole.WriteLog($@"[GeckoConsoleMessage]: {e.Message}", Color.DodgerBlue);
            Debug.WriteLine(Environment.NewLine + e.Message);
        }

        private void GeckoWebBrowserOnError(object sender, GeckoNSSErrorEventArgs e)
        {
            if (e.Message.Contains("Certificate"))
            {
                CertOverrideService.GetService().RememberValidityOverride(e.Uri, e.Certificate, CertOverride.Mismatch | CertOverride.Time | CertOverride.Untrusted, false);
                if (!e.Uri.AbsoluteUri.Contains(".js") && !e.Uri.AbsoluteUri.Contains(".css")) geckoWB.Navigate(e.Uri.AbsoluteUri);
                e.Handled = true;
            }
        }

        // GeckoFX prefs
        private void SetPreferences()
        {
            GeckoPreferences.User["beacon.enabled"] = false;
            GeckoPreferences.User["browser.cache.disk.enable"] = false;
            GeckoPreferences.User["browser.cache.memory.enable"] = false;
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = false;
            GeckoPreferences.User["browser.download.manager.showAlertOnComplete"] = false;
            GeckoPreferences.User["browser.send_pings"] = false;
            GeckoPreferences.User["dom.max_script_run_time"] = 10; // ??
            GeckoPreferences.User["general.useragent.override"] = UA;
            GeckoPreferences.User["intl.accept_languages"] = "en-US,en;q=0.5";
            GeckoPreferences.User["media.navigator.enabled"] = false;
            GeckoPreferences.User["media.navigator.permission.disabled"] = true;
            GeckoPreferences.User["media.peerconnection.enabled"] = false;
            GeckoPreferences.User["network.http.referer.spoofSource"] = true;
            GeckoPreferences.User["places.history.enabled"] = false;
            GeckoPreferences.User["plugin.state.flash"] = 0;
            GeckoPreferences.User["plugins.enumerable_names"] = string.Empty;
            GeckoPreferences.User["privacy.popups.showBrowserMessage"] = false;
            GeckoPreferences.User["privacy.firstparty.isolate"] = true;
            GeckoPreferences.User["privacy.trackingprotection.enabled"] = true;
            GeckoPreferences.User["privacy.resistFingerprinting"] = true;
            GeckoPreferences.User["security.warn_viewing_mixed"] = false;
            GeckoPreferences.User["security.ssl.errorReporting.url"] = "";
            GeckoPreferences.User["toolkit.telemetry.enabled"] = false;
            GeckoPreferences.User["toolkit.telemetry.server"] = "";
        }

        private void GeckoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                geckoWB.Dispose();
                Xpcom.Shutdown();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
    }
}
